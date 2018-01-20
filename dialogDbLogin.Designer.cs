namespace sqlReport
{
    partial class dialogDbLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.textBoxServicename = new System.Windows.Forms.TextBox();
            this.labelServiceName = new System.Windows.Forms.Label();
            this.textBoxHostname = new System.Windows.Forms.TextBox();
            this.labelHostname = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.buttonHelp);
            this.panelLogin.Controls.Add(this.textBoxServicename);
            this.panelLogin.Controls.Add(this.labelServiceName);
            this.panelLogin.Controls.Add(this.textBoxHostname);
            this.panelLogin.Controls.Add(this.labelHostname);
            this.panelLogin.Controls.Add(this.buttonConfirm);
            this.panelLogin.Controls.Add(this.labelPass);
            this.panelLogin.Controls.Add(this.labelUser);
            this.panelLogin.Controls.Add(this.textBoxPass);
            this.panelLogin.Controls.Add(this.textBoxUser);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(389, 336);
            this.panelLogin.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(132, 278);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(127, 30);
            this.buttonHelp.TabIndex = 5;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // textBoxServicename
            // 
            this.textBoxServicename.Location = new System.Drawing.Point(161, 143);
            this.textBoxServicename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxServicename.Name = "textBoxServicename";
            this.textBoxServicename.Size = new System.Drawing.Size(201, 22);
            this.textBoxServicename.TabIndex = 3;
            this.textBoxServicename.Text = "xe";
            // 
            // labelServiceName
            // 
            this.labelServiceName.AutoSize = true;
            this.labelServiceName.Location = new System.Drawing.Point(25, 146);
            this.labelServiceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServiceName.Name = "labelServiceName";
            this.labelServiceName.Size = new System.Drawing.Size(130, 17);
            this.labelServiceName.TabIndex = 12;
            this.labelServiceName.Text = "Service name(SID):";
            // 
            // textBoxHostname
            // 
            this.textBoxHostname.Location = new System.Drawing.Point(161, 111);
            this.textBoxHostname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxHostname.Name = "textBoxHostname";
            this.textBoxHostname.Size = new System.Drawing.Size(201, 22);
            this.textBoxHostname.TabIndex = 2;
            this.textBoxHostname.Text = "sr97-ms-i";
            // 
            // labelHostname
            // 
            this.labelHostname.AutoSize = true;
            this.labelHostname.Location = new System.Drawing.Point(76, 114);
            this.labelHostname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHostname.Name = "labelHostname";
            this.labelHostname.Size = new System.Drawing.Size(76, 17);
            this.labelHostname.TabIndex = 10;
            this.labelHostname.Text = "Hostname:";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(95, 193);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(200, 36);
            this.buttonConfirm.TabIndex = 4;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(76, 82);
            this.labelPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(73, 17);
            this.labelPass.TabIndex = 8;
            this.labelPass.Text = "Password:";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(76, 50);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(77, 17);
            this.labelUser.TabIndex = 7;
            this.labelUser.Text = "Username:";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(161, 79);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(201, 22);
            this.textBoxPass.TabIndex = 1;
            this.textBoxPass.Text = "root";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(161, 47);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(201, 22);
            this.textBoxUser.TabIndex = 0;
            this.textBoxUser.Text = "system";
            // 
            // dialogDbLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 336);
            this.Controls.Add(this.panelLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "dialogDbLogin";
            this.Text = "Oracle DB Login";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxServicename;
        private System.Windows.Forms.Label labelServiceName;
        private System.Windows.Forms.TextBox textBoxHostname;
        private System.Windows.Forms.Label labelHostname;
        private System.Windows.Forms.Button buttonHelp;

    }
}