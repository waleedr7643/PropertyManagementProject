namespace TMR.GP.REMSAddin
{
    partial class frmInstallmentPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstallmentPlan));
            this.txtInstallments = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbFrequency = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dTPStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dgInstallments = new System.Windows.Forms.DataGridView();
            this.SRNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.dTPBooking = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBookingPrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtNetRetailPrice = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRebatAmt = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSizeCode = new System.Windows.Forms.TextBox();
            this.txtProjects = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgInstallments)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInstallments
            // 
            this.txtInstallments.Location = new System.Drawing.Point(110, 211);
            this.txtInstallments.Name = "txtInstallments";
            this.txtInstallments.Size = new System.Drawing.Size(174, 20);
            this.txtInstallments.TabIndex = 132;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 133;
            this.label5.Text = "Total Installments.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 191);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 135;
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
            this.cmbFrequency.Location = new System.Drawing.Point(110, 188);
            this.cmbFrequency.Name = "cmbFrequency";
            this.cmbFrequency.Size = new System.Drawing.Size(174, 21);
            this.cmbFrequency.TabIndex = 134;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 235);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 137;
            this.label6.Text = "Start Date";
            // 
            // dTPStartDate
            // 
            this.dTPStartDate.CustomFormat = "dd/MM/yyy";
            this.dTPStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPStartDate.Location = new System.Drawing.Point(110, 233);
            this.dTPStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dTPStartDate.Name = "dTPStartDate";
            this.dTPStartDate.Size = new System.Drawing.Size(174, 20);
            this.dTPStartDate.TabIndex = 138;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(289, 227);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(60, 26);
            this.btnGenerate.TabIndex = 139;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dgInstallments
            // 
            this.dgInstallments.AllowUserToAddRows = false;
            this.dgInstallments.AllowUserToDeleteRows = false;
            this.dgInstallments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgInstallments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInstallments.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgInstallments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInstallments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SRNo,
            this.SNo,
            this.Amt,
            this.DueDate});
            this.dgInstallments.Location = new System.Drawing.Point(11, 267);
            this.dgInstallments.Margin = new System.Windows.Forms.Padding(2);
            this.dgInstallments.Name = "dgInstallments";
            this.dgInstallments.RowTemplate.Height = 24;
            this.dgInstallments.Size = new System.Drawing.Size(675, 242);
            this.dgInstallments.TabIndex = 140;
            // 
            // SRNo
            // 
            this.SRNo.FillWeight = 50.76142F;
            this.SRNo.HeaderText = "Sr No.";
            this.SRNo.Name = "SRNo";
            // 
            // SNo
            // 
            this.SNo.FillWeight = 116.4129F;
            this.SNo.HeaderText = "Installment No";
            this.SNo.MaxInputLength = 100;
            this.SNo.Name = "SNo";
            // 
            // Amt
            // 
            this.Amt.FillWeight = 116.4129F;
            this.Amt.HeaderText = "Installment Amount";
            this.Amt.Name = "Amt";
            // 
            // DueDate
            // 
            this.DueDate.FillWeight = 116.4129F;
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.Name = "DueDate";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbClear,
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(694, 60);
            this.toolStrip1.TabIndex = 220;
            this.toolStrip1.Text = "toolStrip1";
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 238;
            this.label1.Text = "Booking Date";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(287, 75);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(24, 23);
            this.btnSelect.TabIndex = 223;
            this.btnSelect.Text = "...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 236;
            this.label2.Text = "Project No.";
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.Location = new System.Drawing.Point(110, 76);
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.Size = new System.Drawing.Size(174, 20);
            this.txtRegistrationNo.TabIndex = 224;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(18, 80);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(83, 13);
            this.label52.TabIndex = 237;
            this.label52.Text = "Registration No.";
            // 
            // dTPBooking
            // 
            this.dTPBooking.CustomFormat = "dd/MM/yyy";
            this.dTPBooking.Enabled = false;
            this.dTPBooking.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPBooking.Location = new System.Drawing.Point(110, 117);
            this.dTPBooking.Margin = new System.Windows.Forms.Padding(2);
            this.dTPBooking.Name = "dTPBooking";
            this.dTPBooking.Size = new System.Drawing.Size(174, 20);
            this.dTPBooking.TabIndex = 225;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 142);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 231;
            this.label11.Text = "Size Code";
            // 
            // txtBookingPrice
            // 
            this.txtBookingPrice.Enabled = false;
            this.txtBookingPrice.Location = new System.Drawing.Point(410, 138);
            this.txtBookingPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookingPrice.MaxLength = 18;
            this.txtBookingPrice.Name = "txtBookingPrice";
            this.txtBookingPrice.ReadOnly = true;
            this.txtBookingPrice.Size = new System.Drawing.Size(164, 20);
            this.txtBookingPrice.TabIndex = 230;
            this.txtBookingPrice.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(323, 80);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 232;
            this.label14.Text = "Total Price:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(323, 142);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 235;
            this.label18.Text = "Booking Price:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Location = new System.Drawing.Point(410, 76);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalPrice.MaxLength = 18;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(164, 20);
            this.txtTotalPrice.TabIndex = 227;
            this.txtTotalPrice.Text = "0.00";
            // 
            // txtNetRetailPrice
            // 
            this.txtNetRetailPrice.Location = new System.Drawing.Point(410, 117);
            this.txtNetRetailPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtNetRetailPrice.MaxLength = 18;
            this.txtNetRetailPrice.Name = "txtNetRetailPrice";
            this.txtNetRetailPrice.ReadOnly = true;
            this.txtNetRetailPrice.Size = new System.Drawing.Size(164, 20);
            this.txtNetRetailPrice.TabIndex = 229;
            this.txtNetRetailPrice.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(323, 101);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 233;
            this.label16.Text = "Rebate Amt:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(323, 121);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 234;
            this.label17.Text = "Net/Retail Price:";
            // 
            // txtRebatAmt
            // 
            this.txtRebatAmt.Enabled = false;
            this.txtRebatAmt.Location = new System.Drawing.Point(410, 97);
            this.txtRebatAmt.Margin = new System.Windows.Forms.Padding(2);
            this.txtRebatAmt.MaxLength = 18;
            this.txtRebatAmt.Name = "txtRebatAmt";
            this.txtRebatAmt.ReadOnly = true;
            this.txtRebatAmt.Size = new System.Drawing.Size(164, 20);
            this.txtRebatAmt.TabIndex = 228;
            this.txtRebatAmt.Text = "0.00";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(324, 165);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(64, 13);
            this.label34.TabIndex = 242;
            this.label34.Text = "Client Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 241;
            this.label3.Text = "Client ID";
            // 
            // txtClientID
            // 
            this.txtClientID.Enabled = false;
            this.txtClientID.Location = new System.Drawing.Point(110, 161);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientID.MaxLength = 50;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.ReadOnly = true;
            this.txtClientID.Size = new System.Drawing.Size(174, 20);
            this.txtClientID.TabIndex = 239;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(410, 161);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(164, 20);
            this.txtName.TabIndex = 240;
            // 
            // txtSizeCode
            // 
            this.txtSizeCode.Location = new System.Drawing.Point(110, 138);
            this.txtSizeCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtSizeCode.MaxLength = 50;
            this.txtSizeCode.Name = "txtSizeCode";
            this.txtSizeCode.ReadOnly = true;
            this.txtSizeCode.Size = new System.Drawing.Size(174, 20);
            this.txtSizeCode.TabIndex = 243;
            // 
            // txtProjects
            // 
            this.txtProjects.Enabled = false;
            this.txtProjects.Location = new System.Drawing.Point(110, 97);
            this.txtProjects.Margin = new System.Windows.Forms.Padding(2);
            this.txtProjects.MaxLength = 50;
            this.txtProjects.Name = "txtProjects";
            this.txtProjects.ReadOnly = true;
            this.txtProjects.Size = new System.Drawing.Size(174, 20);
            this.txtProjects.TabIndex = 244;
            // 
            // frmInstallmentPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 514);
            this.Controls.Add(this.txtProjects);
            this.Controls.Add(this.txtSizeCode);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRegistrationNo);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.dTPBooking);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBookingPrice);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtNetRetailPrice);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtRebatAmt);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgInstallments);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dTPStartDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cmbFrequency);
            this.Controls.Add(this.txtInstallments);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInstallmentPlan";
            this.Text = "Installment Plan";
            this.Load += new System.EventHandler(this.frmInstallmentPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInstallments)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInstallments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbFrequency;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dTPStartDate;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dgInstallments;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.DateTimePicker dTPBooking;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBookingPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtNetRetailPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtRebatAmt;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSizeCode;
        private System.Windows.Forms.TextBox txtProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
    }
}