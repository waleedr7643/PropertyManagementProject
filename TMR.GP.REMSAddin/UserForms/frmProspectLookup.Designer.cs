namespace TMR.GP.REMSAddin.UserForms
{
    partial class frmProspectLookup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProspectLookup));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbLoad = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.EndDate = new System.Windows.Forms.Label();
            this.dTPEndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dTPStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblProject = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.SRNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProspectStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProspectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProspectFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProspectPaymentPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClear,
            this.tsbCancel,
            this.tsbLoad,
            this.tsbRefresh,
            this.toolStripButton1,
            this.tsbSave});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(968, 71);
            this.toolStrip2.TabIndex = 223;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbClear
            // 
            this.tsbClear.AutoSize = false;
            this.tsbClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClear.Image = ((System.Drawing.Image)(resources.GetObject("tsbClear.Image")));
            this.tsbClear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbClear.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsbClear.Name = "tsbClear";
            this.tsbClear.Size = new System.Drawing.Size(43, 60);
            this.tsbClear.Text = "Clear";
            this.tsbClear.Visible = false;
            this.tsbClear.Click += new System.EventHandler(this.tsbClear_Click);
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
            this.tsbLoad.Visible = false;
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.AutoSize = false;
            this.tsbRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(55, 65);
            this.tsbRefresh.Text = "Refresh";
            this.tsbRefresh.ToolTipText = "Refresh";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(43, 57);
            this.toolStripButton1.Text = "Save";
            this.toolStripButton1.Click += new System.EventHandler(this.tsbSelect_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.AutoSize = false;
            this.tsbSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(43, 57);
            this.tsbSave.Text = "Select";
            // 
            // EndDate
            // 
            this.EndDate.AutoSize = true;
            this.EndDate.Location = new System.Drawing.Point(10, 135);
            this.EndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(52, 13);
            this.EndDate.TabIndex = 258;
            this.EndDate.Text = "End Date";
            // 
            // dTPEndDate
            // 
            this.dTPEndDate.CustomFormat = "dd/MM/yyy";
            this.dTPEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPEndDate.Location = new System.Drawing.Point(100, 132);
            this.dTPEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dTPEndDate.Name = "dTPEndDate";
            this.dTPEndDate.Size = new System.Drawing.Size(154, 20);
            this.dTPEndDate.TabIndex = 2;
            this.dTPEndDate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 256;
            this.label5.Text = "Start Date";
            // 
            // dTPStartDate
            // 
            this.dTPStartDate.CustomFormat = "dd/MM/yyy";
            this.dTPStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPStartDate.Location = new System.Drawing.Point(100, 107);
            this.dTPStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dTPStartDate.Name = "dTPStartDate";
            this.dTPStartDate.Size = new System.Drawing.Size(154, 20);
            this.dTPStartDate.TabIndex = 1;
            this.dTPStartDate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(10, 80);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(40, 13);
            this.lblProject.TabIndex = 251;
            this.lblProject.Text = "Project";
            // 
            // cmbProject
            // 
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(100, 81);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(154, 21);
            this.cmbProject.TabIndex = 0;
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.AllowUserToResizeColumns = false;
            this.dgList.AllowUserToResizeRows = false;
            this.dgList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SRNo,
            this.ProjectNo,
            this.Sector,
            this.ProspectStartDate,
            this.UPlot,
            this.ProspectName,
            this.ProspectFatherName,
            this.CNIC,
            this.ContactNo,
            this.ProspectPaymentPlan,
            this.SizeCode,
            this.id});
            this.dgList.Location = new System.Drawing.Point(12, 165);
            this.dgList.MultiSelect = false;
            this.dgList.Name = "dgList";
            this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgList.Size = new System.Drawing.Size(944, 327);
            this.dgList.TabIndex = 3;
            // 
            // SRNo
            // 
            this.SRNo.HeaderText = "Sr No.";
            this.SRNo.Name = "SRNo";
            this.SRNo.Width = 65;
            // 
            // ProjectNo
            // 
            this.ProjectNo.FillWeight = 150F;
            this.ProjectNo.HeaderText = "Project No";
            this.ProjectNo.Name = "ProjectNo";
            this.ProjectNo.ReadOnly = true;
            // 
            // Sector
            // 
            this.Sector.HeaderText = "Sector";
            this.Sector.Name = "Sector";
            this.Sector.ReadOnly = true;
            this.Sector.Width = 105;
            // 
            // ProspectStartDate
            // 
            this.ProspectStartDate.HeaderText = "Date";
            this.ProspectStartDate.Name = "ProspectStartDate";
            this.ProspectStartDate.ReadOnly = true;
            this.ProspectStartDate.Width = 120;
            // 
            // UPlot
            // 
            this.UPlot.HeaderText = "Plot";
            this.UPlot.Name = "UPlot";
            this.UPlot.ReadOnly = true;
            this.UPlot.Width = 80;
            // 
            // ProspectName
            // 
            this.ProspectName.HeaderText = "Name";
            this.ProspectName.Name = "ProspectName";
            this.ProspectName.Width = 120;
            // 
            // ProspectFatherName
            // 
            this.ProspectFatherName.HeaderText = "Father Name";
            this.ProspectFatherName.Name = "ProspectFatherName";
            this.ProspectFatherName.Width = 150;
            // 
            // CNIC
            // 
            this.CNIC.HeaderText = "CNIC";
            this.CNIC.Name = "CNIC";
            // 
            // ContactNo
            // 
            this.ContactNo.HeaderText = "Contact No";
            this.ContactNo.Name = "ContactNo";
            // 
            // ProspectPaymentPlan
            // 
            this.ProspectPaymentPlan.HeaderText = "Payment Plan";
            this.ProspectPaymentPlan.Name = "ProspectPaymentPlan";
            this.ProspectPaymentPlan.Width = 150;
            // 
            // SizeCode
            // 
            this.SizeCode.HeaderText = "Size Code";
            this.SizeCode.Name = "SizeCode";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // frmProspectLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 504);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.dTPEndDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dTPStartDate);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.toolStrip2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProspectLookup";
            this.Text = "Prospect Lookup";
            this.Load += new System.EventHandler(this.frmProspectLookup_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripButton tsbLoad;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.Label EndDate;
        private System.Windows.Forms.DateTimePicker dTPEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTPStartDate;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sector;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProspectStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProspectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProspectFatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProspectPaymentPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeCode;
        private System.Windows.Forms.DataGridViewButtonColumn id;
    }
}