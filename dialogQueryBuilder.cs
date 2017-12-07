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
    public partial class dialogQueryBuilder : Form
    {
        public String generatedQuery;
        public dialogQueryBuilder()
        {
            InitializeComponent();
        }

        private void dialogQueryBuilder_Load(object sender, EventArgs e)
        {
            MessageBox.Show("test", "caption", MessageBoxButtons.OK);
        }

        private void buttonBuildQuery_Click(object sender, EventArgs e)
        {
            //after generating query and storing it to generatedQuery
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
