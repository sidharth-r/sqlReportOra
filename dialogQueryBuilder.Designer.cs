namespace sqlReport
{
    partial class dialogQueryBuilder
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
            this.buttonBuildQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBuildQuery
            // 
            this.buttonBuildQuery.Location = new System.Drawing.Point(110, 155);
            this.buttonBuildQuery.Name = "buttonBuildQuery";
            this.buttonBuildQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonBuildQuery.TabIndex = 0;
            this.buttonBuildQuery.Text = "Build Query";
            this.buttonBuildQuery.UseVisualStyleBackColor = true;
            this.buttonBuildQuery.Click += new System.EventHandler(this.buttonBuildQuery_Click);
            // 
            // dialogQueryBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonBuildQuery);
            this.Name = "dialogQueryBuilder";
            this.Text = "dialogQueryBuilder";
            this.Load += new System.EventHandler(this.dialogQueryBuilder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBuildQuery;
    }
}