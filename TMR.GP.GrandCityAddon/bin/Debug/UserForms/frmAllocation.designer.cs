namespace TMR.GP.GrandCityAddon
{
    partial class frmAllocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllocation));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tsbApprove = new System.Windows.Forms.ToolStripButton();
            this.tsbReject = new System.Windows.Forms.ToolStripButton();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.gBAllocation = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDirector = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.dTAllocationDate = new System.Windows.Forms.DateTimePicker();
            this.chkBoxApproved = new System.Windows.Forms.CheckBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.btnSelectUnit = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.cmbBlock = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.dTPBooking = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSizeCode = new System.Windows.Forms.TextBox();
            this.txtBookingPrice = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNetRetailPrice = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRebatAmt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pBMemberRegistration = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.pBMemberCNIC = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbApprovalStatus = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.gBAllocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMemberRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMemberCNIC)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(940, 60);
            this.toolStrip1.TabIndex = 8;
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
            this.tsbSave.Click += new System.EventHandler(this.btnAllocationSave_Click);
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
            this.tsbApprove.Click += new System.EventHandler(this.btnAllocationSave_Click);
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
            this.tsbReject.Click += new System.EventHandler(this.btnAllocationSave_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(40, 25);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Allocation Date";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(342, 20);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Sector/Floor";
            // 
            // gBAllocation
            // 
            this.gBAllocation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gBAllocation.Controls.Add(this.label4);
            this.gBAllocation.Controls.Add(this.cmbDirector);
            this.gBAllocation.Controls.Add(this.label3);
            this.gBAllocation.Controls.Add(this.txtRemarks);
            this.gBAllocation.Controls.Add(this.dTAllocationDate);
            this.gBAllocation.Controls.Add(this.chkBoxApproved);
            this.gBAllocation.Controls.Add(this.txtUnit);
            this.gBAllocation.Controls.Add(this.btnSelectUnit);
            this.gBAllocation.Controls.Add(this.label21);
            this.gBAllocation.Controls.Add(this.label24);
            this.gBAllocation.Controls.Add(this.label20);
            this.gBAllocation.Controls.Add(this.cmbProject);
            this.gBAllocation.Controls.Add(this.cmbBlock);
            this.gBAllocation.Controls.Add(this.label19);
            this.gBAllocation.Location = new System.Drawing.Point(34, 211);
            this.gBAllocation.Margin = new System.Windows.Forms.Padding(2);
            this.gBAllocation.Name = "gBAllocation";
            this.gBAllocation.Padding = new System.Windows.Forms.Padding(2);
            this.gBAllocation.Size = new System.Drawing.Size(886, 145);
            this.gBAllocation.TabIndex = 2;
            this.gBAllocation.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 165;
            this.label4.Text = "Quota";
            // 
            // cmbDirector
            // 
            this.cmbDirector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDirector.FormattingEnabled = true;
            this.cmbDirector.Location = new System.Drawing.Point(128, 86);
            this.cmbDirector.Name = "cmbDirector";
            this.cmbDirector.Size = new System.Drawing.Size(174, 21);
            this.cmbDirector.TabIndex = 166;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 164;
            this.label3.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(128, 63);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemarks.MaxLength = 50;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(463, 20);
            this.txtRemarks.TabIndex = 163;
            // 
            // dTAllocationDate
            // 
            this.dTAllocationDate.CustomFormat = "dd/MM/yyy";
            this.dTAllocationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTAllocationDate.Location = new System.Drawing.Point(128, 18);
            this.dTAllocationDate.Margin = new System.Windows.Forms.Padding(2);
            this.dTAllocationDate.Name = "dTAllocationDate";
            this.dTAllocationDate.Size = new System.Drawing.Size(174, 20);
            this.dTAllocationDate.TabIndex = 0;
            // 
            // chkBoxApproved
            // 
            this.chkBoxApproved.AutoSize = true;
            this.chkBoxApproved.Location = new System.Drawing.Point(638, 16);
            this.chkBoxApproved.Name = "chkBoxApproved";
            this.chkBoxApproved.Size = new System.Drawing.Size(72, 17);
            this.chkBoxApproved.TabIndex = 4;
            this.chkBoxApproved.Text = "Approved";
            this.chkBoxApproved.UseVisualStyleBackColor = true;
            this.chkBoxApproved.Visible = false;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(429, 40);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(162, 20);
            this.txtUnit.TabIndex = 3;
            // 
            // btnSelectUnit
            // 
            this.btnSelectUnit.Location = new System.Drawing.Point(596, 40);
            this.btnSelectUnit.Name = "btnSelectUnit";
            this.btnSelectUnit.Size = new System.Drawing.Size(24, 23);
            this.btnSelectUnit.TabIndex = 144;
            this.btnSelectUnit.Text = "...";
            this.btnSelectUnit.UseVisualStyleBackColor = true;
            this.btnSelectUnit.Click += new System.EventHandler(this.btnSelectUnit_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(342, 45);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 13);
            this.label21.TabIndex = 143;
            this.label21.Text = "Unit:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(40, 43);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 13);
            this.label24.TabIndex = 142;
            this.label24.Text = "Project No.";
            // 
            // cmbProject
            // 
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.Enabled = false;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(128, 40);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(174, 21);
            this.cmbProject.TabIndex = 1;
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            // 
            // cmbBlock
            // 
            this.cmbBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlock.FormattingEnabled = true;
            this.cmbBlock.Location = new System.Drawing.Point(429, 17);
            this.cmbBlock.Name = "cmbBlock";
            this.cmbBlock.Size = new System.Drawing.Size(162, 21);
            this.cmbBlock.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(342, 70);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(24, 23);
            this.btnSelect.TabIndex = 93;
            this.btnSelect.Text = "...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 147;
            this.label1.Text = "Booking Date";
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.Location = new System.Drawing.Point(162, 70);
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.Size = new System.Drawing.Size(174, 20);
            this.txtRegistrationNo.TabIndex = 0;
            this.txtRegistrationNo.Leave += new System.EventHandler(this.txtRegistrationNo_Leave);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(74, 75);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(83, 13);
            this.label52.TabIndex = 146;
            this.label52.Text = "Registration No.";
            // 
            // dTPBooking
            // 
            this.dTPBooking.CustomFormat = "dd/MM/yyy";
            this.dTPBooking.Enabled = false;
            this.dTPBooking.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPBooking.Location = new System.Drawing.Point(162, 157);
            this.dTPBooking.Margin = new System.Windows.Forms.Padding(2);
            this.dTPBooking.Name = "dTPBooking";
            this.dTPBooking.Size = new System.Drawing.Size(174, 20);
            this.dTPBooking.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 139);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 137;
            this.label11.Text = "Size Code";
            // 
            // txtSizeCode
            // 
            this.txtSizeCode.Location = new System.Drawing.Point(162, 136);
            this.txtSizeCode.Name = "txtSizeCode";
            this.txtSizeCode.ReadOnly = true;
            this.txtSizeCode.Size = new System.Drawing.Size(174, 20);
            this.txtSizeCode.TabIndex = 2;
            // 
            // txtBookingPrice
            // 
            this.txtBookingPrice.Location = new System.Drawing.Point(463, 138);
            this.txtBookingPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookingPrice.MaxLength = 18;
            this.txtBookingPrice.Name = "txtBookingPrice";
            this.txtBookingPrice.ReadOnly = true;
            this.txtBookingPrice.Size = new System.Drawing.Size(162, 20);
            this.txtBookingPrice.TabIndex = 7;
            this.txtBookingPrice.Text = "0.00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(376, 141);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 144;
            this.label18.Text = "Booking Price:";
            // 
            // txtNetRetailPrice
            // 
            this.txtNetRetailPrice.Location = new System.Drawing.Point(463, 114);
            this.txtNetRetailPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtNetRetailPrice.MaxLength = 18;
            this.txtNetRetailPrice.Name = "txtNetRetailPrice";
            this.txtNetRetailPrice.ReadOnly = true;
            this.txtNetRetailPrice.Size = new System.Drawing.Size(162, 20);
            this.txtNetRetailPrice.TabIndex = 6;
            this.txtNetRetailPrice.Text = "0.00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(376, 114);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 143;
            this.label17.Text = "Net/Retail Price:";
            // 
            // txtRebatAmt
            // 
            this.txtRebatAmt.Location = new System.Drawing.Point(463, 92);
            this.txtRebatAmt.Margin = new System.Windows.Forms.Padding(2);
            this.txtRebatAmt.MaxLength = 18;
            this.txtRebatAmt.Name = "txtRebatAmt";
            this.txtRebatAmt.ReadOnly = true;
            this.txtRebatAmt.Size = new System.Drawing.Size(162, 20);
            this.txtRebatAmt.TabIndex = 5;
            this.txtRebatAmt.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(376, 93);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 142;
            this.label16.Text = "Rebat Amt:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(463, 69);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalPrice.MaxLength = 18;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(162, 20);
            this.txtTotalPrice.TabIndex = 4;
            this.txtTotalPrice.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(376, 72);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 140;
            this.label14.Text = "Total Price:";
            // 
            // pBMemberRegistration
            // 
            this.pBMemberRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBMemberRegistration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBMemberRegistration.Location = new System.Drawing.Point(641, 69);
            this.pBMemberRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.pBMemberRegistration.Name = "pBMemberRegistration";
            this.pBMemberRegistration.Size = new System.Drawing.Size(127, 101);
            this.pBMemberRegistration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBMemberRegistration.TabIndex = 150;
            this.pBMemberRegistration.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 152;
            this.label2.Text = "Client ID";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(162, 114);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientID.MaxLength = 50;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.ReadOnly = true;
            this.txtClientID.Size = new System.Drawing.Size(174, 20);
            this.txtClientID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 202;
            this.label5.Text = "Client Name";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(162, 92);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.ReadOnly = true;
            this.txtClientName.Size = new System.Drawing.Size(174, 20);
            this.txtClientName.TabIndex = 201;
            // 
            // pBMemberCNIC
            // 
            this.pBMemberCNIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBMemberCNIC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBMemberCNIC.Location = new System.Drawing.Point(782, 69);
            this.pBMemberCNIC.Margin = new System.Windows.Forms.Padding(2);
            this.pBMemberCNIC.Name = "pBMemberCNIC";
            this.pBMemberCNIC.Size = new System.Drawing.Size(127, 101);
            this.pBMemberCNIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBMemberCNIC.TabIndex = 203;
            this.pBMemberCNIC.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 167;
            this.label6.Text = "Approval Status";
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
            this.cmbApprovalStatus.Location = new System.Drawing.Point(162, 182);
            this.cmbApprovalStatus.Name = "cmbApprovalStatus";
            this.cmbApprovalStatus.Size = new System.Drawing.Size(174, 21);
            this.cmbApprovalStatus.TabIndex = 168;
            // 
            // frmAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 380);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pBMemberCNIC);
            this.Controls.Add(this.cmbApprovalStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.pBMemberRegistration);
            this.Controls.Add(this.txtSizeCode);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gBAllocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAllocation";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Allocation";
            this.Load += new System.EventHandler(this.Allocation_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gBAllocation.ResumeLayout(false);
            this.gBAllocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMemberRegistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMemberCNIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox gBAllocation;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.ComboBox cmbBlock;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnSelectUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.DateTimePicker dTPBooking;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSizeCode;
        private System.Windows.Forms.TextBox txtBookingPrice;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNetRetailPrice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtRebatAmt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pBMemberRegistration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.CheckBox chkBoxApproved;
        private System.Windows.Forms.DateTimePicker dTAllocationDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDirector;
        private System.Windows.Forms.ToolStripButton tsbApprove;
        private System.Windows.Forms.ToolStripButton tsbReject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.PictureBox pBMemberCNIC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbApprovalStatus;

    }
}