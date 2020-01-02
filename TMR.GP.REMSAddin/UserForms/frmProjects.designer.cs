namespace TMR.GP.REMSAddin

{
    partial class frmProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjects));
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.SRNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubProject = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MainProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMainProject = new System.Windows.Forms.ComboBox();
            this.chkBoxSubProject = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBlock = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCurrentNumber = new System.Windows.Forms.TextBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(89, 63);
            this.txtID.MaxLength = 50;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(216, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 84);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project ID.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Project Name";
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
            this.ProjectID,
            this.ProjectName,
            this.SubProject,
            this.MainProjectID,
            this.Location,
            this.Prefix,
            this.CurrentNumber,
            this.ID1});
            this.dgList.Location = new System.Drawing.Point(8, 229);
            this.dgList.Name = "dgList";
            this.dgList.Size = new System.Drawing.Size(686, 263);
            this.dgList.TabIndex = 6;
            this.dgList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgList_RowHeaderMouseDoubleClick);
            // 
            // SRNo
            // 
            this.SRNo.FillWeight = 60.91371F;
            this.SRNo.HeaderText = "Sr No.";
            this.SRNo.Name = "SRNo";
            // 
            // ProjectID
            // 
            this.ProjectID.FillWeight = 53.59581F;
            this.ProjectID.HeaderText = "Project ID";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.ReadOnly = true;
            // 
            // ProjectName
            // 
            this.ProjectName.FillWeight = 157.5717F;
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // SubProject
            // 
            this.SubProject.FillWeight = 105.5837F;
            this.SubProject.HeaderText = "Sub Project";
            this.SubProject.Name = "SubProject";
            this.SubProject.ReadOnly = true;
            // 
            // MainProjectID
            // 
            this.MainProjectID.FillWeight = 105.5837F;
            this.MainProjectID.HeaderText = "Main Project";
            this.MainProjectID.Name = "MainProjectID";
            this.MainProjectID.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.FillWeight = 105.5837F;
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // Prefix
            // 
            this.Prefix.FillWeight = 105.5837F;
            this.Prefix.HeaderText = "Prefix";
            this.Prefix.Name = "Prefix";
            this.Prefix.ReadOnly = true;
            // 
            // CurrentNumber
            // 
            this.CurrentNumber.FillWeight = 105.5837F;
            this.CurrentNumber.HeaderText = "Current Number";
            this.CurrentNumber.Name = "CurrentNumber";
            this.CurrentNumber.ReadOnly = true;
            // 
            // ID1
            // 
            this.ID1.HeaderText = "ID";
            this.ID1.Name = "ID1";
            this.ID1.Visible = false;
            // 
            // cmbMainProject
            // 
            this.cmbMainProject.Enabled = false;
            this.cmbMainProject.FormattingEnabled = true;
            this.cmbMainProject.Items.AddRange(new object[] {
            "Approved",
            "Unapproved"});
            this.cmbMainProject.Location = new System.Drawing.Point(89, 135);
            this.cmbMainProject.Name = "cmbMainProject";
            this.cmbMainProject.Size = new System.Drawing.Size(216, 21);
            this.cmbMainProject.TabIndex = 190;
            this.cmbMainProject.SelectedIndexChanged += new System.EventHandler(this.cmbMainProject_SelectedIndexChanged);
            // 
            // chkBoxSubProject
            // 
            this.chkBoxSubProject.AutoSize = true;
            this.chkBoxSubProject.Location = new System.Drawing.Point(89, 110);
            this.chkBoxSubProject.Name = "chkBoxSubProject";
            this.chkBoxSubProject.Size = new System.Drawing.Size(81, 17);
            this.chkBoxSubProject.TabIndex = 191;
            this.chkBoxSubProject.Text = "Sub Project";
            this.chkBoxSubProject.UseVisualStyleBackColor = true;
            this.chkBoxSubProject.CheckedChanged += new System.EventHandler(this.chkBoxSubProject_CheckedChanged);
            this.chkBoxSubProject.Click += new System.EventHandler(this.chkBoxSubProject_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 192;
            this.label3.Text = "Main Project";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 193;
            this.label4.Text = "Location";
            // 
            // cmbBlock
            // 
            this.cmbBlock.Enabled = false;
            this.cmbBlock.FormattingEnabled = true;
            this.cmbBlock.Location = new System.Drawing.Point(89, 158);
            this.cmbBlock.Name = "cmbBlock";
            this.cmbBlock.Size = new System.Drawing.Size(216, 21);
            this.cmbBlock.TabIndex = 194;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 198;
            this.label5.Text = "Current No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 197;
            this.label6.Text = "Prefix";
            // 
            // txtCurrentNumber
            // 
            this.txtCurrentNumber.Location = new System.Drawing.Point(89, 203);
            this.txtCurrentNumber.MaxLength = 100;
            this.txtCurrentNumber.Name = "txtCurrentNumber";
            this.txtCurrentNumber.Size = new System.Drawing.Size(216, 20);
            this.txtCurrentNumber.TabIndex = 196;
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(89, 182);
            this.txtPrefix.MaxLength = 5;
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(216, 20);
            this.txtPrefix.TabIndex = 195;
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
            this.toolStrip1.Size = new System.Drawing.Size(695, 60);
            this.toolStrip1.TabIndex = 199;
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
            // frmProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 499);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCurrentNumber);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.cmbBlock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkBoxSubProject);
            this.Controls.Add(this.cmbMainProject);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProjects";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projects";
            this.Load += new System.EventHandler(this.frmProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.ComboBox cmbMainProject;
        private System.Windows.Forms.CheckBox chkBoxSubProject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBlock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCurrentNumber;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SubProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
    }
}