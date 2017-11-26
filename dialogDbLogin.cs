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
    public partial class dialogDbLogin : Form
    {
        public String username, password, host, service;

        public dialogDbLogin()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            username = textBoxUser.Text;
            password = textBoxPass.Text;
            host = textBoxHostname.Text;
            service = textBoxServicename.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            String help = @"Hostname: ""select sys_context('userenv', 'server_host') from dual;""
Servicename: select sys_context('userenv','instance_name') from dual;"" (default = ""xe"" for Express Edition)
(Make sure you have required permissions)";
            MessageBox.Show(help, "Help", MessageBoxButtons.OK);
        }
    }
}
