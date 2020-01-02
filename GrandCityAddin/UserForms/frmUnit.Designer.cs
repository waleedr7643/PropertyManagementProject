namespace TMR.GP.GrandCityAddon
{
    partial class frmUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnit));
            this.cmbProjectID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBlockID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnitID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStreetNo = new System.Windows.Forms.TextBox();
            this.cmbUnitCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUnitType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlotNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPlotNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUom = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.cmbSizeCode = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbProjectID
            // 
            this.cmbProjectID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjectID.FormattingEnabled = true;
            this.cmbProjectID.Location = new System.Drawing.Point(81, 78);
            this.cmbProjectID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProjectID.Name = "cmbProjectID";
            this.cmbProjectID.Size = new System.Drawing.Size(247, 21);
            this.cmbProjectID.TabIndex = 1;
            this.cmbProjectID.SelectedIndexChanged += new System.EventHandler(this.cmbProjectID_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Project ID";
            // 
            // cmbBlockID
            // 
            this.cmbBlockID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlockID.FormattingEnabled = true;
            this.cmbBlockID.Location = new System.Drawing.Point(422, 78);
            this.cmbBlockID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBlockID.Name = "cmbBlockID";
            this.cmbBlockID.Size = new System.Drawing.Size(247, 21);
            this.cmbBlockID.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Block ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Unit ID";
            // 
            // txtUnitID
            // 
            this.txtUnitID.Location = new System.Drawing.Point(81, 124);
            this.txtUnitID.MaxLength = 100;
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.Size = new System.Drawing.Size(247, 20);
            this.txtUnitID.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Aisle/Street";
            // 
            // txtStreetNo
            // 
            this.txtStreetNo.Location = new System.Drawing.Point(81, 148);
            this.txtStreetNo.MaxLength = 100;
            this.txtStreetNo.Name = "txtStreetNo";
            this.txtStreetNo.Size = new System.Drawing.Size(247, 20);
            this.txtStreetNo.TabIndex = 3;
            // 
            // cmbUnitCategory
            // 
            this.cmbUnitCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitCategory.FormattingEnabled = true;
            this.cmbUnitCategory.Location = new System.Drawing.Point(422, 124);
            this.cmbUnitCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUnitCategory.Name = "cmbUnitCategory";
            this.cmbUnitCategory.Size = new System.Drawing.Size(247, 21);
            this.cmbUnitCategory.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Unit Category";
            // 
            // cmbUnitType
            // 
            this.cmbUnitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitType.FormattingEnabled = true;
            this.cmbUnitType.Location = new System.Drawing.Point(422, 148);
            this.cmbUnitType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUnitType.Name = "cmbUnitType";
            this.cmbUnitType.Size = new System.Drawing.Size(247, 21);
            this.cmbUnitType.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Unit Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Length";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(227, 193);
            this.txtLength.MaxLength = 100;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(63, 20);
            this.txtLength.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Width";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(81, 193);
            this.txtWidth.MaxLength = 100;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(64, 20);
            this.txtWidth.TabIndex = 5;
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectID,
            this.Price,
            this.BlockID,
            this.UnitID,
            this.Street,
            this.PlotNo,
            this.UnitTypeID,
            this.UnitCategoryID,
            this.SizeCode,
            this.Area,
            this.UomID,
            this.Width,
            this.Length,
            this.RegistrationNo,
            this.Status,
            this.ID1});
            this.dgList.Location = new System.Drawing.Point(8, 241);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.Size = new System.Drawing.Size(691, 304);
            this.dgList.TabIndex = 49;
            this.dgList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgList_RowHeaderMouseDoubleClick);
            // 
            // ProjectID
            // 
            this.ProjectID.HeaderText = "Project";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Visible = false;
            // 
            // BlockID
            // 
            this.BlockID.HeaderText = "Block";
            this.BlockID.Name = "BlockID";
            this.BlockID.ReadOnly = true;
            // 
            // UnitID
            // 
            this.UnitID.HeaderText = "Unit ID";
            this.UnitID.Name = "UnitID";
            this.UnitID.ReadOnly = true;
            // 
            // Street
            // 
            this.Street.HeaderText = "Street";
            this.Street.Name = "Street";
            this.Street.ReadOnly = true;
            // 
            // PlotNo
            // 
            this.PlotNo.HeaderText = "PlotNo";
            this.PlotNo.Name = "PlotNo";
            this.PlotNo.ReadOnly = true;
            // 
            // UnitTypeID
            // 
            this.UnitTypeID.HeaderText = "Unit Type";
            this.UnitTypeID.Name = "UnitTypeID";
            this.UnitTypeID.ReadOnly = true;
            // 
            // UnitCategoryID
            // 
            this.UnitCategoryID.HeaderText = "Unit Category";
            this.UnitCategoryID.Name = "UnitCategoryID";
            this.UnitCategoryID.ReadOnly = true;
            // 
            // SizeCode
            // 
            this.SizeCode.HeaderText = "Size Code";
            this.SizeCode.Name = "SizeCode";
            this.SizeCode.ReadOnly = true;
            // 
            // Area
            // 
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // UomID
            // 
            this.UomID.HeaderText = "UoM";
            this.UomID.Name = "UomID";
            this.UomID.ReadOnly = true;
            // 
            // Width
            // 
            this.Width.HeaderText = "Width";
            this.Width.Name = "Width";
            this.Width.ReadOnly = true;
            // 
            // Length
            // 
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            // 
            // RegistrationNo
            // 
            this.RegistrationNo.HeaderText = "Registration No";
            this.RegistrationNo.Name = "RegistrationNo";
            this.RegistrationNo.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // ID1
            // 
            this.ID1.HeaderText = "ID";
            this.ID1.Name = "ID1";
            this.ID1.ReadOnly = true;
            this.ID1.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(340, 174);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Registration No";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(150, 197);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "(ft)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(295, 197);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "(ft)";
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.Location = new System.Drawing.Point(422, 171);
            this.txtRegistrationNo.MaxLength = 100;
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.ReadOnly = true;
            this.txtRegistrationNo.Size = new System.Drawing.Size(247, 20);
            this.txtRegistrationNo.TabIndex = 13;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(422, 192);
            this.txtStatus.MaxLength = 100;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(247, 20);
            this.txtStatus.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(340, 196);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 56;
            this.label15.Text = "Status";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(81, 215);
            this.txtPrice.MaxLength = 100;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(247, 20);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 217);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 58;
            this.label16.Text = "Price";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 173);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 59;
            this.label17.Text = "Shop/Plot";
            // 
            // txtPlotNo
            // 
            this.txtPlotNo.Location = new System.Drawing.Point(81, 171);
            this.txtPlotNo.MaxLength = 100;
            this.txtPlotNo.Name = "txtPlotNo";
            this.txtPlotNo.Size = new System.Drawing.Size(247, 20);
            this.txtPlotNo.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(533, 107);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "UoM";
            // 
            // txtUom
            // 
            this.txtUom.Location = new System.Drawing.Point(568, 102);
            this.txtUom.MaxLength = 100;
            this.txtUom.Name = "txtUom";
            this.txtUom.ReadOnly = true;
            this.txtUom.Size = new System.Drawing.Size(101, 20);
            this.txtUom.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(340, 105);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Area";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(422, 101);
            this.txtArea.MaxLength = 100;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(101, 20);
            this.txtArea.TabIndex = 62;
            // 
            // cmbSizeCode
            // 
            this.cmbSizeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSizeCode.FormattingEnabled = true;
            this.cmbSizeCode.Location = new System.Drawing.Point(81, 101);
            this.cmbSizeCode.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSizeCode.Name = "cmbSizeCode";
            this.cmbSizeCode.Size = new System.Drawing.Size(247, 21);
            this.cmbSizeCode.TabIndex = 61;
            this.cmbSizeCode.SelectedIndexChanged += new System.EventHandler(this.cmbSizeCode_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Size Code";
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbClear,
            this.tsbCancel});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(707, 60);
            this.toolStrip2.TabIndex = 218;
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
            this.tsbSave.Click += new System.EventHandler(this.btnAdd_Click);
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
            // tsbCancel
            // 
            this.tsbCancel.AutoSize = false;
            this.tsbCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(43, 57);
            this.tsbCancel.Text = "Close";
            this.tsbCancel.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // frmUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 551);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUom);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.cmbSizeCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPlotNo);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtRegistrationNo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.cmbUnitType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbUnitCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStreetNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUnitID);
            this.Controls.Add(this.cmbBlockID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProjectID);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmUnit";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Define Unit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUnit_FormClosing);
            this.Load += new System.EventHandler(this.frmUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProjectID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBlockID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnitID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStreetNo;
        private System.Windows.Forms.ComboBox cmbUnitCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbUnitType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPlotNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlotNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn UomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.ComboBox cmbSizeCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbCancel;
    }
}