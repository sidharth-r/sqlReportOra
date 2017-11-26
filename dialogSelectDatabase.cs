using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlReport
{
    public partial class dialogSelectDatabase : Form
    {
        public String DBName;

        public dialogSelectDatabase()
        {
            InitializeComponent();
        }

        private void buttonConfirmDbName_Click(object sender, EventArgs e)
        {
            DBName = textBoxDbName.Text;
            if (DBName == null)
                this.DialogResult = System.Windows.Forms.DialogResult.Retry;
            else if (DBName.Length == 0)
                this.DialogResult = System.Windows.Forms.DialogResult.Retry;
            else
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
