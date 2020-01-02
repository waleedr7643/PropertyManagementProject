namespace TMR.GP.REMSAddin.UserForms
{
    partial class frmUnitListReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnitListReport));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.cmbProjectID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBlockID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSizeCode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPrint,
            this.tsbCancel});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(286, 60);
            this.toolStrip2.TabIndex = 219;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbPrint
            // 
            this.tsbPrint.AutoSize = false;
            this.tsbPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(43, 60);
            this.tsbPrint.Text = "Print";
            this.tsbPrint.ToolTipText = "Load";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
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
            this.tsbCancel.Size = new System.Drawing.Size(43, 57);
            this.tsbCancel.Text = "Close";
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // cmbProjectID
            // 
            this.cmbProjectID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjectID.FormattingEnabled = true;
            this.cmbProjectID.Location = new System.Drawing.Point(81, 74);
            this.cmbProjectID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProjectID.Name = "cmbProjectID";
            this.cmbProjectID.Size = new System.Drawing.Size(187, 21);
            this.cmbProjectID.TabIndex = 220;
            this.cmbProjectID.SelectedIndexChanged += new System.EventHandler(this.cmbProjectID_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 221;
            this.label5.Text = "Project ID";
            // 
            // cmbBlockID
            // 
            this.cmbBlockID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlockID.FormattingEnabled = true;
            this.cmbBlockID.Location = new System.Drawing.Point(81, 99);
            this.cmbBlockID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBlockID.Name = "cmbBlockID";
            this.cmbBlockID.Size = new System.Drawing.Size(187, 21);
            this.cmbBlockID.TabIndex = 222;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 223;
            this.label3.Text = "Block ID";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Available",
            "Allocated"});
            this.cmbStatus.Location = new System.Drawing.Point(81, 124);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(187, 21);
            this.cmbStatus.TabIndex = 224;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 225;
            this.label1.Text = "Unit Status";
            // 
            // cmbSizeCode
            // 
            this.cmbSizeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSizeCode.FormattingEnabled = true;
            this.cmbSizeCode.Location = new System.Drawing.Point(81, 149);
            this.cmbSizeCode.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSizeCode.Name = "cmbSizeCode";
            this.cmbSizeCode.Size = new System.Drawing.Size(187, 21);
            this.cmbSizeCode.TabIndex = 226;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 227;
            this.label2.Text = "Size Code";
            // 
            // frmUnitListReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 181);
            this.Controls.Add(this.cmbSizeCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBlockID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProjectID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip2);
            this.Name = "frmUnitListReport";
            this.Text = "Units List Report";
            this.Load += new System.EventHandler(this.frmUnitListReport_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ComboBox cmbProjectID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBlockID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSizeCode;
        private System.Windows.Forms.Label label2;
    }
}