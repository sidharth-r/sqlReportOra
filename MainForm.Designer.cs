namespace sqlReport
{
    partial class MainForm
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
            this.textBoxQueries = new System.Windows.Forms.TextBox();
            this.buttonProcessSql = new System.Windows.Forms.Button();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            this.labelFilename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxQueries
            // 
            this.textBoxQueries.Location = new System.Drawing.Point(12, 42);
            this.textBoxQueries.Multiline = true;
            this.textBoxQueries.Name = "textBoxQueries";
            this.textBoxQueries.Size = new System.Drawing.Size(690, 385);
            this.textBoxQueries.TabIndex = 0;
            // 
            // buttonProcessSql
            // 
            this.buttonProcessSql.Location = new System.Drawing.Point(12, 433);
            this.buttonProcessSql.Name = "buttonProcessSql";
            this.buttonProcessSql.Size = new System.Drawing.Size(690, 55);
            this.buttonProcessSql.TabIndex = 2;
            this.buttonProcessSql.Text = "Execute Queries";
            this.buttonProcessSql.UseVisualStyleBackColor = true;
            this.buttonProcessSql.Click += new System.EventHandler(this.buttonProcessSql_Click);
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.Location = new System.Drawing.Point(542, 16);
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.Size = new System.Drawing.Size(159, 20);
            this.textBoxFilename.TabIndex = 3;
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Location = new System.Drawing.Point(484, 19);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(52, 13);
            this.labelFilename.TabIndex = 4;
            this.labelFilename.Text = "Filename:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 500);
            this.Controls.Add(this.labelFilename);
            this.Controls.Add(this.textBoxFilename);
            this.Controls.Add(this.buttonProcessSql);
            this.Controls.Add(this.textBoxQueries);
            this.Name = "MainForm";
            this.Text = "SQL Report Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQueries;
        private System.Windows.Forms.Button buttonProcessSql;
        private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.Label labelFilename;

    }
}

