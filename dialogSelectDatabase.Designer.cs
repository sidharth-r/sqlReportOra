namespace sqlReport
{
    partial class dialogSelectDatabase
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
            this.textBoxDbName = new System.Windows.Forms.TextBox();
            this.buttonConfirmDbName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDbName
            // 
            this.textBoxDbName.Location = new System.Drawing.Point(12, 21);
            this.textBoxDbName.Name = "textBoxDbName";
            this.textBoxDbName.Size = new System.Drawing.Size(268, 20);
            this.textBoxDbName.TabIndex = 0;
            // 
            // buttonConfirmDbName
            // 
            this.buttonConfirmDbName.Location = new System.Drawing.Point(68, 47);
            this.buttonConfirmDbName.Name = "buttonConfirmDbName";
            this.buttonConfirmDbName.Size = new System.Drawing.Size(152, 27);
            this.buttonConfirmDbName.TabIndex = 1;
            this.buttonConfirmDbName.Text = "Confirm";
            this.buttonConfirmDbName.UseVisualStyleBackColor = true;
            this.buttonConfirmDbName.Click += new System.EventHandler(this.buttonConfirmDbName_Click);
            // 
            // dialogSelectDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 90);
            this.Controls.Add(this.buttonConfirmDbName);
            this.Controls.Add(this.textBoxDbName);
            this.Name = "dialogSelectDatabase";
            this.Text = "dialogSelectDatabase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDbName;
        private System.Windows.Forms.Button buttonConfirmDbName;
    }
}