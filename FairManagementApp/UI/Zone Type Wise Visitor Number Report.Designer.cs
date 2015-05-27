namespace FairManagementApp.UI
{
    partial class Zone_Type_Wise_Visitor_Number_Report
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
            this.listViewZoneWiseVisitor = new System.Windows.Forms.ListView();
            this.columnHeaderZone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNoOfVisitor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxZoneWiseTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewZoneWiseVisitor
            // 
            this.listViewZoneWiseVisitor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderZone,
            this.columnHeaderNoOfVisitor});
            this.listViewZoneWiseVisitor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewZoneWiseVisitor.FullRowSelect = true;
            this.listViewZoneWiseVisitor.GridLines = true;
            this.listViewZoneWiseVisitor.Location = new System.Drawing.Point(51, 30);
            this.listViewZoneWiseVisitor.Name = "listViewZoneWiseVisitor";
            this.listViewZoneWiseVisitor.Size = new System.Drawing.Size(410, 161);
            this.listViewZoneWiseVisitor.TabIndex = 0;
            this.listViewZoneWiseVisitor.UseCompatibleStateImageBehavior = false;
            this.listViewZoneWiseVisitor.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderZone
            // 
            this.columnHeaderZone.Text = "Zone";
            this.columnHeaderZone.Width = 257;
            // 
            // columnHeaderNoOfVisitor
            // 
            this.columnHeaderNoOfVisitor.Text = "No. of visitor";
            this.columnHeaderNoOfVisitor.Width = 145;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total";
            // 
            // textBoxZoneWiseTotal
            // 
            this.textBoxZoneWiseTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZoneWiseTotal.Location = new System.Drawing.Point(336, 198);
            this.textBoxZoneWiseTotal.Name = "textBoxZoneWiseTotal";
            this.textBoxZoneWiseTotal.Size = new System.Drawing.Size(125, 26);
            this.textBoxZoneWiseTotal.TabIndex = 2;
            // 
            // Zone_Type_Wise_Visitor_Number_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 261);
            this.Controls.Add(this.textBoxZoneWiseTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewZoneWiseVisitor);
            this.Name = "Zone_Type_Wise_Visitor_Number_Report";
            this.Text = "Zone Type Wise Visitor Number Report";
            this.Load += new System.EventHandler(this.Zone_Type_Wise_Visitor_Number_Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewZoneWiseVisitor;
        private System.Windows.Forms.ColumnHeader columnHeaderZone;
        private System.Windows.Forms.ColumnHeader columnHeaderNoOfVisitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxZoneWiseTotal;
    }
}