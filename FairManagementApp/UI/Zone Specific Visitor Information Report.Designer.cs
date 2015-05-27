namespace FairManagementApp.UI
{
    partial class Zone_Specific_Visitor_Information_Report
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
            this.listViewZoneSpecific = new System.Windows.Forms.ListView();
            this.columnHeaderVisitorName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderContactNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxZoneSelect = new System.Windows.Forms.ComboBox();
            this.buttonShowVisitor = new System.Windows.Forms.Button();
            this.buttonExportToExcel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTotalVisitorPerZone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewZoneSpecific
            // 
            this.listViewZoneSpecific.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderVisitorName,
            this.columnHeaderEmail,
            this.columnHeaderContactNum});
            this.listViewZoneSpecific.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewZoneSpecific.FullRowSelect = true;
            this.listViewZoneSpecific.GridLines = true;
            this.listViewZoneSpecific.Location = new System.Drawing.Point(30, 70);
            this.listViewZoneSpecific.Name = "listViewZoneSpecific";
            this.listViewZoneSpecific.Size = new System.Drawing.Size(559, 152);
            this.listViewZoneSpecific.TabIndex = 0;
            this.listViewZoneSpecific.UseCompatibleStateImageBehavior = false;
            this.listViewZoneSpecific.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderVisitorName
            // 
            this.columnHeaderVisitorName.Text = "Visitor Name";
            this.columnHeaderVisitorName.Width = 156;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.Width = 226;
            // 
            // columnHeaderContactNum
            // 
            this.columnHeaderContactNum.Text = "Contact Number";
            this.columnHeaderContactNum.Width = 168;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Zone";
            // 
            // comboBoxZoneSelect
            // 
            this.comboBoxZoneSelect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxZoneSelect.FormattingEnabled = true;
            this.comboBoxZoneSelect.Location = new System.Drawing.Point(214, 13);
            this.comboBoxZoneSelect.Name = "comboBoxZoneSelect";
            this.comboBoxZoneSelect.Size = new System.Drawing.Size(206, 27);
            this.comboBoxZoneSelect.TabIndex = 2;
            this.comboBoxZoneSelect.Click += new System.EventHandler(this.comboBoxZoneSelect_Click);
            // 
            // buttonShowVisitor
            // 
            this.buttonShowVisitor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowVisitor.Location = new System.Drawing.Point(426, 10);
            this.buttonShowVisitor.Name = "buttonShowVisitor";
            this.buttonShowVisitor.Size = new System.Drawing.Size(75, 30);
            this.buttonShowVisitor.TabIndex = 3;
            this.buttonShowVisitor.Text = "Show";
            this.buttonShowVisitor.UseVisualStyleBackColor = true;
            this.buttonShowVisitor.Click += new System.EventHandler(this.buttonShowVisitor_Click);
            // 
            // buttonExportToExcel
            // 
            this.buttonExportToExcel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportToExcel.Location = new System.Drawing.Point(469, 269);
            this.buttonExportToExcel.Name = "buttonExportToExcel";
            this.buttonExportToExcel.Size = new System.Drawing.Size(120, 32);
            this.buttonExportToExcel.TabIndex = 4;
            this.buttonExportToExcel.Text = "Export To Excel";
            this.buttonExportToExcel.UseVisualStyleBackColor = true;
            this.buttonExportToExcel.Click += new System.EventHandler(this.buttonExportToExcel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total";
            // 
            // textBoxTotalVisitorPerZone
            // 
            this.textBoxTotalVisitorPerZone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalVisitorPerZone.Location = new System.Drawing.Point(465, 235);
            this.textBoxTotalVisitorPerZone.Name = "textBoxTotalVisitorPerZone";
            this.textBoxTotalVisitorPerZone.Size = new System.Drawing.Size(124, 26);
            this.textBoxTotalVisitorPerZone.TabIndex = 6;
            // 
            // Zone_Specific_Visitor_Information_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 320);
            this.Controls.Add(this.textBoxTotalVisitorPerZone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonExportToExcel);
            this.Controls.Add(this.buttonShowVisitor);
            this.Controls.Add(this.comboBoxZoneSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewZoneSpecific);
            this.Name = "Zone_Specific_Visitor_Information_Report";
            this.Text = "Zone Specific Visitor Information Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewZoneSpecific;
        private System.Windows.Forms.ColumnHeader columnHeaderVisitorName;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderContactNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxZoneSelect;
        private System.Windows.Forms.Button buttonShowVisitor;
        private System.Windows.Forms.Button buttonExportToExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTotalVisitorPerZone;
    }
}