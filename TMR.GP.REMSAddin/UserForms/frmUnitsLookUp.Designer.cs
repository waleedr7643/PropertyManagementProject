namespace TMR.GP.REMSAddin
{
    partial class frmUnitsLookUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnitsLookUp));
            this.dgList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBlock = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSizeCode = new System.Windows.Forms.ComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.txtSearchby = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SRNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreetNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlotNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
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
            this.Status,
            this.UnitID,
            this.StreetNo,
            this.PlotNo,
            this.SizeCode,
            this.Price,
            this.Area,
            this.UnitTypeID,
            this.UnitCategoryID});
            this.dgList.Location = new System.Drawing.Point(12, 181);
            this.dgList.MultiSelect = false;
            this.dgList.Name = "dgList";
            this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgList.Size = new System.Drawing.Size(858, 351);
            this.dgList.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Block";
            // 
            // cmbBlock
            // 
            this.cmbBlock.Enabled = false;
            this.cmbBlock.FormattingEnabled = true;
            this.cmbBlock.Location = new System.Drawing.Point(74, 85);
            this.cmbBlock.Name = "cmbBlock";
            this.cmbBlock.Size = new System.Drawing.Size(188, 21);
            this.cmbBlock.TabIndex = 38;
            this.cmbBlock.SelectedIndexChanged += new System.EventHandler(this.cmbBlock_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Project";
            // 
            // cmbProject
            // 
            this.cmbProject.Enabled = false;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(74, 63);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(188, 21);
            this.cmbProject.TabIndex = 36;
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Size Code";
            // 
            // cmbSizeCode
            // 
            this.cmbSizeCode.Enabled = false;
            this.cmbSizeCode.FormattingEnabled = true;
            this.cmbSizeCode.Location = new System.Drawing.Point(74, 107);
            this.cmbSizeCode.Name = "cmbSizeCode";
            this.cmbSizeCode.Size = new System.Drawing.Size(188, 21);
            this.cmbSizeCode.TabIndex = 45;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbClose,
            this.tsbRefresh});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(882, 60);
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
            this.tsbSave.Click += new System.EventHandler(this.tsbSelect_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Search by";
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "Plot",
            "Street"});
            this.cmbSearchBy.Location = new System.Drawing.Point(74, 129);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(188, 21);
            this.cmbSearchBy.TabIndex = 48;
            // 
            // txtSearchby
            // 
            this.txtSearchby.Location = new System.Drawing.Point(74, 151);
            this.txtSearchby.Name = "txtSearchby";
            this.txtSearchby.Size = new System.Drawing.Size(188, 20);
            this.txtSearchby.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Value";
            // 
            // SRNo
            // 
            this.SRNo.FillWeight = 76.14214F;
            this.SRNo.HeaderText = "Sr. No.";
            this.SRNo.Name = "SRNo";
            // 
            // Status
            // 
            this.Status.FillWeight = 102.6509F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // UnitID
            // 
            this.UnitID.FillWeight = 102.6509F;
            this.UnitID.HeaderText = "Unit";
            this.UnitID.Name = "UnitID";
            this.UnitID.ReadOnly = true;
            // 
            // StreetNo
            // 
            this.StreetNo.FillWeight = 102.6509F;
            this.StreetNo.HeaderText = "Street";
            this.StreetNo.Name = "StreetNo";
            this.StreetNo.ReadOnly = true;
            // 
            // PlotNo
            // 
            this.PlotNo.FillWeight = 102.6509F;
            this.PlotNo.HeaderText = "Plot";
            this.PlotNo.Name = "PlotNo";
            this.PlotNo.ReadOnly = true;
            // 
            // SizeCode
            // 
            this.SizeCode.FillWeight = 102.6509F;
            this.SizeCode.HeaderText = "Size Code";
            this.SizeCode.Name = "SizeCode";
            this.SizeCode.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.FillWeight = 102.6509F;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Area
            // 
            this.Area.FillWeight = 102.6509F;
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // UnitTypeID
            // 
            this.UnitTypeID.FillWeight = 102.6509F;
            this.UnitTypeID.HeaderText = "Type";
            this.UnitTypeID.Name = "UnitTypeID";
            this.UnitTypeID.ReadOnly = true;
            // 
            // UnitCategoryID
            // 
            this.UnitCategoryID.FillWeight = 102.6509F;
            this.UnitCategoryID.HeaderText = "Category";
            this.UnitCategoryID.Name = "UnitCategoryID";
            this.UnitCategoryID.ReadOnly = true;
            // 
            // frmUnitsLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 538);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearchby);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSearchBy);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSizeCode);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBlock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProject);
            this.Name = "frmUnitsLookUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Units Lookup";
            this.Load += new System.EventHandler(this.frmUnitsLookUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBlock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSizeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitNatureID;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.TextBox txtSearchby;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlotNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCategoryID;
    }
}