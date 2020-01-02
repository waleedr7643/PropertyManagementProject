namespace TMR.GP.REMSAddin.UserForms
{
    partial class frmRecoveryDueReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecoveryDueReport));
            this.cmbBlock = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dTPFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dTPToDate = new System.Windows.Forms.DateTimePicker();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbLoad = new System.Windows.Forms.ToolStripButton();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBlock
            // 
            this.cmbBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlock.Enabled = false;
            this.cmbBlock.FormattingEnabled = true;
            this.cmbBlock.Location = new System.Drawing.Point(78, 92);
            this.cmbBlock.Name = "cmbBlock";
            this.cmbBlock.Size = new System.Drawing.Size(174, 21);
            this.cmbBlock.TabIndex = 272;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 271;
            this.label3.Text = "Block";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(18, 73);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(40, 13);
            this.lblProject.TabIndex = 270;
            this.lblProject.Text = "Project";
            // 
            // cmbProject
            // 
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(78, 70);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(174, 21);
            this.cmbProject.TabIndex = 269;
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 278;
            this.label1.Text = "From Date";
            this.label1.Visible = false;
            // 
            // dTPFromDate
            // 
            this.dTPFromDate.CustomFormat = "dd/MM/yyy";
            this.dTPFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPFromDate.Location = new System.Drawing.Point(78, 140);
            this.dTPFromDate.Margin = new System.Windows.Forms.Padding(2);
            this.dTPFromDate.Name = "dTPFromDate";
            this.dTPFromDate.Size = new System.Drawing.Size(174, 20);
            this.dTPFromDate.TabIndex = 277;
            this.dTPFromDate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dTPFromDate.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 280;
            this.label2.Text = "To Date";
            this.label2.Visible = false;
            // 
            // dTPToDate
            // 
            this.dTPToDate.CustomFormat = "dd/MM/yyy";
            this.dTPToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPToDate.Location = new System.Drawing.Point(78, 161);
            this.dTPToDate.Margin = new System.Windows.Forms.Padding(2);
            this.dTPToDate.Name = "dTPToDate";
            this.dTPToDate.Size = new System.Drawing.Size(174, 20);
            this.dTPToDate.TabIndex = 279;
            this.dTPToDate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dTPToDate.Visible = false;
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
            this.toolStrip2.Size = new System.Drawing.Size(270, 64);
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
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cmbYear.Location = new System.Drawing.Point(78, 115);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(174, 21);
            this.cmbYear.TabIndex = 296;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 295;
            this.label4.Text = "Year";
            // 
            // frmRecoveryDueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 191);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dTPToDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dTPFromDate);
            this.Controls.Add(this.cmbBlock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.cmbProject);
            this.Name = "frmRecoveryDueReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recovery Due Report";
            this.Load += new System.EventHandler(this.frmSoldPlotsReport_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBlock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTPFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTPToDate;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripButton tsbLoad;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label4;
    }
}