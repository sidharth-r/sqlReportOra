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
            this.panelOutputText = new System.Windows.Forms.Panel();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.panelOutputData = new System.Windows.Forms.Panel();
            this.dataGridViewOutput = new System.Windows.Forms.DataGridView();
            this.panelOutputEmpty = new System.Windows.Forms.Panel();
            this.buttonAddElement = new System.Windows.Forms.Button();
            this.buttonSkipElement = new System.Windows.Forms.Button();
            this.panelOutputText.SuspendLayout();
            this.panelOutputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxQueries
            // 
            this.textBoxQueries.Location = new System.Drawing.Point(12, 42);
            this.textBoxQueries.Multiline = true;
            this.textBoxQueries.Name = "textBoxQueries";
            this.textBoxQueries.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQueries.Size = new System.Drawing.Size(689, 124);
            this.textBoxQueries.TabIndex = 0;
            // 
            // buttonProcessSql
            // 
            this.buttonProcessSql.Location = new System.Drawing.Point(12, 433);
            this.buttonProcessSql.Name = "buttonProcessSql";
            this.buttonProcessSql.Size = new System.Drawing.Size(553, 55);
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
            // panelOutputText
            // 
            this.panelOutputText.Controls.Add(this.textBoxOutput);
            this.panelOutputText.Location = new System.Drawing.Point(12, 172);
            this.panelOutputText.Name = "panelOutputText";
            this.panelOutputText.Size = new System.Drawing.Size(688, 255);
            this.panelOutputText.TabIndex = 5;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxOutput.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(688, 255);
            this.textBoxOutput.TabIndex = 0;
            // 
            // panelOutputData
            // 
            this.panelOutputData.Controls.Add(this.dataGridViewOutput);
            this.panelOutputData.Location = new System.Drawing.Point(12, 172);
            this.panelOutputData.Name = "panelOutputData";
            this.panelOutputData.Size = new System.Drawing.Size(688, 255);
            this.panelOutputData.TabIndex = 6;
            // 
            // dataGridViewOutput
            // 
            this.dataGridViewOutput.AllowUserToAddRows = false;
            this.dataGridViewOutput.AllowUserToDeleteRows = false;
            this.dataGridViewOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutput.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOutput.Name = "dataGridViewOutput";
            this.dataGridViewOutput.ReadOnly = true;
            this.dataGridViewOutput.Size = new System.Drawing.Size(688, 255);
            this.dataGridViewOutput.TabIndex = 0;
            // 
            // panelOutputEmpty
            // 
            this.panelOutputEmpty.Location = new System.Drawing.Point(12, 172);
            this.panelOutputEmpty.Name = "panelOutputEmpty";
            this.panelOutputEmpty.Size = new System.Drawing.Size(688, 255);
            this.panelOutputEmpty.TabIndex = 7;
            // 
            // buttonAddElement
            // 
            this.buttonAddElement.Location = new System.Drawing.Point(571, 433);
            this.buttonAddElement.Name = "buttonAddElement";
            this.buttonAddElement.Size = new System.Drawing.Size(129, 29);
            this.buttonAddElement.TabIndex = 8;
            this.buttonAddElement.Text = "Add element";
            this.buttonAddElement.UseVisualStyleBackColor = true;
            this.buttonAddElement.Click += new System.EventHandler(this.buttonAddElement_Click);
            // 
            // buttonSkipElement
            // 
            this.buttonSkipElement.Location = new System.Drawing.Point(571, 468);
            this.buttonSkipElement.Name = "buttonSkipElement";
            this.buttonSkipElement.Size = new System.Drawing.Size(129, 20);
            this.buttonSkipElement.TabIndex = 9;
            this.buttonSkipElement.Text = "Skip";
            this.buttonSkipElement.UseVisualStyleBackColor = true;
            this.buttonSkipElement.Click += new System.EventHandler(this.buttonSkipElement_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 500);
            this.Controls.Add(this.buttonSkipElement);
            this.Controls.Add(this.buttonAddElement);
            this.Controls.Add(this.panelOutputEmpty);
            this.Controls.Add(this.panelOutputData);
            this.Controls.Add(this.panelOutputText);
            this.Controls.Add(this.labelFilename);
            this.Controls.Add(this.textBoxFilename);
            this.Controls.Add(this.buttonProcessSql);
            this.Controls.Add(this.textBoxQueries);
            this.Name = "MainForm";
            this.Text = "SQL Report Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelOutputText.ResumeLayout(false);
            this.panelOutputText.PerformLayout();
            this.panelOutputData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQueries;
        private System.Windows.Forms.Button buttonProcessSql;
        private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.Panel panelOutputText;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Panel panelOutputData;
        private System.Windows.Forms.DataGridView dataGridViewOutput;
        private System.Windows.Forms.Panel panelOutputEmpty;
        private System.Windows.Forms.Button buttonAddElement;
        private System.Windows.Forms.Button buttonSkipElement;

    }
}

