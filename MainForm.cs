using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
//using Oracle.DataAccess.Client;
//Wusing Oracle.DataAccess.Types;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace sqlReport
{
    public partial class MainForm : Form
    {
        OracleConnection conn;
        String DB_NAME, TABLE_NAME;
        DataSet dset;
        List<String> outq;
        List<String> infoMsg;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panelOutputEmpty.Show();
            panelOutputData.Hide();
            panelOutputText.Hide();

            buttonProcessSql.Enabled = true;
            buttonAddElement.Enabled = false;
            buttonSkipElement.Enabled = false;

            

            dset = new DataSet();
            conn = null;
            dialogDbLogin login = new dialogDbLogin();
            DialogResult res = login.ShowDialog();
            String user = null, pass = null, host = null, service = null;
            if (res == DialogResult.OK)
            {
                user = login.username;
                pass = login.password;
                host = login.host;
                service = login.service;
            }
            else
            {
                Application.Exit();
            }
            String connStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=" + host + ") (PORT=1521))(CONNECT_DATA=(SERVICE_NAME="+service+")));" + "User Id=" + user + ";Password=" + pass + ";";
            conn = new OracleConnection(connStr);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex);
                MessageBox.Show(this, "Error connecting to database.", "Error", MessageBoxButtons.OK);
                Application.Exit();
            }

            MessageBox.Show("Connected to database.", "", MessageBoxButtons.OK);            
        }

        TaskCompletionSource<bool> tsk = null;

        private async void buttonProcessSql_Click(object sender, EventArgs e)
        {
            List<String> queries = textBoxQueries.Lines.ToList<String>();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            String filename = textBoxFilename.Text;
            if(filename.Length == 0)
            {
                MessageBox.Show("Enter filename.", "", MessageBoxButtons.OK);
                return;
            }

            String f = null;
            if (filename.Length > 4)
                f = filename.Substring(filename.Length-4,4);
            if(f != ".pdf")
                filename = filename + ".pdf";

            buttonProcessSql.Enabled = false;
            buttonAddElement.Enabled = true;
            buttonSkipElement.Enabled = true;

            FileStream fs = new FileStream(filename, FileMode.Create);
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();

            DataSet ds = null;
            int line = 0;

            foreach(String sql in queries)
            {
                if (sql == null || sql.Length == 0)
                    continue;

                String sqlf = sql;
                if (sql[sql.Length - 1] == ';')
                    sqlf = sql.Remove(sql.Length - 1, 1);

                String op = sql.Substring(0, sql.IndexOf(' '));
                if (op == "select")
                {
                    String[] s = sqlf.Split(' ');
                    String table = s[3];
                    if (table[table.Length - 1] == ';')
                        table = table.Remove(table.Length - 1, 1);

                    cmd.CommandText = sqlf;
                    try
                    {
                        ds = new DataSet();
                        OracleDataAdapter da = new OracleDataAdapter(sqlf, conn);
                        da.Fill(ds, table);
                        dataGridViewOutput.DataSource = ds;
                        dataGridViewOutput.DataMember = table;
                        panelOutputEmpty.Hide();
                        panelOutputText.Hide();
                        panelOutputData.Show();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
                else if(op == "exec")
                {
                    outq = new List<string>();
                    conn.InfoMessage += new OracleInfoMessageEventHandler(conn_InfoMsgHandler);
                    infoMsg = new List<string>();

                    String[] s = sqlf.Split(' ');
                    String proc = s[1];                    

                    try
                    {
                        cmd.Parameters.Clear();

                        cmd.CommandText = @"begin 
                                            dbms_output.enable(1000); 
                                            end;";
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = proc;
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                        
                        string out_string;
                        int status = 0;
                        cmd.CommandText = "BEGIN DBMS_OUTPUT.GET_LINE (:out_string, :status); END;";
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add("out_string", OracleDbType.Varchar2, 32000);
                        cmd.Parameters.Add("status", OracleDbType.Double);
                        cmd.Parameters[0].Direction = System.Data.ParameterDirection.Output;
                        cmd.Parameters[1].Direction = System.Data.ParameterDirection.Output;
                        while(status != 1)
                        {
                            cmd.ExecuteNonQuery();
                            out_string = cmd.Parameters[0].Value.ToString();
                            outq.Add(out_string);
                            status = int.Parse(cmd.Parameters[1].Value.ToString());
                        }
                        
                        if(outq[outq.Count-1] == "null")
                        {
                            outq.RemoveAt(outq.Count - 1);
                        }
                        textBoxOutput.Clear();
                        foreach (String l in outq)
                        {
                            textBoxOutput.AppendText(l + "\n");
                            panelOutputEmpty.Hide();
                            panelOutputData.Hide();
                            panelOutputText.Show();
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }

                int iStart = textBoxQueries.GetFirstCharIndexFromLine(line);
                line++;
                textBoxQueries.Select(iStart, sql.Length);

                tsk = new TaskCompletionSource<bool>();
                await tsk.Task;
                if(tsk.Task.Result == true)
                {
                    if(op == "select")
                    {
                        exportTable(doc, ds, sqlf);
                    }
                    else if(op == "exec")
                    {
                        doc.Add(new Phrase(sqlf + "\n"));
                        foreach (String l in outq)
                        {
                            doc.Add(new Phrase(l + "\n"));
                        }
                    }
                    doc.Add(new Phrase("\n\n"));
                }
            }

            bool docEmpty = false;
            try
            {
                doc.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Document is empty.", "", MessageBoxButtons.OK);
                docEmpty = true;
                doc.Close();
            }

            fs.Close();

            buttonProcessSql.Enabled = true;
            buttonAddElement.Enabled = false;
            buttonSkipElement.Enabled = false;

            if(!docEmpty)
                MessageBox.Show("Data exported successfully to " + filename,"",MessageBoxButtons.OK);
            
        }

        private void conn_InfoMsgHandler(object sender, OracleInfoMessageEventArgs e)
        {
            infoMsg.Add(e.Message);
        }

        private void exportTable(Document doc, DataSet ds, String query)
        {
            foreach(DataTable table in ds.Tables)
            {                
                PdfPTable ptable = new PdfPTable(table.Columns.Count);
                //ptable.WidthPercentage = 100;
                foreach(DataColumn col in table.Columns)
                {
                    ptable.AddCell(new Phrase(col.ColumnName));
                }
                ptable.CompleteRow();
                foreach(DataRow row in table.Rows)
                {
                    foreach(object o in row.ItemArray)
                    {
                        ptable.AddCell(new Phrase(o.ToString()));
                    }
                    ptable.CompleteRow();
                }
                ptable.SpacingAfter = 20;
                doc.Add(new Phrase(query+"\n"));
                doc.Add(new Phrase(table.TableName + ":"));
                doc.Add(ptable);
            }          
        }

        private void buttonAddElement_Click(object sender, EventArgs e)
        {
            tsk.TrySetResult(true);
        }

        private void buttonQueryBuilder_Click(object sender, EventArgs e)
        {
            dialogQueryBuilder dialog = new dialogQueryBuilder();
            dialog.conn = conn;
            DialogResult res = dialog.ShowDialog();
            if(res == DialogResult.OK)
            {
                // add the generated query from dialog.generatedQuery to textBoxQueries
            }

        }

        private void buttonSkipElement_Click(object sender, EventArgs e)
        {
            tsk.TrySetResult(false);
        }
    }
}
