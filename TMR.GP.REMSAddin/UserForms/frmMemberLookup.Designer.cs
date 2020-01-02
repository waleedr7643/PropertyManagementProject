namespace TMR.GP.REMSAddin
{
    partial class frmMemberLookup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberLookup));
            this.lblValue = new System.Windows.Forms.Label();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblBlock = new System.Windows.Forms.Label();
            this.cmbBlock = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAllocated = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.SRNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembershipID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Block = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Booking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Allocated = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(18, 200);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(34, 13);
            this.lblValue.TabIndex = 6;
            this.lblValue.Text = "Value";
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(75, 196);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(193, 20);
            this.txtSearchValue.TabIndex = 7;
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "Membership ID",
            "Client ID",
            "Member Name",
            "Unit ID"});
            this.cmbSearchBy.Location = new System.Drawing.Point(76, 171);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(193, 21);
            this.cmbSearchBy.TabIndex = 8;
            // 
            // cmbProject
            // 
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(76, 70);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(193, 21);
            this.cmbProject.TabIndex = 9;
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(18, 74);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(40, 13);
            this.lblProject.TabIndex = 10;
            this.lblProject.Text = "Project";
            // 
            // lblBlock
            // 
            this.lblBlock.AutoSize = true;
            this.lblBlock.Location = new System.Drawing.Point(18, 98);
            this.lblBlock.Name = "lblBlock";
            this.lblBlock.Size = new System.Drawing.Size(34, 13);
            this.lblBlock.TabIndex = 12;
            this.lblBlock.Text = "Block";
            // 
            // cmbBlock
            // 
            this.cmbBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlock.FormattingEnabled = true;
            this.cmbBlock.Location = new System.Drawing.Point(76, 94);
            this.cmbBlock.Name = "cmbBlock";
            this.cmbBlock.Size = new System.Drawing.Size(193, 21);
            this.cmbBlock.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Search By";
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SRNo,
            this.MembershipID,
            this.Block,
            this.Booking,
            this.Plot,
            this.Plan,
            this.MemberName,
            this.ClientID,
            this.MobileNumber,
            this.ProjectID,
            this.BlockID,
            this.UnitID,
            this.Status,
            this.Allocated});
            this.dgList.Location = new System.Drawing.Point(12, 233);
            this.dgList.MultiSelect = false;
            this.dgList.Name = "dgList";
            this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgList.Size = new System.Drawing.Size(867, 281);
            this.dgList.TabIndex = 14;
            this.dgList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Allocated";
            // 
            // cmbAllocated
            // 
            this.cmbAllocated.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAllocated.FormattingEnabled = true;
            this.cmbAllocated.Items.AddRange(new object[] {
            "All",
            "Allocated",
            "Unallocated"});
            this.cmbAllocated.Location = new System.Drawing.Point(76, 119);
            this.cmbAllocated.Name = "cmbAllocated";
            this.cmbAllocated.Size = new System.Drawing.Size(193, 21);
            this.cmbAllocated.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 35;
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
            this.cmbStatus.Location = new System.Drawing.Point(77, 144);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(193, 21);
            this.cmbStatus.TabIndex = 34;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.toolStripButton2,
            this.tsbRefresh});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(891, 68);
            this.toolStrip2.TabIndex = 36;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbSave
            // 
            this.tsbSave.AutoSize = false;
            this.tsbSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(43, 57);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSelect_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(43, 57);
            this.toolStripButton2.Text = "Close";
            this.toolStripButton2.Click += new System.EventHandler(this.tsbClose_Click);
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
            this.tsbRefresh.Size = new System.Drawing.Size(55, 60);
            this.tsbRefresh.Text = "Close";
            this.tsbRefresh.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // SRNo
            // 
            this.SRNo.FillWeight = 83.75633F;
            this.SRNo.HeaderText = "Sr No.";
            this.SRNo.Name = "SRNo";
            // 
            // MembershipID
            // 
            this.MembershipID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MembershipID.FillWeight = 101.6244F;
            this.MembershipID.HeaderText = "Membership ID";
            this.MembershipID.Name = "MembershipID";
            this.MembershipID.ReadOnly = true;
            // 
            // Block
            // 
            this.Block.HeaderText = "Block";
            this.Block.Name = "Block";
            this.Block.ReadOnly = true;
            this.Block.Visible = false;
            // 
            // Booking
            // 
            this.Booking.HeaderText = "Booking Date";
            this.Booking.Name = "Booking";
            this.Booking.ReadOnly = true;
            this.Booking.Visible = false;
            // 
            // Plot
            // 
            this.Plot.HeaderText = "Plot";
            this.Plot.Name = "Plot";
            this.Plot.ReadOnly = true;
            this.Plot.Visible = false;
            // 
            // Plan
            // 
            this.Plan.FillWeight = 101.6244F;
            this.Plan.HeaderText = "Size Code";
            this.Plan.Name = "Plan";
            this.Plan.ReadOnly = true;
            // 
            // MemberName
            // 
            this.MemberName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MemberName.FillWeight = 101.6244F;
            this.MemberName.HeaderText = "Member Name";
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            // 
            // ClientID
            // 
            this.ClientID.FillWeight = 101.6244F;
            this.ClientID.HeaderText = "Client ID";
            this.ClientID.Name = "ClientID";
            this.ClientID.ReadOnly = true;
            // 
            // MobileNumber
            // 
            this.MobileNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MobileNumber.FillWeight = 101.6244F;
            this.MobileNumber.HeaderText = "Mobile No";
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.ReadOnly = true;
            // 
            // ProjectID
            // 
            this.ProjectID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectID.FillWeight = 101.6244F;
            this.ProjectID.HeaderText = "Project ID";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.ReadOnly = true;
            // 
            // BlockID
            // 
            this.BlockID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BlockID.FillWeight = 101.6244F;
            this.BlockID.HeaderText = "Sector/Floor";
            this.BlockID.Name = "BlockID";
            this.BlockID.ReadOnly = true;
            // 
            // UnitID
            // 
            this.UnitID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitID.FillWeight = 101.6244F;
            this.UnitID.HeaderText = "Unit ID";
            this.UnitID.Name = "UnitID";
            this.UnitID.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.FillWeight = 101.6244F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Allocated
            // 
            this.Allocated.FillWeight = 101.6244F;
            this.Allocated.HeaderText = "Allocated";
            this.Allocated.Name = "Allocated";
            this.Allocated.ReadOnly = true;
            this.Allocated.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Allocated.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmMemberLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 526);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAllocated);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBlock);
            this.Controls.Add(this.cmbBlock);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.cmbSearchBy);
            this.Controls.Add(this.txtSearchValue);
            this.Controls.Add(this.lblValue);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMemberLookup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membership Lookup";
            this.Load += new System.EventHandler(this.frmMemberLookup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblBlock;
        private System.Windows.Forms.ComboBox cmbBlock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAllocated;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembershipID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Block;
        private System.Windows.Forms.DataGridViewTextBoxColumn Booking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Allocated;
    }
}