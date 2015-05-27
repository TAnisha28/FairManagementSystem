namespace FairManagementApp.UI
{
    partial class Zone_Type_Entry
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxZoneType = new System.Windows.Forms.TextBox();
            this.buttonSaveZone = new System.Windows.Forms.Button();
            this.listViewZoneType = new System.Windows.Forms.ListView();
            this.columnHeaderZoneType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSaveZone);
            this.groupBox1.Controls.Add(this.textBoxZoneType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zone Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Name";
            // 
            // textBoxZoneType
            // 
            this.textBoxZoneType.Location = new System.Drawing.Point(146, 37);
            this.textBoxZoneType.Name = "textBoxZoneType";
            this.textBoxZoneType.Size = new System.Drawing.Size(276, 26);
            this.textBoxZoneType.TabIndex = 1;
            // 
            // buttonSaveZone
            // 
            this.buttonSaveZone.Location = new System.Drawing.Point(347, 67);
            this.buttonSaveZone.Name = "buttonSaveZone";
            this.buttonSaveZone.Size = new System.Drawing.Size(75, 29);
            this.buttonSaveZone.TabIndex = 2;
            this.buttonSaveZone.Text = "Save";
            this.buttonSaveZone.UseVisualStyleBackColor = true;
            this.buttonSaveZone.Click += new System.EventHandler(this.buttonSaveZone_Click);
            // 
            // listViewZoneType
            // 
            this.listViewZoneType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderZoneType});
            this.listViewZoneType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewZoneType.FullRowSelect = true;
            this.listViewZoneType.GridLines = true;
            this.listViewZoneType.Location = new System.Drawing.Point(39, 160);
            this.listViewZoneType.Name = "listViewZoneType";
            this.listViewZoneType.Size = new System.Drawing.Size(446, 236);
            this.listViewZoneType.TabIndex = 1;
            this.listViewZoneType.UseCompatibleStateImageBehavior = false;
            this.listViewZoneType.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderZoneType
            // 
            this.columnHeaderZoneType.Text = "Zone Type";
            this.columnHeaderZoneType.Width = 270;
            // 
            // Zone_Type_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 418);
            this.Controls.Add(this.listViewZoneType);
            this.Controls.Add(this.groupBox1);
            this.Name = "Zone_Type_Entry";
            this.Text = "Zone Type Entry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSaveZone;
        private System.Windows.Forms.TextBox textBoxZoneType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewZoneType;
        private System.Windows.Forms.ColumnHeader columnHeaderZoneType;
    }
}