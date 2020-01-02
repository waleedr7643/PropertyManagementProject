namespace TMR.GP.REMSAddin.UserForms
{
    partial class frmNotClearedReceiptReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotClearedReceiptReport));
            this.lblProject = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbLoad = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbSizeCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dTPToDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dTPFromDate = new System.Windows.Forms.DateTimePicker();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(19, 85);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(40, 13);
            this.lblProject.TabIndex = 270;
            this.lblProject.Text = "Project";
            // 
            // cmbProject
            // 
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(84, 77);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(189, 21);
            this.cmbProject.TabIndex = 269;
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCancel,
            this.tsbLoad});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(288, 64);
            this.toolStrip2.TabIndex = 294;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbCancel
            // 
            this.tsbCancel.AutoSize = false;
            this.tsbCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(43, 60);
            this.tsbCancel.Text = "Close";
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // tsbLoad
            // 
            this.tsbLoad.AutoSize = false;
            this.tsbLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLoad.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoad.Image")));
            this.tsbLoad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLoad.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsbLoad.Name = "tsbLoad";
            this.tsbLoad.Size = new System.Drawing.Size(43, 60);
            this.tsbLoad.Text = "Load";
            this.tsbLoad.ToolTipText = "Load";
            this.tsbLoad.Click += new System.EventHandler(this.tsbLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 300;
            this.label2.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "New",
            "Cancelled",
            "Refunded",
            "Reactivated",
            "Transferred"});
            this.cmbStatus.Location = new System.Drawing.Point(84, 129);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(189, 21);
            this.cmbStatus.TabIndex = 299;
            // 
            // cmbSizeCode
            // 
            this.cmbSizeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSizeCode.FormattingEnabled = true;
            this.cmbSizeCode.Location = new System.Drawing.Point(84, 103);
            this.cmbSizeCode.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSizeCode.Name = "cmbSizeCode";
            this.cmbSizeCode.Size = new System.Drawing.Size(189, 21);
            this.cmbSizeCode.TabIndex = 301;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 302;
            this.label1.Text = "Size Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 306;
            this.label3.Text = "To Date";
            // 
            // dTPToDate
            // 
            this.dTPToDate.CustomFormat = "dd/MM/yyy";
            this.dTPToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPToDate.Location = new System.Drawing.Point(84, 181);
            this.dTPToDate.Margin = new System.Windows.Forms.Padding(2);
            this.dTPToDate.Name = "dTPToDate";
            this.dTPToDate.Size = new System.Drawing.Size(189, 20);
            this.dTPToDate.TabIndex = 305;
            this.dTPToDate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 304;
            this.label4.Text = "From Date";
            // 
            // dTPFromDate
            // 
            this.dTPFromDate.CustomFormat = "dd/MM/yyy";
            this.dTPFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPFromDate.Location = new System.Drawing.Point(84, 156);
            this.dTPFromDate.Margin = new System.Windows.Forms.Padding(2);
            this.dTPFromDate.Name = "dTPFromDate";
            this.dTPFromDate.Size = new System.Drawing.Size(189, 20);
            this.dTPFromDate.TabIndex = 303;
            this.dTPFromDate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // frmNotClearedReceiptReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 210);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dTPToDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dTPFromDate);
            this.Controls.Add(this.cmbSizeCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.cmbProject);
            this.Name = "frmNotClearedReceiptReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Cleared Receipts Report";
            this.Load += new System.EventHandler(this.frmSoldPlotsReport_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripButton tsbLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbSizeCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dTPToDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dTPFromDate;
    }
}