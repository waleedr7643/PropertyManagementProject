namespace TMR.GP.REMSAddin
{
    partial class frmReceiptEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceiptEntry));
            this.btnSelectRegistration = new System.Windows.Forms.Button();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbAttach = new System.Windows.Forms.ToolStripButton();
            this.label34 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgInstallmentList = new System.Windows.Forms.DataGridView();
            this.InstallmentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallmentRecoveryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallmentDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallmentDueAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallmentOutStanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallmentReceivedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalWaivedInst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppliedAmountInst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallmentWaived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplyInstallment = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OApplyInstallment = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReceiptNumber = new System.Windows.Forms.TextBox();
            this.dtpReceived = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReceiptAmount = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.cmbReceiptMode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInstrumentNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpInstrument = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbDepositBank = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDepositBy = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpDeposit = new System.Windows.Forms.DateTimePicker();
            this.dtpClearance = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAppliedAmount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRemainingAmount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDepositAcc = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbClearanceStatus = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPlotSize = new System.Windows.Forms.TextBox();
            this.txtDraweeBank = new System.Windows.Forms.TextBox();
            this.txtDraweeBranch = new System.Windows.Forms.TextBox();
            this.txtPlotCategory = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtUnitID = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInstallmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectRegistration
            // 
            this.btnSelectRegistration.Location = new System.Drawing.Point(594, 65);
            this.btnSelectRegistration.Name = "btnSelectRegistration";
            this.btnSelectRegistration.Size = new System.Drawing.Size(24, 23);
            this.btnSelectRegistration.TabIndex = 123;
            this.btnSelectRegistration.Text = "...";
            this.btnSelectRegistration.UseVisualStyleBackColor = true;
            this.btnSelectRegistration.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.Location = new System.Drawing.Point(413, 66);
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.ReadOnly = true;
            this.txtRegistrationNo.Size = new System.Drawing.Size(174, 20);
            this.txtRegistrationNo.TabIndex = 1;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(314, 70);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(83, 13);
            this.label52.TabIndex = 126;
            this.label52.Text = "Registration No.";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbClear,
            this.tsbClose,
            this.tsbPrint,
            this.tsbAttach});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(976, 60);
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
            // tsbPrint
            // 
            this.tsbPrint.AutoSize = false;
            this.tsbPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(43, 60);
            this.tsbPrint.Text = "Print";
            this.tsbPrint.ToolTipText = "Load";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // tsbAttach
            // 
            this.tsbAttach.AutoSize = false;
            this.tsbAttach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbAttach.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAttach.Image = ((System.Drawing.Image)(resources.GetObject("tsbAttach.Image")));
            this.tsbAttach.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAttach.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsbAttach.Name = "tsbAttach";
            this.tsbAttach.Size = new System.Drawing.Size(43, 57);
            this.tsbAttach.Text = "Attach";
            this.tsbAttach.Click += new System.EventHandler(this.tsbAttach_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(314, 92);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(64, 13);
            this.label34.TabIndex = 224;
            this.label34.Text = "Client Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 223;
            this.label2.Text = "Client ID";
            // 
            // txtClientID
            // 
            this.txtClientID.Enabled = false;
            this.txtClientID.Location = new System.Drawing.Point(100, 88);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientID.MaxLength = 50;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(174, 20);
            this.txtClientID.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(413, 88);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 20);
            this.txtName.TabIndex = 3;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage5);
            this.tabMain.Location = new System.Drawing.Point(0, 352);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(971, 286);
            this.tabMain.TabIndex = 225;
            this.tabMain.Tag = "";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgInstallmentList);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(963, 260);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Installment Plan";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgInstallmentList
            // 
            this.dgInstallmentList.AllowUserToAddRows = false;
            this.dgInstallmentList.AllowUserToDeleteRows = false;
            this.dgInstallmentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgInstallmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInstallmentList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgInstallmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInstallmentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InstallmentNumber,
            this.InstallmentRecoveryType,
            this.InstallmentDueDate,
            this.InstallmentDueAmount,
            this.InstallmentOutStanding,
            this.InstallmentReceivedAmount,
            this.TotalWaivedInst,
            this.AppliedAmountInst,
            this.InstallmentWaived,
            this.InstallmentID,
            this.ApplyInstallment,
            this.OApplyInstallment});
            this.dgInstallmentList.Location = new System.Drawing.Point(5, 3);
            this.dgInstallmentList.Name = "dgInstallmentList";
            this.dgInstallmentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInstallmentList.Size = new System.Drawing.Size(949, 251);
            this.dgInstallmentList.TabIndex = 53;
            this.dgInstallmentList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInstallmentList_CellEnter);
            this.dgInstallmentList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInstallmentList_CellValueChanged);
            this.dgInstallmentList.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgInstallmentList_CurrentCellDirtyStateChanged);
            this.dgInstallmentList.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgInstallmentList_EditingControlShowing);
            this.dgInstallmentList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInstallmentList_RowEnter);
            this.dgInstallmentList.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgInstallmentList_RowValidating);
            // 
            // InstallmentNumber
            // 
            this.InstallmentNumber.HeaderText = "Installment No";
            this.InstallmentNumber.Name = "InstallmentNumber";
            this.InstallmentNumber.ReadOnly = true;
            // 
            // InstallmentRecoveryType
            // 
            this.InstallmentRecoveryType.HeaderText = "Recovery Type";
            this.InstallmentRecoveryType.Name = "InstallmentRecoveryType";
            this.InstallmentRecoveryType.ReadOnly = true;
            this.InstallmentRecoveryType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // InstallmentDueDate
            // 
            this.InstallmentDueDate.HeaderText = "Due Date";
            this.InstallmentDueDate.Name = "InstallmentDueDate";
            this.InstallmentDueDate.ReadOnly = true;
            // 
            // InstallmentDueAmount
            // 
            this.InstallmentDueAmount.HeaderText = "Due Amount";
            this.InstallmentDueAmount.Name = "InstallmentDueAmount";
            this.InstallmentDueAmount.ReadOnly = true;
            // 
            // InstallmentOutStanding
            // 
            this.InstallmentOutStanding.HeaderText = "O. Std Amt";
            this.InstallmentOutStanding.Name = "InstallmentOutStanding";
            this.InstallmentOutStanding.ReadOnly = true;
            // 
            // InstallmentReceivedAmount
            // 
            this.InstallmentReceivedAmount.HeaderText = "Total Recevd Amt.";
            this.InstallmentReceivedAmount.Name = "InstallmentReceivedAmount";
            this.InstallmentReceivedAmount.ReadOnly = true;
            // 
            // TotalWaivedInst
            // 
            this.TotalWaivedInst.HeaderText = "Waived Amt.";
            this.TotalWaivedInst.Name = "TotalWaivedInst";
            this.TotalWaivedInst.ReadOnly = true;
            // 
            // AppliedAmountInst
            // 
            this.AppliedAmountInst.HeaderText = "Applied Amt.";
            this.AppliedAmountInst.Name = "AppliedAmountInst";
            // 
            // InstallmentWaived
            // 
            this.InstallmentWaived.HeaderText = "Waived Amt.";
            this.InstallmentWaived.Name = "InstallmentWaived";
            this.InstallmentWaived.ReadOnly = true;
            this.InstallmentWaived.Visible = false;
            // 
            // InstallmentID
            // 
            this.InstallmentID.HeaderText = "ID";
            this.InstallmentID.Name = "InstallmentID";
            this.InstallmentID.ReadOnly = true;
            this.InstallmentID.Visible = false;
            // 
            // ApplyInstallment
            // 
            this.ApplyInstallment.HeaderText = "Apply";
            this.ApplyInstallment.Name = "ApplyInstallment";
            this.ApplyInstallment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ApplyInstallment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // OApplyInstallment
            // 
            this.OApplyInstallment.HeaderText = "OApplyInstallment";
            this.OApplyInstallment.Name = "OApplyInstallment";
            this.OApplyInstallment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OApplyInstallment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OApplyInstallment.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 70);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 227;
            this.label19.Text = "Project No.";
            // 
            // cmbProjects
            // 
            this.cmbProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Location = new System.Drawing.Point(100, 66);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(174, 21);
            this.cmbProjects.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 229;
            this.label1.Text = "Receipt Number";
            // 
            // txtReceiptNumber
            // 
            this.txtReceiptNumber.Location = new System.Drawing.Point(100, 112);
            this.txtReceiptNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtReceiptNumber.MaxLength = 50;
            this.txtReceiptNumber.Name = "txtReceiptNumber";
            this.txtReceiptNumber.ReadOnly = true;
            this.txtReceiptNumber.Size = new System.Drawing.Size(174, 20);
            this.txtReceiptNumber.TabIndex = 4;
            // 
            // dtpReceived
            // 
            this.dtpReceived.CustomFormat = "dd/MM/yyy";
            this.dtpReceived.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReceived.Location = new System.Drawing.Point(413, 112);
            this.dtpReceived.Name = "dtpReceived";
            this.dtpReceived.Size = new System.Drawing.Size(174, 20);
            this.dtpReceived.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 231;
            this.label3.Text = "Receipt Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 233;
            this.label4.Text = "Receipt Date";
            // 
            // txtReceiptAmount
            // 
            this.txtReceiptAmount.Location = new System.Drawing.Point(100, 162);
            this.txtReceiptAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtReceiptAmount.MaxLength = 50;
            this.txtReceiptAmount.Name = "txtReceiptAmount";
            this.txtReceiptAmount.Size = new System.Drawing.Size(174, 20);
            this.txtReceiptAmount.TabIndex = 6;
            this.txtReceiptAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numerictextBox_KeyPress);
            this.txtReceiptAmount.Leave += new System.EventHandler(this.txtReceiptAmount_Leave);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(592, 306);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 45);
            this.btnApply.TabIndex = 234;
            this.btnApply.Text = "Apply...";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // cmbReceiptMode
            // 
            this.cmbReceiptMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReceiptMode.FormattingEnabled = true;
            this.cmbReceiptMode.Items.AddRange(new object[] {
            "Cash",
            "Check",
            "Pay Order",
            "Online",
            "Adjustment",
            "Other"});
            this.cmbReceiptMode.Location = new System.Drawing.Point(413, 162);
            this.cmbReceiptMode.Name = "cmbReceiptMode";
            this.cmbReceiptMode.Size = new System.Drawing.Size(174, 21);
            this.cmbReceiptMode.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 236;
            this.label5.Text = "Receipt Mode";
            // 
            // txtInstrumentNo
            // 
            this.txtInstrumentNo.Location = new System.Drawing.Point(100, 208);
            this.txtInstrumentNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtInstrumentNo.MaxLength = 50;
            this.txtInstrumentNo.Name = "txtInstrumentNo";
            this.txtInstrumentNo.Size = new System.Drawing.Size(174, 20);
            this.txtInstrumentNo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 237;
            this.label6.Text = "Instrument No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 240;
            this.label7.Text = "Instrument Date";
            // 
            // dtpInstrument
            // 
            this.dtpInstrument.CustomFormat = "dd/MM/yyy";
            this.dtpInstrument.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInstrument.Location = new System.Drawing.Point(413, 208);
            this.dtpInstrument.Name = "dtpInstrument";
            this.dtpInstrument.Size = new System.Drawing.Size(174, 20);
            this.dtpInstrument.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 235);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 242;
            this.label8.Text = "Drawn Bank";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 235);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 244;
            this.label9.Text = "Drawn Branch";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 260);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 246;
            this.label10.Text = "Deposit Bank";
            // 
            // cmbDepositBank
            // 
            this.cmbDepositBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepositBank.FormattingEnabled = true;
            this.cmbDepositBank.Location = new System.Drawing.Point(100, 256);
            this.cmbDepositBank.Name = "cmbDepositBank";
            this.cmbDepositBank.Size = new System.Drawing.Size(174, 21);
            this.cmbDepositBank.TabIndex = 14;
            this.cmbDepositBank.SelectedIndexChanged += new System.EventHandler(this.cmbDepositBank_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(314, 260);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 248;
            this.label11.Text = "Deposit Account";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(314, 284);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 252;
            this.label12.Text = "Deposit Date";
            // 
            // txtDepositBy
            // 
            this.txtDepositBy.Location = new System.Drawing.Point(100, 281);
            this.txtDepositBy.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepositBy.MaxLength = 50;
            this.txtDepositBy.Name = "txtDepositBy";
            this.txtDepositBy.Size = new System.Drawing.Size(174, 20);
            this.txtDepositBy.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 285);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 250;
            this.label13.Text = "Deposit By";
            // 
            // dtpDeposit
            // 
            this.dtpDeposit.CustomFormat = "dd/MM/yyy";
            this.dtpDeposit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeposit.Location = new System.Drawing.Point(413, 280);
            this.dtpDeposit.Name = "dtpDeposit";
            this.dtpDeposit.Size = new System.Drawing.Size(174, 20);
            this.dtpDeposit.TabIndex = 17;
            // 
            // dtpClearance
            // 
            this.dtpClearance.CustomFormat = "dd/MM/yyy";
            this.dtpClearance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpClearance.Location = new System.Drawing.Point(413, 306);
            this.dtpClearance.Name = "dtpClearance";
            this.dtpClearance.Size = new System.Drawing.Size(174, 20);
            this.dtpClearance.TabIndex = 18;
            this.dtpClearance.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(314, 310);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 252;
            this.label14.Text = "Clearance Date";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(100, 331);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemarks.MaxLength = 100;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(487, 20);
            this.txtRemarks.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 331);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 253;
            this.label15.Text = "Remarks";
            // 
            // txtAppliedAmount
            // 
            this.txtAppliedAmount.Location = new System.Drawing.Point(100, 186);
            this.txtAppliedAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAppliedAmount.MaxLength = 50;
            this.txtAppliedAmount.Name = "txtAppliedAmount";
            this.txtAppliedAmount.ReadOnly = true;
            this.txtAppliedAmount.Size = new System.Drawing.Size(174, 20);
            this.txtAppliedAmount.TabIndex = 8;
            this.txtAppliedAmount.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 190);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 13);
            this.label16.TabIndex = 255;
            this.label16.Text = "Applied Amount";
            // 
            // txtRemainingAmount
            // 
            this.txtRemainingAmount.Location = new System.Drawing.Point(413, 186);
            this.txtRemainingAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemainingAmount.MaxLength = 50;
            this.txtRemainingAmount.Name = "txtRemainingAmount";
            this.txtRemainingAmount.ReadOnly = true;
            this.txtRemainingAmount.Size = new System.Drawing.Size(174, 20);
            this.txtRemainingAmount.TabIndex = 9;
            this.txtRemainingAmount.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(314, 190);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 13);
            this.label17.TabIndex = 257;
            this.label17.Text = "Remaining Amount";
            // 
            // txtDepositAcc
            // 
            this.txtDepositAcc.Location = new System.Drawing.Point(413, 256);
            this.txtDepositAcc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepositAcc.MaxLength = 50;
            this.txtDepositAcc.Name = "txtDepositAcc";
            this.txtDepositAcc.ReadOnly = true;
            this.txtDepositAcc.Size = new System.Drawing.Size(174, 20);
            this.txtDepositAcc.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 308);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 13);
            this.label18.TabIndex = 259;
            this.label18.Text = "Clearance Status";
            // 
            // cmbClearanceStatus
            // 
            this.cmbClearanceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClearanceStatus.FormattingEnabled = true;
            this.cmbClearanceStatus.Items.AddRange(new object[] {
            "Cleared",
            "Not Cleared",
            "Bounced"});
            this.cmbClearanceStatus.Location = new System.Drawing.Point(100, 304);
            this.cmbClearanceStatus.Name = "cmbClearanceStatus";
            this.cmbClearanceStatus.Size = new System.Drawing.Size(174, 21);
            this.cmbClearanceStatus.TabIndex = 258;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(631, 95);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 13);
            this.label20.TabIndex = 261;
            this.label20.Text = "Father Name";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(703, 92);
            this.txtFatherName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFatherName.MaxLength = 50;
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(174, 20);
            this.txtFatherName.TabIndex = 260;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(100, 137);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccount.MaxLength = 100;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(487, 20);
            this.txtAccount.TabIndex = 262;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 141);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 13);
            this.label21.TabIndex = 263;
            this.label21.Text = "On Account of";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(631, 65);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 13);
            this.label22.TabIndex = 265;
            this.label22.Text = "Plot Size";
            // 
            // txtPlotSize
            // 
            this.txtPlotSize.Location = new System.Drawing.Point(703, 62);
            this.txtPlotSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlotSize.MaxLength = 50;
            this.txtPlotSize.Name = "txtPlotSize";
            this.txtPlotSize.Size = new System.Drawing.Size(174, 20);
            this.txtPlotSize.TabIndex = 264;
            // 
            // txtDraweeBank
            // 
            this.txtDraweeBank.Location = new System.Drawing.Point(100, 232);
            this.txtDraweeBank.Margin = new System.Windows.Forms.Padding(2);
            this.txtDraweeBank.MaxLength = 50;
            this.txtDraweeBank.Name = "txtDraweeBank";
            this.txtDraweeBank.Size = new System.Drawing.Size(174, 20);
            this.txtDraweeBank.TabIndex = 16;
            // 
            // txtDraweeBranch
            // 
            this.txtDraweeBranch.Location = new System.Drawing.Point(413, 233);
            this.txtDraweeBranch.Margin = new System.Windows.Forms.Padding(2);
            this.txtDraweeBranch.MaxLength = 50;
            this.txtDraweeBranch.Name = "txtDraweeBranch";
            this.txtDraweeBranch.Size = new System.Drawing.Size(174, 20);
            this.txtDraweeBranch.TabIndex = 16;
            // 
            // txtPlotCategory
            // 
            this.txtPlotCategory.Location = new System.Drawing.Point(703, 140);
            this.txtPlotCategory.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlotCategory.MaxLength = 50;
            this.txtPlotCategory.Name = "txtPlotCategory";
            this.txtPlotCategory.Size = new System.Drawing.Size(174, 20);
            this.txtPlotCategory.TabIndex = 266;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(631, 143);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 13);
            this.label23.TabIndex = 267;
            this.label23.Text = "Plot Category";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(631, 119);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 13);
            this.label24.TabIndex = 269;
            this.label24.Text = "Unit ID";
            // 
            // txtUnitID
            // 
            this.txtUnitID.Location = new System.Drawing.Point(703, 116);
            this.txtUnitID.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnitID.MaxLength = 50;
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.Size = new System.Drawing.Size(174, 20);
            this.txtUnitID.TabIndex = 268;
            // 
            // frmReceiptEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 648);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtUnitID);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtPlotCategory);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtPlotSize);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmbClearanceStatus);
            this.Controls.Add(this.txtRemainingAmount);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtAppliedAmount);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDraweeBranch);
            this.Controls.Add(this.txtDraweeBank);
            this.Controls.Add(this.txtDepositBy);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpClearance);
            this.Controls.Add(this.dtpDeposit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbDepositBank);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpInstrument);
            this.Controls.Add(this.txtInstrumentNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbReceiptMode);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReceiptAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpReceived);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReceiptNumber);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cmbProjects);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.txtDepositAcc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnSelectRegistration);
            this.Controls.Add(this.txtRegistrationNo);
            this.Controls.Add(this.label52);
            this.Name = "frmReceiptEntry";
            this.Text = "Receipt Entry";
            this.Load += new System.EventHandler(this.frmReceiptEntry_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInstallmentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectRegistration;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgInstallmentList;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbProjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReceiptNumber;
        private System.Windows.Forms.DateTimePicker dtpReceived;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReceiptAmount;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox cmbReceiptMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInstrumentNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpInstrument;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbDepositBank;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDepositBy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpDeposit;
        private System.Windows.Forms.DateTimePicker dtpClearance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAppliedAmount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRemainingAmount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDepositAcc;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbClearanceStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallmentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallmentRecoveryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallmentDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallmentDueAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallmentOutStanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallmentReceivedAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalWaivedInst;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppliedAmountInst;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallmentWaived;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallmentID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ApplyInstallment;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OApplyInstallment;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtPlotSize;
        private System.Windows.Forms.TextBox txtDraweeBank;
        private System.Windows.Forms.TextBox txtDraweeBranch;
        private System.Windows.Forms.TextBox txtPlotCategory;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtUnitID;
        private System.Windows.Forms.ToolStripButton tsbAttach;
    }
}