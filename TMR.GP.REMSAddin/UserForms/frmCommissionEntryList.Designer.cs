namespace TMR.GP.REMSAddin
{
    partial class frmCommissionEntryList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommissionEntryList));
            this.dgList = new System.Windows.Forms.DataGridView();
            this.SRNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbLoad = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.EndDate = new System.Windows.Forms.Label();
            this.dTPEndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dTPStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
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
            this.RegistrationNo,
            this.ClientID,
            this.ClientName,
            this.EntryNumber,
            this.ReceiptAmount,
            this.ReceiptDate,
            this.Remarks,
            this.id});
            this.dgList.Location = new System.Drawing.Point(9, 212);
            this.dgList.MultiSelect = false;
            this.dgList.Name = "dgList";
            this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgList.Size = new System.Drawing.Size(843, 345);
            this.dgList.TabIndex = 221;
            this.dgList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgList_CellContentClick);
            // 
            // SRNo
            // 
            this.SRNo.HeaderText = "Sr. No";
            this.SRNo.Name = "SRNo";
            this.SRNo.Width = 65;
            // 
            // RegistrationNo
            // 
            this.RegistrationNo.HeaderText = "Reg #";
            this.RegistrationNo.Name = "RegistrationNo";
            this.RegistrationNo.ReadOnly = true;
            this.RegistrationNo.Width = 65;
            // 
            // ClientID
            // 
            this.ClientID.HeaderText = "Client ID";
            this.ClientID.Name = "ClientID";
            this.ClientID.ReadOnly = true;
            this.ClientID.Width = 105;
            // 
            // ClientName
            // 
            this.ClientName.HeaderText = "Name";
            this.ClientName.Name = "ClientName";
            // 
            // EntryNumber
            // 
            this.EntryNumber.HeaderText = "Entry #";
            this.EntryNumber.Name = "EntryNumber";
            // 
            // ReceiptAmount
            // 
            this.ReceiptAmount.HeaderText = "Amount";
            this.ReceiptAmount.Name = "ReceiptAmount";
            // 
            // ReceiptDate
            // 
            this.ReceiptDate.HeaderText = "Date";
            this.ReceiptDate.Name = "ReceiptDate";
            this.ReceiptDate.ReadOnly = true;
            this.ReceiptDate.Width = 120;
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            this.Remarks.Width = 250;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClear,
            this.tsbCancel,
            this.tsbLoad,
            this.tsbRefresh});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(860, 71);
            this.toolStrip2.TabIndex = 222;
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
            this.tsbCancel.Click += new System.EventHandler(this.tsbClose_Click);
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
            this.tsbLoad.Click += new System.EventHandler(this.tsbtnLoad_Click);
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
            // EndDate
            // 
            this.EndDate.AutoSize = true;
            this.EndDate.Location = new System.Drawing.Point(26, 193);
            this.EndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(52, 13);
            this.EndDate.TabIndex = 246;
            this.EndDate.Text = "End Date";
            // 
            // dTPEndDate
            // 
            this.dTPEndDate.CustomFormat = "dd/MM/yyy";
            this.dTPEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPEndDate.Location = new System.Drawing.Point(112, 187);
            this.dTPEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dTPEndDate.Name = "dTPEndDate";
            this.dTPEndDate.Size = new System.Drawing.Size(172, 20);
            this.dTPEndDate.TabIndex = 245;
            this.dTPEndDate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 244;
            this.label5.Text = "Start Date";
            // 
            // dTPStartDate
            // 
            this.dTPStartDate.CustomFormat = "dd/MM/yyy";
            this.dTPStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPStartDate.Location = new System.Drawing.Point(112, 163);
            this.dTPStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dTPStartDate.Name = "dTPStartDate";
            this.dTPStartDate.Size = new System.Drawing.Size(172, 20);
            this.dTPStartDate.TabIndex = 243;
            this.dTPStartDate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 240;
            this.label4.Text = "Search By";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(26, 87);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(40, 13);
            this.lblProject.TabIndex = 239;
            this.lblProject.Text = "Project";
            // 
            // cmbProject
            // 
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(112, 88);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(172, 21);
            this.cmbProject.TabIndex = 238;
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "Membership ID",
            "Client ID",
            "Entry Number"});
            this.cmbSearchBy.Location = new System.Drawing.Point(112, 113);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(172, 21);
            this.cmbSearchBy.TabIndex = 237;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(112, 138);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(172, 20);
            this.txtSearchValue.TabIndex = 236;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(26, 141);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(34, 13);
            this.lblValue.TabIndex = 235;
            this.lblValue.Text = "Value";
            // 
            // frmCommissionEntryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 566);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.dTPEndDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dTPStartDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.cmbSearchBy);
            this.Controls.Add(this.txtSearchValue);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dgList);
            this.Name = "frmCommissionEntryList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commission Entry List";
            this.Load += new System.EventHandler(this.frmReceiptsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripButton tsbLoad;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.Label EndDate;
        private System.Windows.Forms.DateTimePicker dTPEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTPStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewButtonColumn id;
    }
}