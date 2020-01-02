namespace TMR.GP.REMSAddin
{
    partial class frmRefund
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRefund));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTaxWithheld = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.txtDeduction = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.dTRefundDate = new System.Windows.Forms.DateTimePicker();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBoxApproved = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pBMemberRegistration = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBookingPrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNetRetailPrice = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtRebatAmt = new System.Windows.Forms.TextBox();
            this.txtBookingDate = new System.Windows.Forms.TextBox();
            this.txtSizeCode = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tsbApprove = new System.Windows.Forms.ToolStripButton();
            this.tsbReject = new System.Windows.Forms.ToolStripButton();
            this.label34 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pBMemberCNIC = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbApprovalStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMemberRegistration)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMemberCNIC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtNetAmount);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTaxWithheld);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtProject);
            this.groupBox1.Controls.Add(this.txtDeduction);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProfit);
            this.groupBox1.Controls.Add(this.dTRefundDate);
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkBoxApproved);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(27, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 110);
            this.groupBox1.TabIndex = 199;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(506, 89);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 227;
            this.label11.Text = "Net";
            this.label11.Visible = false;
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Location = new System.Drawing.Point(609, 86);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.Size = new System.Drawing.Size(180, 20);
            this.txtNetAmount.TabIndex = 5;
            this.txtNetAmount.Text = "0.00";
            this.txtNetAmount.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(506, 69);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 225;
            this.label10.Text = "Tax Withheld";
            this.label10.Visible = false;
            // 
            // txtTaxWithheld
            // 
            this.txtTaxWithheld.Location = new System.Drawing.Point(608, 63);
            this.txtTaxWithheld.Name = "txtTaxWithheld";
            this.txtTaxWithheld.Size = new System.Drawing.Size(180, 20);
            this.txtTaxWithheld.TabIndex = 4;
            this.txtTaxWithheld.Text = "0.00";
            this.txtTaxWithheld.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 221;
            this.label4.Text = "Project";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 223;
            this.label3.Text = "Misc Deductions";
            this.label3.Visible = false;
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(71, 12);
            this.txtProject.Name = "txtProject";
            this.txtProject.ReadOnly = true;
            this.txtProject.Size = new System.Drawing.Size(177, 20);
            this.txtProject.TabIndex = 0;
            // 
            // txtDeduction
            // 
            this.txtDeduction.Location = new System.Drawing.Point(609, 41);
            this.txtDeduction.Name = "txtDeduction";
            this.txtDeduction.Size = new System.Drawing.Size(180, 20);
            this.txtDeduction.TabIndex = 3;
            this.txtDeduction.Text = "0.00";
            this.txtDeduction.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 221;
            this.label2.Text = "Profit";
            this.label2.Visible = false;
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(609, 20);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(180, 20);
            this.txtProfit.TabIndex = 2;
            this.txtProfit.Text = "0.00";
            this.txtProfit.Visible = false;
            // 
            // dTRefundDate
            // 
            this.dTRefundDate.CustomFormat = "dd/MM/yyy";
            this.dTRefundDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTRefundDate.Location = new System.Drawing.Point(71, 37);
            this.dTRefundDate.Margin = new System.Windows.Forms.Padding(2);
            this.dTRefundDate.Name = "dTRefundDate";
            this.dTRefundDate.Size = new System.Drawing.Size(180, 20);
            this.dTRefundDate.TabIndex = 1;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(71, 62);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemarks.MaxLength = 50;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(466, 20);
            this.txtRemarks.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 138;
            this.label1.Text = "Remarks";
            // 
            // chkBoxApproved
            // 
            this.chkBoxApproved.AutoSize = true;
            this.chkBoxApproved.Location = new System.Drawing.Point(801, 37);
            this.chkBoxApproved.Name = "chkBoxApproved";
            this.chkBoxApproved.Size = new System.Drawing.Size(72, 17);
            this.chkBoxApproved.TabIndex = 8;
            this.chkBoxApproved.Text = "Approved";
            this.chkBoxApproved.UseVisualStyleBackColor = true;
            this.chkBoxApproved.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 137;
            this.label5.Text = "Refund Date";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(279, 69);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(24, 23);
            this.btnSelect.TabIndex = 198;
            this.btnSelect.Text = "...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(99, 93);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientID.MaxLength = 50;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.ReadOnly = true;
            this.txtClientID.Size = new System.Drawing.Size(177, 20);
            this.txtClientID.TabIndex = 200;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 216;
            this.label6.Text = "Client ID";
            // 
            // pBMemberRegistration
            // 
            this.pBMemberRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBMemberRegistration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBMemberRegistration.Location = new System.Drawing.Point(614, 71);
            this.pBMemberRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.pBMemberRegistration.Name = "pBMemberRegistration";
            this.pBMemberRegistration.Size = new System.Drawing.Size(127, 101);
            this.pBMemberRegistration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBMemberRegistration.TabIndex = 215;
            this.pBMemberRegistration.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 214;
            this.label7.Text = "Booking Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 213;
            this.label8.Text = "Registration No.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 138);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 208;
            this.label9.Text = "Size Code";
            // 
            // txtBookingPrice
            // 
            this.txtBookingPrice.Location = new System.Drawing.Point(400, 139);
            this.txtBookingPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookingPrice.MaxLength = 18;
            this.txtBookingPrice.Name = "txtBookingPrice";
            this.txtBookingPrice.ReadOnly = true;
            this.txtBookingPrice.Size = new System.Drawing.Size(162, 20);
            this.txtBookingPrice.TabIndex = 207;
            this.txtBookingPrice.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(313, 68);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 209;
            this.label14.Text = "Total Price:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(313, 142);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 212;
            this.label18.Text = "Booking Price:";
            // 
            // txtNetRetailPrice
            // 
            this.txtNetRetailPrice.Location = new System.Drawing.Point(400, 115);
            this.txtNetRetailPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtNetRetailPrice.MaxLength = 18;
            this.txtNetRetailPrice.Name = "txtNetRetailPrice";
            this.txtNetRetailPrice.ReadOnly = true;
            this.txtNetRetailPrice.Size = new System.Drawing.Size(162, 20);
            this.txtNetRetailPrice.TabIndex = 206;
            this.txtNetRetailPrice.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(313, 94);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 210;
            this.label16.Text = "Rebat Amt:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(313, 115);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 211;
            this.label17.Text = "Net/Retail Price:";
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.Location = new System.Drawing.Point(99, 71);
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.Size = new System.Drawing.Size(177, 20);
            this.txtRegistrationNo.TabIndex = 0;
            this.txtRegistrationNo.TextChanged += new System.EventHandler(this.txtRegistrationNo_TextChanged);
            this.txtRegistrationNo.Leave += new System.EventHandler(this.txtRegistrationNo_Leave);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(400, 70);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalPrice.MaxLength = 18;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(162, 20);
            this.txtTotalPrice.TabIndex = 204;
            this.txtTotalPrice.Text = "0.00";
            // 
            // txtRebatAmt
            // 
            this.txtRebatAmt.Location = new System.Drawing.Point(400, 93);
            this.txtRebatAmt.Margin = new System.Windows.Forms.Padding(2);
            this.txtRebatAmt.MaxLength = 18;
            this.txtRebatAmt.Name = "txtRebatAmt";
            this.txtRebatAmt.ReadOnly = true;
            this.txtRebatAmt.Size = new System.Drawing.Size(162, 20);
            this.txtRebatAmt.TabIndex = 205;
            this.txtRebatAmt.Text = "0.00";
            // 
            // txtBookingDate
            // 
            this.txtBookingDate.Location = new System.Drawing.Point(99, 155);
            this.txtBookingDate.Name = "txtBookingDate";
            this.txtBookingDate.ReadOnly = true;
            this.txtBookingDate.Size = new System.Drawing.Size(177, 20);
            this.txtBookingDate.TabIndex = 202;
            // 
            // txtSizeCode
            // 
            this.txtSizeCode.Location = new System.Drawing.Point(99, 134);
            this.txtSizeCode.Name = "txtSizeCode";
            this.txtSizeCode.ReadOnly = true;
            this.txtSizeCode.Size = new System.Drawing.Size(177, 20);
            this.txtSizeCode.TabIndex = 201;
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
            this.toolStrip1.Size = new System.Drawing.Size(915, 60);
            this.toolStrip1.TabIndex = 217;
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
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(11, 115);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(64, 13);
            this.label34.TabIndex = 219;
            this.label34.Text = "Client Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 115);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(177, 20);
            this.txtName.TabIndex = 218;
            // 
            // pBMemberCNIC
            // 
            this.pBMemberCNIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBMemberCNIC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBMemberCNIC.Location = new System.Drawing.Point(755, 71);
            this.pBMemberCNIC.Margin = new System.Windows.Forms.Padding(2);
            this.pBMemberCNIC.Name = "pBMemberCNIC";
            this.pBMemberCNIC.Size = new System.Drawing.Size(127, 101);
            this.pBMemberCNIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBMemberCNIC.TabIndex = 220;
            this.pBMemberCNIC.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 180);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 221;
            this.label12.Text = "Approval Status";
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
            this.cmbApprovalStatus.Location = new System.Drawing.Point(99, 177);
            this.cmbApprovalStatus.Name = "cmbApprovalStatus";
            this.cmbApprovalStatus.Size = new System.Drawing.Size(178, 21);
            this.cmbApprovalStatus.TabIndex = 222;
            // 
            // frmRefund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 344);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbApprovalStatus);
            this.Controls.Add(this.pBMemberCNIC);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pBMemberRegistration);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBookingPrice);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtNetRetailPrice);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtRegistrationNo);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtRebatAmt);
            this.Controls.Add(this.txtBookingDate);
            this.Controls.Add(this.txtSizeCode);
            this.Name = "frmRefund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refund/Buy Back";
            this.Load += new System.EventHandler(this.frmRefund_Load);
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

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBoxApproved;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pBMemberRegistration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBookingPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNetRetailPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtRebatAmt;
        private System.Windows.Forms.TextBox txtBookingDate;
        private System.Windows.Forms.TextBox txtSizeCode;
        private System.Windows.Forms.DateTimePicker dTRefundDate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeduction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.ToolStripButton tsbApprove;
        private System.Windows.Forms.ToolStripButton tsbReject;
        private System.Windows.Forms.PictureBox pBMemberCNIC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTaxWithheld;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbApprovalStatus;
    }
}