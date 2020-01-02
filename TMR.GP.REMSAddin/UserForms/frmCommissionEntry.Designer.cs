namespace TMR.GP.REMSAddin
{
    partial class frmCommissionEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommissionEntry));
            this.btnSelectRegistration = new System.Windows.Forms.Button();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.label34 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDealerName = new System.Windows.Forms.TextBox();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtNetPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEntryNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
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
            this.btnSelectRegistration.Click += new System.EventHandler(this.btnSelectRegistration_Click);
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
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(629, 60);
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
            this.txtClientID.Location = new System.Drawing.Point(109, 88);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientID.MaxLength = 50;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(174, 20);
            this.txtClientID.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(413, 88);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 20);
            this.txtName.TabIndex = 3;
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
            this.cmbProjects.Location = new System.Drawing.Point(109, 66);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(174, 21);
            this.cmbProjects.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 229;
            this.label1.Text = "Dealer";
            // 
            // txtDealerName
            // 
            this.txtDealerName.Location = new System.Drawing.Point(109, 131);
            this.txtDealerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDealerName.MaxLength = 50;
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Size = new System.Drawing.Size(174, 20);
            this.txtDealerName.TabIndex = 228;
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(109, 174);
            this.txtPercentage.Margin = new System.Windows.Forms.Padding(2);
            this.txtPercentage.MaxLength = 50;
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(174, 20);
            this.txtPercentage.TabIndex = 230;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 231;
            this.label3.Text = "Comm. Percentage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 233;
            this.label4.Text = "Payment Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(413, 176);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmount.MaxLength = 50;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(174, 20);
            this.txtAmount.TabIndex = 232;
            // 
            // txtNetPrice
            // 
            this.txtNetPrice.Location = new System.Drawing.Point(109, 152);
            this.txtNetPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtNetPrice.MaxLength = 50;
            this.txtNetPrice.Name = "txtNetPrice";
            this.txtNetPrice.Size = new System.Drawing.Size(174, 20);
            this.txtNetPrice.TabIndex = 234;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 235;
            this.label5.Text = "Net Price";
            // 
            // txtEntryNumber
            // 
            this.txtEntryNumber.Location = new System.Drawing.Point(109, 109);
            this.txtEntryNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtEntryNumber.MaxLength = 50;
            this.txtEntryNumber.Name = "txtEntryNumber";
            this.txtEntryNumber.Size = new System.Drawing.Size(174, 20);
            this.txtEntryNumber.TabIndex = 236;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 237;
            this.label6.Text = "Entry #";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 239;
            this.label7.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(109, 198);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemarks.MaxLength = 100;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(478, 20);
            this.txtRemarks.TabIndex = 238;
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntryDate.Location = new System.Drawing.Point(413, 109);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(174, 20);
            this.dtpEntryDate.TabIndex = 240;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 241;
            this.label8.Text = "Entry Date";
            // 
            // frmCommissionEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 232);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpEntryDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEntryNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNetPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDealerName);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cmbProjects);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnSelectRegistration);
            this.Controls.Add(this.txtRegistrationNo);
            this.Controls.Add(this.label52);
            this.Name = "frmCommissionEntry";
            this.Text = "Commission Entry";
            this.Load += new System.EventHandler(this.frmCommissionEntry_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbProjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDealerName;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtNetPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEntryNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.Label label8;
    }
}