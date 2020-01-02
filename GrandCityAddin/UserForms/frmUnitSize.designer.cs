namespace TMR.GP.GrandCityAddon
{
    partial class frmUnitSize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnitSize));
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitSizeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.cmbUoM = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCurrentNumber = new System.Windows.Forms.TextBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.cmbProjectID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(82, 91);
            this.txtID.MaxLength = 50;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(247, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 113);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(247, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Project,
            this.UnitSizeCode,
            this.Description,
            this.Area,
            this.UoM,
            this.Prefix,
            this.CurrentNumber,
            this.ID1});
            this.dgList.Location = new System.Drawing.Point(10, 226);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.Size = new System.Drawing.Size(598, 221);
            this.dgList.TabIndex = 6;
            this.dgList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgList_RowHeaderMouseDoubleClick);
            // 
            // Project
            // 
            this.Project.HeaderText = "Project";
            this.Project.Name = "Project";
            this.Project.ReadOnly = true;
            // 
            // UnitSizeCode
            // 
            this.UnitSizeCode.FillWeight = 50.76142F;
            this.UnitSizeCode.HeaderText = "Code";
            this.UnitSizeCode.Name = "UnitSizeCode";
            this.UnitSizeCode.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.FillWeight = 149.2386F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Area
            // 
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // UoM
            // 
            this.UoM.HeaderText = "UoM";
            this.UoM.Name = "UoM";
            this.UoM.ReadOnly = true;
            // 
            // Prefix
            // 
            this.Prefix.HeaderText = "Prefix";
            this.Prefix.Name = "Prefix";
            this.Prefix.ReadOnly = true;
            // 
            // CurrentNumber
            // 
            this.CurrentNumber.HeaderText = "Current No";
            this.CurrentNumber.Name = "CurrentNumber";
            this.CurrentNumber.ReadOnly = true;
            // 
            // ID1
            // 
            this.ID1.HeaderText = "ID";
            this.ID1.Name = "ID1";
            this.ID1.ReadOnly = true;
            this.ID1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Area";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(82, 134);
            this.txtArea.MaxLength = 100;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(247, 20);
            this.txtArea.TabIndex = 2;
            // 
            // cmbUoM
            // 
            this.cmbUoM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUoM.FormattingEnabled = true;
            this.cmbUoM.Location = new System.Drawing.Point(82, 155);
            this.cmbUoM.Name = "cmbUoM";
            this.cmbUoM.Size = new System.Drawing.Size(246, 21);
            this.cmbUoM.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Unit of M";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Current No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Prefix";
            // 
            // txtCurrentNumber
            // 
            this.txtCurrentNumber.Location = new System.Drawing.Point(82, 200);
            this.txtCurrentNumber.MaxLength = 100;
            this.txtCurrentNumber.Name = "txtCurrentNumber";
            this.txtCurrentNumber.Size = new System.Drawing.Size(247, 20);
            this.txtCurrentNumber.TabIndex = 5;
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(82, 179);
            this.txtPrefix.MaxLength = 5;
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(247, 20);
            this.txtPrefix.TabIndex = 4;
            // 
            // cmbProjectID
            // 
            this.cmbProjectID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjectID.FormattingEnabled = true;
            this.cmbProjectID.Location = new System.Drawing.Point(82, 68);
            this.cmbProjectID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProjectID.Name = "cmbProjectID";
            this.cmbProjectID.Size = new System.Drawing.Size(247, 21);
            this.cmbProjectID.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Project ID";
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(613, 60);
            this.toolStrip2.TabIndex = 19;
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
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(43, 57);
            this.toolStripButton1.Text = "Clear";
            this.toolStripButton1.Click += new System.EventHandler(this.tsbClear_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(43, 57);
            this.toolStripButton2.Text = "Close";
            this.toolStripButton2.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // frmUnitSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 459);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.cmbProjectID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCurrentNumber);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbUoM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUnitSize";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Size Code";
            this.Load += new System.EventHandler(this.frmProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.ComboBox cmbUoM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCurrentNumber;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.ComboBox cmbProjectID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitSizeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn UoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}