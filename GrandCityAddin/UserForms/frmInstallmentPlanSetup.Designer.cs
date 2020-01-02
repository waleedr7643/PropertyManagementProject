namespace TMR.GP.GrandCityAddon.UserForms
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
            this.dgInstallments = new System.Windows.Forms.DataGridView();
            this.txtPlanCode = new System.Windows.Forms.TextBox();
            this.txtPlanName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkInactive = new System.Windows.Forms.CheckBox();
            this.txtDuePercentage = new System.Windows.Forms.TextBox();
            this.txtDueAfterMonths = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbInstallmentType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Clear = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Cancel = new System.Windows.Forms.ToolStripButton();
            this.InstallmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallmentTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgInstallments)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgInstallments
            // 
            this.dgInstallments.AllowUserToAddRows = false;
            this.dgInstallments.AllowUserToDeleteRows = false;
            this.dgInstallments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInstallments.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgInstallments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInstallments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InstallmentId,
            this.SNo,
            this.Percentage,
            this.DueAfter,
            this.InstallmentTypeId,
            this.PaymentType});
            this.dgInstallments.Location = new System.Drawing.Point(11, 245);
            this.dgInstallments.Margin = new System.Windows.Forms.Padding(2);
            this.dgInstallments.Name = "dgInstallments";
            this.dgInstallments.RowTemplate.Height = 24;
            this.dgInstallments.Size = new System.Drawing.Size(675, 197);
            this.dgInstallments.TabIndex = 141;
            // 
            // txtPlanCode
            // 
            this.txtPlanCode.Location = new System.Drawing.Point(133, 67);
            this.txtPlanCode.Name = "txtPlanCode";
            this.txtPlanCode.Size = new System.Drawing.Size(201, 20);
            this.txtPlanCode.TabIndex = 142;
            // 
            // txtPlanName
            // 
            this.txtPlanName.Location = new System.Drawing.Point(133, 91);
            this.txtPlanName.Name = "txtPlanName";
            this.txtPlanName.Size = new System.Drawing.Size(201, 20);
            this.txtPlanName.TabIndex = 143;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 144;
            this.label1.Text = "Installment Plan Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 145;
            this.label2.Text = "Installment Plan Name";
            // 
            // chkInactive
            // 
            this.chkInactive.AutoSize = true;
            this.chkInactive.Location = new System.Drawing.Point(377, 73);
            this.chkInactive.Name = "chkInactive";
            this.chkInactive.Size = new System.Drawing.Size(64, 17);
            this.chkInactive.TabIndex = 146;
            this.chkInactive.Text = "Inactive";
            this.chkInactive.UseVisualStyleBackColor = true;
            // 
            // txtDuePercentage
            // 
            this.txtDuePercentage.Location = new System.Drawing.Point(133, 166);
            this.txtDuePercentage.Name = "txtDuePercentage";
            this.txtDuePercentage.Size = new System.Drawing.Size(201, 20);
            this.txtDuePercentage.TabIndex = 148;
            // 
            // txtDueAfterMonths
            // 
            this.txtDueAfterMonths.Location = new System.Drawing.Point(133, 142);
            this.txtDueAfterMonths.Name = "txtDueAfterMonths";
            this.txtDueAfterMonths.Size = new System.Drawing.Size(201, 20);
            this.txtDueAfterMonths.TabIndex = 147;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 149;
            this.label3.Text = "Due After Months";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 150;
            this.label4.Text = "Due Percentage";
            // 
            // cmbInstallmentType
            // 
            this.cmbInstallmentType.FormattingEnabled = true;
            this.cmbInstallmentType.Items.AddRange(new object[] {
            "Booking",
            "Installment"});
            this.cmbInstallmentType.Location = new System.Drawing.Point(133, 190);
            this.cmbInstallmentType.Name = "cmbInstallmentType";
            this.cmbInstallmentType.Size = new System.Drawing.Size(201, 21);
            this.cmbInstallmentType.TabIndex = 151;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 152;
            this.label5.Text = "Payment Type";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(259, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 153;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.toolStrip2.Size = new System.Drawing.Size(702, 60);
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
            // InstallmentId
            // 
            this.InstallmentId.HeaderText = "Id";
            this.InstallmentId.Name = "InstallmentId";
            this.InstallmentId.Visible = false;
            // 
            // SNo
            // 
            this.SNo.HeaderText = "Installment No";
            this.SNo.MaxInputLength = 100;
            this.SNo.Name = "SNo";
            // 
            // Percentage
            // 
            this.Percentage.HeaderText = "Percentage";
            this.Percentage.Name = "Percentage";
            // 
            // DueAfter
            // 
            this.DueAfter.HeaderText = "Due After Months";
            this.DueAfter.Name = "DueAfter";
            // 
            // InstallmentTypeId
            // 
            this.InstallmentTypeId.HeaderText = "PaymentTypeID";
            this.InstallmentTypeId.Name = "InstallmentTypeId";
            this.InstallmentTypeId.Visible = false;
            // 
            // PaymentType
            // 
            this.PaymentType.HeaderText = "Payment Type";
            this.PaymentType.Name = "PaymentType";
            // 
            // frmInstallmentPlanSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 464);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbInstallmentType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDuePercentage);
            this.Controls.Add(this.txtDueAfterMonths);
            this.Controls.Add(this.chkInactive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlanName);
            this.Controls.Add(this.txtPlanCode);
            this.Controls.Add(this.dgInstallments);
            this.Name = "frmInstallmentPlanSetup";
            this.Text = "frmInstallmentPlanSetup";
            this.Load += new System.EventHandler(this.frmInstallmentPlanSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInstallments)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgInstallments;
        private System.Windows.Forms.TextBox txtPlanCode;
        private System.Windows.Forms.TextBox txtPlanName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkInactive;
        private System.Windows.Forms.TextBox txtDuePercentage;
        private System.Windows.Forms.TextBox txtDueAfterMonths;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbInstallmentType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbtn_Clear;
        private System.Windows.Forms.ToolStripButton tsbtn_Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueAfter;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallmentTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentType;
    }
}