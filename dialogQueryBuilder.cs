using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace sqlReport
{
    public partial class dialogQueryBuilder : Form
    {
        public OracleConnection conn;
        public String generatedQuery;

        List<Boolean> cached;
        List<CheckedListBox.ObjectCollection> cached_colls;

        public dialogQueryBuilder()
        {
            InitializeComponent();
        }

        private void dialogQueryBuilder_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select table_name from user_tables order by last_analyzed desc";
            OracleDataReader reader;
            List<String> table_names = new List<string>();
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    table_names.Add(reader[0].ToString());
                    checkedListBoxTables.Items.Add(reader[0].ToString());
                }
                reader.Close();
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }

            cached = new List<bool>(checkedListBoxTables.Items.Count);
            for (int i = 0; i < checkedListBoxTables.Items.Count;i++ )
                cached[i] = false;
            cached_colls = new List<CheckedListBox.ObjectCollection>();
        }

        private void buttonBuildQuery_Click(object sender, EventArgs e)
        {
            //after generating query and storing it to generatedQuery
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void checkedListBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBoxFields.Items.Clear();

            int sel = checkedListBoxTables.SelectedIndex;
            if(cached[sel])
            {
                checkedListBoxFields.Items.AddRange(cached_colls[sel]);
            }
            else
            {
                String table = checkedListBoxTables.SelectedItem.ToString();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.BindByName = true;
                cmd.CommandText = "select column_name from user_tab_columns where table_name = :tablename";
                cmd.Parameters.Add(new OracleParameter("tablename", table));

                OracleDataReader reader;
                List<String> column_names = new List<string>();
                try
                {
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        column_names.Add(reader[0].ToString());
                        checkedListBoxFields.Items.Add(reader[0].ToString());
                    }
                    reader.Close();
                }
                catch (OracleException ex)
                {
                    Console.WriteLine(ex.ToString());
                    return;
                }

                cached[sel] = true;
                cached_colls[sel].AddRange(checkedListBoxFields.Items);
            }


            
        }
    }
}
