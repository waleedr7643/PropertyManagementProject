namespace TMR.GP.REMSAddin.UserForms
{
    partial class frmInstallmentPlanSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstallmentPlanSetup));
            this.txtPlanCode = new System.Windows.Forms.TextBox();
            this.txtPlanName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkInactive = new System.Windows.Forms.CheckBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Clear = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Cancel = new System.Windows.Forms.ToolStripButton();
            this.btnLookup = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDueAmount = new System.Windows.Forms.TextBox();
            this.txtDueAfterMonths = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbRecoveryType = new System.Windows.Forms.ComboBox();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.SRNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rowid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallmentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecoveryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecoveryTypeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueAfterMonths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtInstallmentAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartAfterBooking = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbFrequency = new System.Windows.Forms.ComboBox();
            this.txtInstallments = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSizeCode = new System.Windows.Forms.ComboBox();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPlanCode
            // 
            this.txtPlanCode.Location = new System.Drawing.Point(240, 67);
            this.txtPlanCode.Name = "txtPlanCode";
            this.txtPlanCode.Size = new System.Drawing.Size(201, 20);
            this.txtPlanCode.TabIndex = 142;
            // 
            // txtPlanName
            // 
            this.txtPlanName.Location = new System.Drawing.Point(240, 91);
            this.txtPlanName.Name = "txtPlanName";
            this.txtPlanName.Size = new System.Drawing.Size(201, 20);
            this.txtPlanName.TabIndex = 143;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 144;
            this.label1.Text = "Installment Plan Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 145;
            this.label2.Text = "Installment Plan Name";
            // 
            // chkInactive
            // 
            this.chkInactive.AutoSize = true;
            this.chkInactive.Location = new System.Drawing.Point(491, 69);
            this.chkInactive.Name = "chkInactive";
            this.chkInactive.Size = new System.Drawing.Size(64, 17);
            this.chkInactive.TabIndex = 146;
            this.chkInactive.Text = "Inactive";
            this.chkInactive.UseVisualStyleBackColor = true;
            this.chkInactive.Visible = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbtn_Clear,
            this.tsbtn_Cancel});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(607, 60);
            this.toolStrip2.TabIndex = 154;
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
            // tsbtn_Clear
            // 
            this.tsbtn_Clear.AutoSize = false;
            this.tsbtn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbtn_Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Clear.Image")));
            this.tsbtn_Clear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_Clear.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsbtn_Clear.Name = "tsbtn_Clear";
            this.tsbtn_Clear.Size = new System.Drawing.Size(43, 57);
            this.tsbtn_Clear.Text = "Clear";
            this.tsbtn_Clear.Click += new System.EventHandler(this.tsbtn_Clear_Click);
            // 
            // tsbtn_Cancel
            // 
            this.tsbtn_Cancel.AutoSize = false;
            this.tsbtn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbtn_Cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Cancel.Image")));
            this.tsbtn_Cancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_Cancel.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsbtn_Cancel.Name = "tsbtn_Cancel";
            this.tsbtn_Cancel.Size = new System.Drawing.Size(43, 57);
            this.tsbtn_Cancel.Text = "Close";
            // 
            // btnLookup
            // 
            this.btnLookup.Location = new System.Drawing.Point(448, 67);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(28, 19);
            this.btnLookup.TabIndex = 155;
            this.btnLookup.Text = "...";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDueAmount);
            this.groupBox1.Controls.Add(this.txtDueAfterMonths);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbRecoveryType);
            this.groupBox1.Controls.Add(this.dgList);
            this.groupBox1.Location = new System.Drawing.Point(20, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 371);
            this.groupBox1.TabIndex = 165;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Other RecoveryTypes";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(299, 88);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 182;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(218, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 181;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 180;
            this.label5.Text = "Due Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 179;
            this.label7.Text = "Due After Months";
            // 
            // txtDueAmount
            // 
            this.txtDueAmount.Location = new System.Drawing.Point(219, 63);
            this.txtDueAmount.Name = "txtDueAmount";
            this.txtDueAmount.Size = new System.Drawing.Size(202, 20);
            this.txtDueAmount.TabIndex = 178;
            // 
            // txtDueAfterMonths
            // 
            this.txtDueAfterMonths.Location = new System.Drawing.Point(219, 39);
            this.txtDueAfterMonths.Name = "txtDueAfterMonths";
            this.txtDueAfterMonths.Size = new System.Drawing.Size(202, 20);
            this.txtDueAfterMonths.TabIndex = 177;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 176;
            this.label8.Text = "Recovery Type";
            // 
            // cmbRecoveryType
            // 
            this.cmbRecoveryType.FormattingEnabled = true;
            this.cmbRecoveryType.Location = new System.Drawing.Point(219, 16);
            this.cmbRecoveryType.Name = "cmbRecoveryType";
            this.cmbRecoveryType.Size = new System.Drawing.Size(202, 21);
            this.cmbRecoveryType.TabIndex = 175;
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
            this.SRNo,
            this.Rowid,
            this.SizeCode,
            this.InstallmentNo,
            this.RecoveryType,
            this.RecoveryTypeid,
            this.AmountDue,
            this.DueAfterMonths,
            this.Delete});
            this.dgList.Location = new System.Drawing.Point(10, 117);
            this.dgList.Name = "dgList";
            this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgList.Size = new System.Drawing.Size(561, 248);
            this.dgList.TabIndex = 174;
            // 
            // SRNo
            // 
            this.SRNo.FillWeight = 88.83249F;
            this.SRNo.HeaderText = "Sr No.";
            this.SRNo.Name = "SRNo";
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
            this.SizeCode.FillWeight = 101.8613F;
            this.SizeCode.HeaderText = "Plan";
            this.SizeCode.Name = "SizeCode";
            this.SizeCode.ReadOnly = true;
            // 
            // InstallmentNo
            // 
            this.InstallmentNo.FillWeight = 101.8613F;
            this.InstallmentNo.HeaderText = "Installment No";
            this.InstallmentNo.Name = "InstallmentNo";
            this.InstallmentNo.ReadOnly = true;
            // 
            // RecoveryType
            // 
            this.RecoveryType.FillWeight = 101.8613F;
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
            this.AmountDue.FillWeight = 101.8613F;
            this.AmountDue.HeaderText = "Due Amount";
            this.AmountDue.Name = "AmountDue";
            this.AmountDue.ReadOnly = true;
            // 
            // DueAfterMonths
            // 
            this.DueAfterMonths.FillWeight = 101.8613F;
            this.DueAfterMonths.HeaderText = "Due After Months";
            this.DueAfterMonths.Name = "DueAfterMonths";
            this.DueAfterMonths.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 101.8613F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::TMR.GP.REMSAddin.Properties.Resources.b_deltbl;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtInstallmentAmount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtStartAfterBooking);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.cmbFrequency);
            this.groupBox2.Controls.Add(this.txtInstallments);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(22, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 111);
            this.groupBox2.TabIndex = 166;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Periodic Installments";
            // 
            // txtInstallmentAmount
            // 
            this.txtInstallmentAmount.Location = new System.Drawing.Point(217, 81);
            this.txtInstallmentAmount.Name = "txtInstallmentAmount";
            this.txtInstallmentAmount.Size = new System.Drawing.Size(201, 20);
            this.txtInstallmentAmount.TabIndex = 171;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 172;
            this.label4.Text = "Installment Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 13);
            this.label3.TabIndex = 170;
            this.label3.Text = "Start Installments - Months After Booking";
            // 
            // txtStartAfterBooking
            // 
            this.txtStartAfterBooking.Location = new System.Drawing.Point(217, 13);
            this.txtStartAfterBooking.Name = "txtStartAfterBooking";
            this.txtStartAfterBooking.Size = new System.Drawing.Size(201, 20);
            this.txtStartAfterBooking.TabIndex = 169;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 37);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 168;
            this.label19.Text = "Frequency.";
            // 
            // cmbFrequency
            // 
            this.cmbFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrequency.FormattingEnabled = true;
            this.cmbFrequency.Items.AddRange(new object[] {
            "Monthly",
            "BiMonthly",
            "Quaterly",
            "BiAnnually",
            "Annually"});
            this.cmbFrequency.Location = new System.Drawing.Point(217, 35);
            this.cmbFrequency.Name = "cmbFrequency";
            this.cmbFrequency.Size = new System.Drawing.Size(201, 21);
            this.cmbFrequency.TabIndex = 167;
            // 
            // txtInstallments
            // 
            this.txtInstallments.Location = new System.Drawing.Point(217, 58);
            this.txtInstallments.Name = "txtInstallments";
            this.txtInstallments.Size = new System.Drawing.Size(201, 20);
            this.txtInstallments.TabIndex = 165;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 166;
            this.label6.Text = "Total Installments.";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(32, 116);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(40, 13);
            this.lblProject.TabIndex = 229;
            this.lblProject.Text = "Project";
            // 
            // cmbProject
            // 
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(238, 116);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(202, 21);
            this.cmbProject.TabIndex = 228;
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 231;
            this.label9.Text = "Size Code";
            // 
            // cmbSizeCode
            // 
            this.cmbSizeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSizeCode.FormattingEnabled = true;
            this.cmbSizeCode.Location = new System.Drawing.Point(238, 143);
            this.cmbSizeCode.Name = "cmbSizeCode";
            this.cmbSizeCode.Size = new System.Drawing.Size(202, 21);
            this.cmbSizeCode.TabIndex = 230;
            // 
            // frmInstallmentPlanSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 671);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbSizeCode);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.chkInactive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlanName);
            this.Controls.Add(this.txtPlanCode);
            this.Name = "frmInstallmentPlanSetup";
            this.Text = "Installment Plan Setup";
            this.Load += new System.EventHandler(this.frmInstallmentPlanSetup_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlanCode;
        private System.Windows.Forms.TextBox txtPlanName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkInactive;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbtn_Clear;
        private System.Windows.Forms.ToolStripButton tsbtn_Cancel;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDueAmount;
        private System.Windows.Forms.TextBox txtDueAfterMonths;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbRecoveryType;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtInstallmentAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStartAfterBooking;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbFrequency;
        private System.Windows.Forms.TextBox txtInstallments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSizeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRNo;
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