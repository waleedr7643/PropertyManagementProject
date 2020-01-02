namespace TMR.GP.REMSAddin
{
    partial class frmUnitRevaluation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnitRevaluation));
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBlock = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tsbApprove = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.SRNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rowid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OldPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbApprovalStatus = new System.Windows.Forms.ComboBox();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Block";
            // 
            // cmbBlock
            // 
            this.cmbBlock.FormattingEnabled = true;
            this.cmbBlock.Location = new System.Drawing.Point(109, 87);
            this.cmbBlock.Name = "cmbBlock";
            this.cmbBlock.Size = new System.Drawing.Size(170, 21);
            this.cmbBlock.TabIndex = 38;
            this.cmbBlock.SelectedIndexChanged += new System.EventHandler(this.cmbBlock_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Project";
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(109, 65);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(170, 21);
            this.cmbProject.TabIndex = 36;
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbClose,
            this.tsbApprove,
            this.tsbClear});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(485, 60);
            this.toolStrip2.TabIndex = 47;
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
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.AutoSize = false;
            this.tsbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(43, 57);
            this.tsbClose.Text = "Close";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tsbApprove
            // 
            this.tsbApprove.AutoSize = false;
            this.tsbApprove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbApprove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbApprove.Image = ((System.Drawing.Image)(resources.GetObject("tsbApprove.Image")));
            this.tsbApprove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbApprove.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsbApprove.Name = "tsbApprove";
            this.tsbApprove.Size = new System.Drawing.Size(48, 57);
            this.tsbApprove.Text = "Approve";
            this.tsbApprove.Click += new System.EventHandler(this.tsbApprove_Click);
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
            this.tsbClear.Size = new System.Drawing.Size(43, 57);
            this.tsbClear.Text = "Clear";
            this.tsbClear.Click += new System.EventHandler(this.tsbClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(109, 111);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(170, 20);
            this.dtpDate.TabIndex = 53;
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SRNo,
            this.Rowid,
            this.BlockID,
            this.SizeCode,
            this.OldPrice,
            this.NewPrice});
            this.dgList.Location = new System.Drawing.Point(25, 175);
            this.dgList.Name = "dgList";
            this.dgList.Size = new System.Drawing.Size(444, 261);
            this.dgList.TabIndex = 51;
            this.dgList.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgList_CurrentCellDirtyStateChanged);
            // 
            // SRNo
            // 
            this.SRNo.HeaderText = "Sr. No.";
            this.SRNo.Name = "SRNo";
            this.SRNo.Width = 65;
            // 
            // Rowid
            // 
            this.Rowid.HeaderText = "id";
            this.Rowid.Name = "Rowid";
            this.Rowid.ReadOnly = true;
            this.Rowid.Visible = false;
            // 
            // BlockID
            // 
            this.BlockID.HeaderText = "Block ID";
            this.BlockID.Name = "BlockID";
            this.BlockID.ReadOnly = true;
            // 
            // SizeCode
            // 
            this.SizeCode.HeaderText = "Size Code";
            this.SizeCode.Name = "SizeCode";
            this.SizeCode.ReadOnly = true;
            // 
            // OldPrice
            // 
            this.OldPrice.HeaderText = "Old Price";
            this.OldPrice.Name = "OldPrice";
            this.OldPrice.ReadOnly = true;
            // 
            // NewPrice
            // 
            this.NewPrice.HeaderText = "New Price";
            this.NewPrice.Name = "NewPrice";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 140);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 221;
            this.label8.Text = "Approval Status";
            // 
            // cmbApprovalStatus
            // 
            this.cmbApprovalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApprovalStatus.Enabled = false;
            this.cmbApprovalStatus.FormattingEnabled = true;
            this.cmbApprovalStatus.Items.AddRange(new object[] {
            "Not Saved",
            "Pending",
            "Approved",
            "Rejected"});
            this.cmbApprovalStatus.Location = new System.Drawing.Point(109, 137);
            this.cmbApprovalStatus.Name = "cmbApprovalStatus";
            this.cmbApprovalStatus.Size = new System.Drawing.Size(170, 21);
            this.cmbApprovalStatus.TabIndex = 222;
            // 
            // frmUnitRevaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 448);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbApprovalStatus);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBlock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProject);
            this.Name = "frmUnitRevaluation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Units Revaluation";
            this.Load += new System.EventHandler(this.frmUnitRevaluation_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBlock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitNatureID;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.ToolStripButton tsbApprove;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbApprovalStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rowid;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OldPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewPrice;
    }
}