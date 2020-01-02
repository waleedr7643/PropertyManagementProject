namespace TMR.GP.GrandCityAddon
{
    partial class frmCancellation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancellation));
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProjectNo = new System.Windows.Forms.TextBox();
            this.txtBlockNo = new System.Windows.Forms.TextBox();
            this.dTCancellationDate = new System.Windows.Forms.DateTimePicker();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBoxApproved = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBookingDate = new System.Windows.Forms.TextBox();
            this.txtSizeCode = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pBMemberRegistration = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBookingPrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtNetRetailPrice = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRebatAmt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tsbApprove = new System.Windows.Forms.ToolStripButton();
            this.tsbReject = new System.Windows.Forms.ToolStripButton();
            this.pBMemberCNIC = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbApprovalStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMemberRegistration)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMemberCNIC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(281, 62);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(24, 23);
            this.btnSelect.TabIndex = 122;
            this.btnSelect.Text = "...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.Location = new System.Drawing.Point(101, 64);
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.Size = new System.Drawing.Size(177, 20);
            this.txtRegistrationNo.TabIndex = 1;
            this.txtRegistrationNo.TextChanged += new System.EventHandler(this.txtRegistrationNo_TextChanged);
            this.txtRegistrationNo.Leave += new System.EventHandler(this.txtRegistrationNo_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProjectNo);
            this.groupBox1.Controls.Add(this.txtBlockNo);
            this.groupBox1.Controls.Add(this.dTCancellationDate);
            this.groupBox1.Controls.Add(this.txtUnit);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkBoxApproved);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(9, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 103);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            // 
            // txtProjectNo
            // 
            this.txtProjectNo.Location = new System.Drawing.Point(141, 44);
            this.txtProjectNo.Name = "txtProjectNo";
            this.txtProjectNo.ReadOnly = true;
            this.txtProjectNo.Size = new System.Drawing.Size(162, 20);
            this.txtProjectNo.TabIndex = 182;
            // 
            // txtBlockNo
            // 
            this.txtBlockNo.Location = new System.Drawing.Point(427, 22);
            this.txtBlockNo.Name = "txtBlockNo";
            this.txtBlockNo.ReadOnly = true;
            this.txtBlockNo.Size = new System.Drawing.Size(162, 20);
            this.txtBlockNo.TabIndex = 181;
            // 
            // dTCancellationDate
            // 
            this.dTCancellationDate.CustomFormat = "dd/MM/yyy";
            this.dTCancellationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTCancellationDate.Location = new System.Drawing.Point(141, 22);
            this.dTCancellationDate.Margin = new System.Windows.Forms.Padding(2);
            this.dTCancellationDate.Name = "dTCancellationDate";
            this.dTCancellationDate.Size = new System.Drawing.Size(162, 20);
            this.dTCancellationDate.TabIndex = 177;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(427, 44);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(162, 20);
            this.txtUnit.TabIndex = 161;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(358, 47);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 13);
            this.label21.TabIndex = 159;
            this.label21.Text = "Unit";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(38, 46);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 13);
            this.label24.TabIndex = 158;
            this.label24.Text = "Project No.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(358, 24);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 13);
            this.label20.TabIndex = 155;
            this.label20.Text = "Block No";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(141, 65);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemarks.MaxLength = 50;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(449, 20);
            this.txtRemarks.TabIndex = 134;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 138;
            this.label1.Text = "Remarks";
            // 
            // chkBoxApproved
            // 
            this.chkBoxApproved.AutoSize = true;
            this.chkBoxApproved.Location = new System.Drawing.Point(672, 21);
            this.chkBoxApproved.Name = "chkBoxApproved";
            this.chkBoxApproved.Size = new System.Drawing.Size(72, 17);
            this.chkBoxApproved.TabIndex = 135;
            this.chkBoxApproved.Text = "Approved";
            this.chkBoxApproved.UseVisualStyleBackColor = true;
            this.chkBoxApproved.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 137;
            this.label5.Text = "Cancellation Date";
            // 
            // txtBookingDate
            // 
            this.txtBookingDate.Location = new System.Drawing.Point(101, 149);
            this.txtBookingDate.Name = "txtBookingDate";
            this.txtBookingDate.ReadOnly = true;
            this.txtBookingDate.Size = new System.Drawing.Size(177, 20);
            this.txtBookingDate.TabIndex = 154;
            // 
            // txtSizeCode
            // 
            this.txtSizeCode.Location = new System.Drawing.Point(101, 128);
            this.txtSizeCode.Name = "txtSizeCode";
            this.txtSizeCode.ReadOnly = true;
            this.txtSizeCode.Size = new System.Drawing.Size(177, 20);
            this.txtSizeCode.TabIndex = 153;
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(101, 86);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientID.MaxLength = 50;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.ReadOnly = true;
            this.txtClientID.Size = new System.Drawing.Size(177, 20);
            this.txtClientID.TabIndex = 133;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 176;
            this.label6.Text = "Client ID";
            // 
            // pBMemberRegistration
            // 
            this.pBMemberRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBMemberRegistration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBMemberRegistration.Location = new System.Drawing.Point(580, 62);
            this.pBMemberRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.pBMemberRegistration.Name = "pBMemberRegistration";
            this.pBMemberRegistration.Size = new System.Drawing.Size(127, 101);
            this.pBMemberRegistration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBMemberRegistration.TabIndex = 174;
            this.pBMemberRegistration.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 152);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 172;
            this.label7.Text = "Booking Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 171;
            this.label8.Text = "Registration No.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 166;
            this.label9.Text = "Size Code";
            // 
            // txtBookingPrice
            // 
            this.txtBookingPrice.Location = new System.Drawing.Point(402, 126);
            this.txtBookingPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookingPrice.MaxLength = 18;
            this.txtBookingPrice.Name = "txtBookingPrice";
            this.txtBookingPrice.ReadOnly = true;
            this.txtBookingPrice.Size = new System.Drawing.Size(162, 20);
            this.txtBookingPrice.TabIndex = 165;
            this.txtBookingPrice.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(315, 66);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 167;
            this.label14.Text = "Total Price:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(315, 129);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 170;
            this.label18.Text = "Booking Price:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(402, 63);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalPrice.MaxLength = 18;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(162, 20);
            this.txtTotalPrice.TabIndex = 162;
            this.txtTotalPrice.Text = "0.00";
            // 
            // txtNetRetailPrice
            // 
            this.txtNetRetailPrice.Location = new System.Drawing.Point(402, 105);
            this.txtNetRetailPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtNetRetailPrice.MaxLength = 18;
            this.txtNetRetailPrice.Name = "txtNetRetailPrice";
            this.txtNetRetailPrice.ReadOnly = true;
            this.txtNetRetailPrice.Size = new System.Drawing.Size(162, 20);
            this.txtNetRetailPrice.TabIndex = 164;
            this.txtNetRetailPrice.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(315, 87);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 168;
            this.label16.Text = "Rebat Amt:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(315, 108);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 169;
            this.label17.Text = "Net/Retail Price:";
            // 
            // txtRebatAmt
            // 
            this.txtRebatAmt.Location = new System.Drawing.Point(402, 84);
            this.txtRebatAmt.Margin = new System.Windows.Forms.Padding(2);
            this.txtRebatAmt.MaxLength = 18;
            this.txtRebatAmt.Name = "txtRebatAmt";
            this.txtRebatAmt.ReadOnly = true;
            this.txtRebatAmt.Size = new System.Drawing.Size(162, 20);
            this.txtRebatAmt.TabIndex = 163;
            this.txtRebatAmt.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 200;
            this.label2.Text = "Client Name";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(101, 107);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.ReadOnly = true;
            this.txtClientName.Size = new System.Drawing.Size(177, 20);
            this.txtClientName.TabIndex = 199;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbClear,
            this.tsbClose,
            this.tsbApprove,
            this.tsbReject});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(851, 60);
            this.toolStrip1.TabIndex = 201;
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
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
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
            this.tsbClear.Click += new System.EventHandler(this.tsbClear_Click_1);
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
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click_1);
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
            this.tsbApprove.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbReject
            // 
            this.tsbReject.AutoSize = false;
            this.tsbReject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbReject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbReject.Image = ((System.Drawing.Image)(resources.GetObject("tsbReject.Image")));
            this.tsbReject.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbReject.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsbReject.Name = "tsbReject";
            this.tsbReject.Size = new System.Drawing.Size(43, 57);
            this.tsbReject.Text = "Reject";
            this.tsbReject.Visible = false;
            this.tsbReject.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // pBMemberCNIC
            // 
            this.pBMemberCNIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBMemberCNIC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBMemberCNIC.Location = new System.Drawing.Point(720, 63);
            this.pBMemberCNIC.Margin = new System.Windows.Forms.Padding(2);
            this.pBMemberCNIC.Name = "pBMemberCNIC";
            this.pBMemberCNIC.Size = new System.Drawing.Size(127, 101);
            this.pBMemberCNIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBMemberCNIC.TabIndex = 204;
            this.pBMemberCNIC.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 205;
            this.label3.Text = "Approval Status";
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
            this.cmbApprovalStatus.Location = new System.Drawing.Point(101, 175);
            this.cmbApprovalStatus.Name = "cmbApprovalStatus";
            this.cmbApprovalStatus.Size = new System.Drawing.Size(177, 21);
            this.cmbApprovalStatus.TabIndex = 206;
            // 
            // frmCancellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 337);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbApprovalStatus);
            this.Controls.Add(this.pBMemberCNIC);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pBMemberRegistration);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBookingPrice);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtNetRetailPrice);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtRebatAmt);
            this.Controls.Add(this.txtBookingDate);
            this.Controls.Add(this.txtSizeCode);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtRegistrationNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCancellation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancellation";
            this.Load += new System.EventHandler(this.frmCancellation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMemberRegistration)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMemberCNIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBoxApproved;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtBookingDate;
        private System.Windows.Forms.TextBox txtSizeCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pBMemberRegistration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBookingPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtNetRetailPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtRebatAmt;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dTCancellationDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtProjectNo;
        private System.Windows.Forms.TextBox txtBlockNo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbApprove;
        private System.Windows.Forms.ToolStripButton tsbReject;
        private System.Windows.Forms.PictureBox pBMemberCNIC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbApprovalStatus;
    }
}