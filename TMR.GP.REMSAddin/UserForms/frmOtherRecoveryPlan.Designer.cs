namespace TMR.GP.REMSAddin
{
    partial class frmOtherRecoveryPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtherRecoveryPlan));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.Rowid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallmentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecoveryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecoveryTypeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueAfterMonths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmbPlan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRecoveryType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDueAfterMonths = new System.Windows.Forms.TextBox();
            this.txtDueAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbClose,
            this.tsbClear});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(596, 60);
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
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rowid,
            this.SizeCode,
            this.InstallmentNo,
            this.RecoveryType,
            this.RecoveryTypeid,
            this.AmountDue,
            this.DueAfterMonths,
            this.Delete});
            this.dgList.Location = new System.Drawing.Point(12, 214);
            this.dgList.Name = "dgList";
            this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgList.Size = new System.Drawing.Size(574, 225);
            this.dgList.TabIndex = 51;
            this.dgList.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgList_CurrentCellDirtyStateChanged);
            // 
            // Rowid
            // 
            this.Rowid.HeaderText = "id";
            this.Rowid.Name = "Rowid";
            this.Rowid.ReadOnly = true;
            this.Rowid.Visible = false;
            // 
            // SizeCode
            // 
            this.SizeCode.HeaderText = "Plan";
            this.SizeCode.Name = "SizeCode";
            this.SizeCode.ReadOnly = true;
            // 
            // InstallmentNo
            // 
            this.InstallmentNo.HeaderText = "Installment No";
            this.InstallmentNo.Name = "InstallmentNo";
            this.InstallmentNo.ReadOnly = true;
            // 
            // RecoveryType
            // 
            this.RecoveryType.HeaderText = "Recovery Type";
            this.RecoveryType.Name = "RecoveryType";
            this.RecoveryType.ReadOnly = true;
            // 
            // RecoveryTypeid
            // 
            this.RecoveryTypeid.HeaderText = "RecoveryTypeid";
            this.RecoveryTypeid.Name = "RecoveryTypeid";
            this.RecoveryTypeid.ReadOnly = true;
            this.RecoveryTypeid.Visible = false;
            // 
            // AmountDue
            // 
            this.AmountDue.HeaderText = "Due Amount";
            this.AmountDue.Name = "AmountDue";
            this.AmountDue.ReadOnly = true;
            // 
            // DueAfterMonths
            // 
            this.DueAfterMonths.HeaderText = "Due After Months";
            this.DueAfterMonths.Name = "DueAfterMonths";
            this.DueAfterMonths.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::TMR.GP.REMSAddin.Properties.Resources.b_deltbl;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            // 
            // cmbPlan
            // 
            this.cmbPlan.FormattingEnabled = true;
            this.cmbPlan.Location = new System.Drawing.Point(114, 73);
            this.cmbPlan.Name = "cmbPlan";
            this.cmbPlan.Size = new System.Drawing.Size(185, 21);
            this.cmbPlan.TabIndex = 52;
            this.cmbPlan.SelectedIndexChanged += new System.EventHandler(this.cmbPlan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Plan";
            // 
            // cmbRecoveryType
            // 
            this.cmbRecoveryType.FormattingEnabled = true;
            this.cmbRecoveryType.Location = new System.Drawing.Point(114, 100);
            this.cmbRecoveryType.Name = "cmbRecoveryType";
            this.cmbRecoveryType.Size = new System.Drawing.Size(185, 21);
            this.cmbRecoveryType.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Recovery Type";
            // 
            // txtDueAfterMonths
            // 
            this.txtDueAfterMonths.Location = new System.Drawing.Point(114, 127);
            this.txtDueAfterMonths.Name = "txtDueAfterMonths";
            this.txtDueAfterMonths.Size = new System.Drawing.Size(185, 20);
            this.txtDueAfterMonths.TabIndex = 56;
            // 
            // txtDueAmount
            // 
            this.txtDueAmount.Location = new System.Drawing.Point(114, 153);
            this.txtDueAmount.Name = "txtDueAmount";
            this.txtDueAmount.Size = new System.Drawing.Size(185, 20);
            this.txtDueAmount.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Due After Months";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Due Amount";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(113, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 60;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(194, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 61;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Delete";
            this.dataGridViewImageColumn1.Image = global::TMR.GP.REMSAddin.Properties.Resources.b_deltbl;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 88;
            // 
            // frmOtherRecoveryPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 449);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDueAmount);
            this.Controls.Add(this.txtDueAfterMonths);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRecoveryType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPlan);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.toolStrip2);
            this.Name = "frmOtherRecoveryPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Other Recovery - Payment Plan";
            this.Load += new System.EventHandler(this.frmOtherRecoveryPlan_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn UnitNatureID;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ComboBox cmbPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRecoveryType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDueAfterMonths;
        private System.Windows.Forms.TextBox txtDueAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rowid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallmentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecoveryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecoveryTypeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueAfterMonths;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}