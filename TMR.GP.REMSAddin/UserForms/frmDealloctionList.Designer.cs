namespace TMR.GP.REMSAddin
{
    partial class frmDealloctionList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDealloctionList));
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.RegistrationNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeAllocationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Approve = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReactivate = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.chkBoxApproved = new System.Windows.Forms.CheckBox();
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
            this.toolStrip1.TabIndex = 192;
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
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.AllowUserToResizeColumns = false;
            this.dgList.AllowUserToResizeRows = false;
            this.dgList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistrationNo,
            this.ClientID,
            this.DeAllocationDate,
            this.Approve,
            this.Remarks,
            this.id});
            this.dgList.Location = new System.Drawing.Point(12, 99);
            this.dgList.Name = "dgList";
            this.dgList.Size = new System.Drawing.Size(628, 272);
            this.dgList.TabIndex = 194;
            // 
            // RegistrationNo
            // 
            this.RegistrationNo.HeaderText = "RegistrationNo";
            this.RegistrationNo.Name = "RegistrationNo";
            this.RegistrationNo.ReadOnly = true;
            // 
            // ClientID
            // 
            this.ClientID.HeaderText = "ClientID";
            this.ClientID.Name = "ClientID";
            this.ClientID.ReadOnly = true;
            // 
            // DeAllocationDate
            // 
            this.DeAllocationDate.HeaderText = "DeallocationDate";
            this.DeAllocationDate.Name = "DeAllocationDate";
            this.DeAllocationDate.ReadOnly = true;
            // 
            // Approve
            // 
            this.Approve.HeaderText = "Approve";
            this.Approve.Name = "Approve";
            this.Approve.ReadOnly = true;
            this.Approve.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Approve.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(385, 65);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 27);
            this.btnSearch.TabIndex = 193;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(266, 437);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.MaximumSize = new System.Drawing.Size(71, 24);
            this.btnCancel.MinimumSize = new System.Drawing.Size(71, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 24);
            this.btnCancel.TabIndex = 191;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            // 
            // btnReactivate
            // 
            this.btnReactivate.Location = new System.Drawing.Point(223, 383);
            this.btnReactivate.Margin = new System.Windows.Forms.Padding(2);
            this.btnReactivate.Name = "btnReactivate";
            this.btnReactivate.Size = new System.Drawing.Size(170, 41);
            this.btnReactivate.TabIndex = 190;
            this.btnReactivate.Text = "Reactivate";
            this.btnReactivate.UseVisualStyleBackColor = true;
            this.btnReactivate.Visible = false;
            // 
            // txtStatus
            // 
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "Approved",
            "Unapproved"});
            this.txtStatus.Location = new System.Drawing.Point(200, 69);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(166, 21);
            this.txtStatus.TabIndex = 196;
            this.txtStatus.Visible = false;
            // 
            // chkBoxApproved
            // 
            this.chkBoxApproved.AutoSize = true;
            this.chkBoxApproved.Location = new System.Drawing.Point(428, 396);
            this.chkBoxApproved.Name = "chkBoxApproved";
            this.chkBoxApproved.Size = new System.Drawing.Size(72, 17);
            this.chkBoxApproved.TabIndex = 195;
            this.chkBoxApproved.Text = "Approved";
            this.chkBoxApproved.UseVisualStyleBackColor = true;
            this.chkBoxApproved.Visible = false;
            // 
            // frmDealloctionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 466);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReactivate);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.chkBoxApproved);
            this.Name = "frmDealloctionList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dealloction List";
            this.Load += new System.EventHandler(this.frmDealloctionList_Load);
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
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReactivate;
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.CheckBox chkBoxApproved;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeAllocationDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Approve;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}