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
            this.checkedListBoxTables = new System.Windows.Forms.CheckedListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.checkedListBoxFields = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // buttonBuildQuery
            // 
            this.buttonBuildQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuildQuery.Location = new System.Drawing.Point(340, 482);
            this.buttonBuildQuery.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuildQuery.Name = "buttonBuildQuery";
            this.buttonBuildQuery.Size = new System.Drawing.Size(217, 38);
            this.buttonBuildQuery.TabIndex = 0;
            this.buttonBuildQuery.Text = "Build Query";
            this.buttonBuildQuery.UseVisualStyleBackColor = true;
            this.buttonBuildQuery.Click += new System.EventHandler(this.buttonBuildQuery_Click);
            // 
            // checkedListBoxTables
            // 
            this.checkedListBoxTables.FormattingEnabled = true;
            this.checkedListBoxTables.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxTables.Name = "checkedListBoxTables";
            this.checkedListBoxTables.Size = new System.Drawing.Size(183, 463);
            this.checkedListBoxTables.TabIndex = 1;
            this.checkedListBoxTables.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxTables_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(662, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(220, 463);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // checkedListBoxFields
            // 
            this.checkedListBoxFields.FormattingEnabled = true;
            this.checkedListBoxFields.Location = new System.Drawing.Point(201, 12);
            this.checkedListBoxFields.Name = "checkedListBoxFields";
            this.checkedListBoxFields.Size = new System.Drawing.Size(264, 463);
            this.checkedListBoxFields.TabIndex = 3;
            // 
            // dialogQueryBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 526);
            this.Controls.Add(this.checkedListBoxFields);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.checkedListBoxTables);
            this.Controls.Add(this.buttonBuildQuery);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dialogQueryBuilder";
            this.Text = "dialogQueryBuilder";
            this.Load += new System.EventHandler(this.dialogQueryBuilder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBuildQuery;
        private System.Windows.Forms.CheckedListBox checkedListBoxTables;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckedListBox checkedListBoxFields;
    }
}