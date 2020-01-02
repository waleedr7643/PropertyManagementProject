namespace TMR.GP.REMSAddin
{
    partial class frmReactivationss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReactivationss));
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReactivate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.Selection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancellationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Approve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkBoxApproved = new System.Windows.Forms.CheckBox();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.SuspendLayout();
            // 
            // tsbClear
            // 
            this.tsbClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClear.Image = ((System.Drawing.Image)(resources.GetObject("tsbClear.Image")));
            this.tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClear.Name = "tsbClear";
            this.tsbClear.Size = new System.Drawing.Size(38, 22);
            this.tsbClear.Text = "Clear";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClear,
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(649, 25);
            this.toolStrip1.TabIndex = 175;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(40, 22);
            this.tsbClose.Text = "Close";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(266, 420);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.MaximumSize = new System.Drawing.Size(71, 24);
            this.btnCancel.MinimumSize = new System.Drawing.Size(71, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 24);
            this.btnCancel.TabIndex = 160;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnReactivate
            // 
            this.btnReactivate.Location = new System.Drawing.Point(223, 366);
            this.btnReactivate.Margin = new System.Windows.Forms.Padding(2);
            this.btnReactivate.Name = "btnReactivate";
            this.btnReactivate.Size = new System.Drawing.Size(170, 41);
            this.btnReactivate.TabIndex = 159;
            this.btnReactivate.Text = "Reactivate";
            this.btnReactivate.UseVisualStyleBackColor = true;
            this.btnReactivate.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(385, 48);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 27);
            this.btnSearch.TabIndex = 177;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgList
            // 
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selection,
            this.id,
            this.RegistrationNo,
            this.ClientID,
            this.CancellationDate,
            this.Approve,
            this.Remarks});
            this.dgList.Location = new System.Drawing.Point(12, 82);
            this.dgList.Name = "dgList";
            this.dgList.Size = new System.Drawing.Size(628, 272);
            this.dgList.TabIndex = 178;
            // 
            // Selection
            // 
            this.Selection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Selection.Frozen = true;
            this.Selection.HeaderText = "Selection";
            this.Selection.Name = "Selection";
            this.Selection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Selection.Width = 98;
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "CancellationID";
            this.id.Name = "id";
            this.id.Width = 101;
            // 
            // RegistrationNo
            // 
            this.RegistrationNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RegistrationNo.Frozen = true;
            this.RegistrationNo.HeaderText = "Reg No";
            this.RegistrationNo.Name = "RegistrationNo";
            this.RegistrationNo.Width = 97;
            // 
            // ClientID
            // 
            this.ClientID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClientID.Frozen = true;
            this.ClientID.HeaderText = "Client ID";
            this.ClientID.Name = "ClientID";
            this.ClientID.Width = 98;
            // 
            // CancellationDate
            // 
            this.CancellationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CancellationDate.Frozen = true;
            this.CancellationDate.HeaderText = "Cancellation Date";
            this.CancellationDate.Name = "CancellationDate";
            this.CancellationDate.Width = 97;
            // 
            // Approve
            // 
            this.Approve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Approve.Frozen = true;
            this.Approve.HeaderText = "Approval";
            this.Approve.Name = "Approve";
            this.Approve.Width = 98;
            // 
            // Remarks
            // 
            this.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Remarks.Frozen = true;
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.Width = 97;
            // 
            // chkBoxApproved
            // 
            this.chkBoxApproved.AutoSize = true;
            this.chkBoxApproved.Location = new System.Drawing.Point(428, 379);
            this.chkBoxApproved.Name = "chkBoxApproved";
            this.chkBoxApproved.Size = new System.Drawing.Size(72, 17);
            this.chkBoxApproved.TabIndex = 181;
            this.chkBoxApproved.Text = "Approved";
            this.chkBoxApproved.UseVisualStyleBackColor = true;
            // 
            // txtStatus
            // 
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "Approved",
            "Unapproved"});
            this.txtStatus.Location = new System.Drawing.Point(200, 52);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(166, 21);
            this.txtStatus.TabIndex = 182;
            this.txtStatus.SelectedIndexChanged += new System.EventHandler(this.txtStatus_SelectedIndexChanged);
            // 
            // frmReactivationss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 466);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.chkBoxApproved);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReactivate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReactivationss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reactivation";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReactivate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.CheckBox chkBoxApproved;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CancellationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Approve;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.ComboBox txtStatus;
    }
}