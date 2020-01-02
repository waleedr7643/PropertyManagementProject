namespace TMR.GP.REMSAddin
{
    partial class frmProspect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProspect));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tsbAttach = new System.Windows.Forms.ToolStripButton();
            this.tsbViewAttachments = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.cmbSector = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUnitSelect = new System.Windows.Forms.Button();
            this.label42 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFather = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.cmbProspectPaymentPlan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSizeCode = new System.Windows.Forms.ComboBox();
            this.ProspectStartDate = new System.Windows.Forms.Label();
            this.dTPProspectStartDate = new System.Windows.Forms.DateTimePicker();
            this.ProspectData = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.ProjectData = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNetPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.txtPlotTypeCharges = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.txtPlotPrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.txtUnitCategory = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.txtChargesPercentage = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.txtUnitType = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.ProspectData.SuspendLayout();
            this.ProjectData.SuspendLayout();
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
            this.tsbAttach,
            this.tsbViewAttachments,
            this.tsbPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(678, 60);
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
            this.tsbAttach.Visible = false;
            // 
            // tsbViewAttachments
            // 
            this.tsbViewAttachments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbViewAttachments.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewAttachments.Image")));
            this.tsbViewAttachments.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbViewAttachments.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewAttachments.Name = "tsbViewAttachments";
            this.tsbViewAttachments.Size = new System.Drawing.Size(39, 57);
            this.tsbViewAttachments.Text = "toolStripButton1";
            this.tsbViewAttachments.Visible = false;
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
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 28);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Project No.";
            // 
            // cmbProjects
            // 
            this.cmbProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Location = new System.Drawing.Point(125, 24);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(174, 21);
            this.cmbProjects.TabIndex = 0;
            this.cmbProjects.SelectedIndexChanged += new System.EventHandler(this.cmbProjects_SelectedIndexChanged);
            // 
            // cmbSector
            // 
            this.cmbSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSector.FormattingEnabled = true;
            this.cmbSector.Location = new System.Drawing.Point(463, 24);
            this.cmbSector.Name = "cmbSector";
            this.cmbSector.Size = new System.Drawing.Size(174, 21);
            this.cmbSector.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(346, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Sector/Floor";
            // 
            // btnUnitSelect
            // 
            this.btnUnitSelect.Location = new System.Drawing.Point(302, 74);
            this.btnUnitSelect.Name = "btnUnitSelect";
            this.btnUnitSelect.Size = new System.Drawing.Size(24, 23);
            this.btnUnitSelect.TabIndex = 10;
            this.btnUnitSelect.Text = "...";
            this.btnUnitSelect.UseVisualStyleBackColor = true;
            this.btnUnitSelect.Click += new System.EventHandler(this.btnUnitSelect_Click);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(8, 77);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(49, 13);
            this.label42.TabIndex = 4;
            this.label42.Text = "Unit/Plot";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(125, 74);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnit.MaxLength = 50;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(174, 20);
            this.txtUnit.TabIndex = 2;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(346, 22);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(68, 13);
            this.label36.TabIndex = 9;
            this.label36.Text = "Father Name";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(8, 23);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(80, 13);
            this.label34.TabIndex = 0;
            this.label34.Text = "Prospect Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 23);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtFather
            // 
            this.txtFather.Location = new System.Drawing.Point(463, 23);
            this.txtFather.Margin = new System.Windows.Forms.Padding(2);
            this.txtFather.MaxLength = 50;
            this.txtFather.Name = "txtFather";
            this.txtFather.Size = new System.Drawing.Size(174, 20);
            this.txtFather.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CNIC";
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(122, 45);
            this.txtCNIC.Margin = new System.Windows.Forms.Padding(2);
            this.txtCNIC.MaxLength = 50;
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(174, 20);
            this.txtCNIC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Contact #";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(463, 45);
            this.txtContact.Margin = new System.Windows.Forms.Padding(2);
            this.txtContact.MaxLength = 50;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(174, 20);
            this.txtContact.TabIndex = 4;
            // 
            // cmbProspectPaymentPlan
            // 
            this.cmbProspectPaymentPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProspectPaymentPlan.FormattingEnabled = true;
            this.cmbProspectPaymentPlan.Location = new System.Drawing.Point(463, 66);
            this.cmbProspectPaymentPlan.Name = "cmbProspectPaymentPlan";
            this.cmbProspectPaymentPlan.Size = new System.Drawing.Size(174, 21);
            this.cmbProspectPaymentPlan.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Payment Plan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 52);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Size Code";
            // 
            // cmbSizeCode
            // 
            this.cmbSizeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSizeCode.FormattingEnabled = true;
            this.cmbSizeCode.Location = new System.Drawing.Point(125, 50);
            this.cmbSizeCode.Name = "cmbSizeCode";
            this.cmbSizeCode.Size = new System.Drawing.Size(174, 21);
            this.cmbSizeCode.TabIndex = 1;
            this.cmbSizeCode.SelectedIndexChanged += new System.EventHandler(this.cmbSizeCode_SelectedIndexChanged);
            // 
            // ProspectStartDate
            // 
            this.ProspectStartDate.AutoSize = true;
            this.ProspectStartDate.Location = new System.Drawing.Point(8, 72);
            this.ProspectStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProspectStartDate.Name = "ProspectStartDate";
            this.ProspectStartDate.Size = new System.Drawing.Size(30, 13);
            this.ProspectStartDate.TabIndex = 4;
            this.ProspectStartDate.Text = "Date";
            // 
            // dTPProspectStartDate
            // 
            this.dTPProspectStartDate.CustomFormat = "dd/MM/yyy";
            this.dTPProspectStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPProspectStartDate.Location = new System.Drawing.Point(122, 68);
            this.dTPProspectStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dTPProspectStartDate.Name = "dTPProspectStartDate";
            this.dTPProspectStartDate.Size = new System.Drawing.Size(174, 20);
            this.dTPProspectStartDate.TabIndex = 2;
            // 
            // ProspectData
            // 
            this.ProspectData.Controls.Add(this.btnSelect);
            this.ProspectData.Controls.Add(this.label34);
            this.ProspectData.Controls.Add(this.txtFather);
            this.ProspectData.Controls.Add(this.dTPProspectStartDate);
            this.ProspectData.Controls.Add(this.txtName);
            this.ProspectData.Controls.Add(this.ProspectStartDate);
            this.ProspectData.Controls.Add(this.cmbProspectPaymentPlan);
            this.ProspectData.Controls.Add(this.label36);
            this.ProspectData.Controls.Add(this.txtCNIC);
            this.ProspectData.Controls.Add(this.label4);
            this.ProspectData.Controls.Add(this.label2);
            this.ProspectData.Controls.Add(this.txtContact);
            this.ProspectData.Controls.Add(this.label1);
            this.ProspectData.Location = new System.Drawing.Point(9, 233);
            this.ProspectData.Margin = new System.Windows.Forms.Padding(2);
            this.ProspectData.Name = "ProspectData";
            this.ProspectData.Padding = new System.Windows.Forms.Padding(2);
            this.ProspectData.Size = new System.Drawing.Size(659, 97);
            this.ProspectData.TabIndex = 0;
            this.ProspectData.TabStop = false;
            this.ProspectData.Text = "Prospect Information";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(302, 23);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(24, 23);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // ProjectData
            // 
            this.ProjectData.Controls.Add(this.label5);
            this.ProjectData.Controls.Add(this.txtNetPrice);
            this.ProjectData.Controls.Add(this.label3);
            this.ProjectData.Controls.Add(this.txtDiscount);
            this.ProjectData.Controls.Add(this.label70);
            this.ProjectData.Controls.Add(this.label19);
            this.ProjectData.Controls.Add(this.txtPlotTypeCharges);
            this.ProjectData.Controls.Add(this.cmbProjects);
            this.ProjectData.Controls.Add(this.label69);
            this.ProjectData.Controls.Add(this.label12);
            this.ProjectData.Controls.Add(this.txtPlotPrice);
            this.ProjectData.Controls.Add(this.label14);
            this.ProjectData.Controls.Add(this.cmbSector);
            this.ProjectData.Controls.Add(this.txtTotalPrice);
            this.ProjectData.Controls.Add(this.label11);
            this.ProjectData.Controls.Add(this.txtUnit);
            this.ProjectData.Controls.Add(this.label72);
            this.ProjectData.Controls.Add(this.cmbSizeCode);
            this.ProjectData.Controls.Add(this.txtUnitCategory);
            this.ProjectData.Controls.Add(this.label42);
            this.ProjectData.Controls.Add(this.label71);
            this.ProjectData.Controls.Add(this.txtChargesPercentage);
            this.ProjectData.Controls.Add(this.btnUnitSelect);
            this.ProjectData.Controls.Add(this.label68);
            this.ProjectData.Controls.Add(this.txtUnitType);
            this.ProjectData.Location = new System.Drawing.Point(9, 63);
            this.ProjectData.Margin = new System.Windows.Forms.Padding(2);
            this.ProjectData.Name = "ProjectData";
            this.ProjectData.Padding = new System.Windows.Forms.Padding(2);
            this.ProjectData.Size = new System.Drawing.Size(659, 167);
            this.ProjectData.TabIndex = 253;
            this.ProjectData.TabStop = false;
            this.ProjectData.Text = "Project Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Net Price:";
            // 
            // txtNetPrice
            // 
            this.txtNetPrice.Location = new System.Drawing.Point(463, 120);
            this.txtNetPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtNetPrice.MaxLength = 18;
            this.txtNetPrice.Name = "txtNetPrice";
            this.txtNetPrice.ReadOnly = true;
            this.txtNetPrice.Size = new System.Drawing.Size(174, 20);
            this.txtNetPrice.TabIndex = 21;
            this.txtNetPrice.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(125, 140);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscount.MaxLength = 50;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(174, 20);
            this.txtDiscount.TabIndex = 19;
            this.txtDiscount.Text = "0.00";
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            this.txtDiscount.Leave += new System.EventHandler(this.txtDiscount_Leave);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(346, 77);
            this.label70.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(97, 13);
            this.label70.TabIndex = 16;
            this.label70.Text = "Plot Type Charges:";
            // 
            // txtPlotTypeCharges
            // 
            this.txtPlotTypeCharges.Location = new System.Drawing.Point(463, 75);
            this.txtPlotTypeCharges.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlotTypeCharges.MaxLength = 18;
            this.txtPlotTypeCharges.Name = "txtPlotTypeCharges";
            this.txtPlotTypeCharges.ReadOnly = true;
            this.txtPlotTypeCharges.Size = new System.Drawing.Size(174, 20);
            this.txtPlotTypeCharges.TabIndex = 7;
            this.txtPlotTypeCharges.Text = "0.00";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(346, 53);
            this.label69.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(55, 13);
            this.label69.TabIndex = 14;
            this.label69.Text = "Plot Price:";
            // 
            // txtPlotPrice
            // 
            this.txtPlotPrice.Location = new System.Drawing.Point(463, 50);
            this.txtPlotPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlotPrice.MaxLength = 18;
            this.txtPlotPrice.Name = "txtPlotPrice";
            this.txtPlotPrice.ReadOnly = true;
            this.txtPlotPrice.Size = new System.Drawing.Size(174, 20);
            this.txtPlotPrice.TabIndex = 6;
            this.txtPlotPrice.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(346, 100);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Total Price:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(463, 97);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalPrice.MaxLength = 18;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(174, 20);
            this.txtTotalPrice.TabIndex = 8;
            this.txtTotalPrice.Text = "0.00";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(346, 145);
            this.label72.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(71, 13);
            this.label72.TabIndex = 10;
            this.label72.Text = "Unit Category";
            // 
            // txtUnitCategory
            // 
            this.txtUnitCategory.Location = new System.Drawing.Point(463, 141);
            this.txtUnitCategory.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnitCategory.MaxLength = 50;
            this.txtUnitCategory.Name = "txtUnitCategory";
            this.txtUnitCategory.ReadOnly = true;
            this.txtUnitCategory.Size = new System.Drawing.Size(174, 20);
            this.txtUnitCategory.TabIndex = 9;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(8, 120);
            this.label71.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(92, 13);
            this.label71.TabIndex = 8;
            this.label71.Text = "Unit Add. Chrgs %";
            // 
            // txtChargesPercentage
            // 
            this.txtChargesPercentage.Location = new System.Drawing.Point(125, 116);
            this.txtChargesPercentage.Margin = new System.Windows.Forms.Padding(2);
            this.txtChargesPercentage.MaxLength = 50;
            this.txtChargesPercentage.Name = "txtChargesPercentage";
            this.txtChargesPercentage.ReadOnly = true;
            this.txtChargesPercentage.Size = new System.Drawing.Size(174, 20);
            this.txtChargesPercentage.TabIndex = 4;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(8, 99);
            this.label68.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(53, 13);
            this.label68.TabIndex = 6;
            this.label68.Text = "Unit Type";
            // 
            // txtUnitType
            // 
            this.txtUnitType.Location = new System.Drawing.Point(125, 95);
            this.txtUnitType.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnitType.MaxLength = 50;
            this.txtUnitType.Name = "txtUnitType";
            this.txtUnitType.ReadOnly = true;
            this.txtUnitType.Size = new System.Drawing.Size(174, 20);
            this.txtUnitType.TabIndex = 3;
            // 
            // frmProspect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 339);
            this.Controls.Add(this.ProjectData);
            this.Controls.Add(this.ProspectData);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProspect";
            this.Text = "Pre Sale / Proposal";
            this.Load += new System.EventHandler(this.frmProspect_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ProspectData.ResumeLayout(false);
            this.ProspectData.PerformLayout();
            this.ProjectData.ResumeLayout(false);
            this.ProjectData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbAttach;
        private System.Windows.Forms.ToolStripButton tsbViewAttachments;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbProjects;
        private System.Windows.Forms.ComboBox cmbSector;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUnitSelect;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFather;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.ComboBox cmbProspectPaymentPlan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSizeCode;
        private System.Windows.Forms.Label ProspectStartDate;
        private System.Windows.Forms.DateTimePicker dTPProspectStartDate;
        private System.Windows.Forms.GroupBox ProspectData;
        private System.Windows.Forms.GroupBox ProjectData;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TextBox txtUnitCategory;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TextBox txtChargesPercentage;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TextBox txtUnitType;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.TextBox txtPlotTypeCharges;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox txtPlotPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNetPrice;

    }
}