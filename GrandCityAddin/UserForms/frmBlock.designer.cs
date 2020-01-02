namespace TMR.GP.GrandCityAddon
{
    partial class frmBlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBlock));
            this.dgBlockList = new System.Windows.Forms.DataGridView();
            this.BlockNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOMid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DecArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbProjectID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBlockno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBlockname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUoM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalArea = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDevArea = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgBlockList)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgBlockList
            // 
            this.dgBlockList.AllowUserToAddRows = false;
            this.dgBlockList.AllowUserToDeleteRows = false;
            this.dgBlockList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBlockList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgBlockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBlockList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BlockNo,
            this.BlockName,
            this.ProjectNo,
            this.UOMid,
            this.TotalArea,
            this.DecArea,
            this.ID1});
            this.dgBlockList.Location = new System.Drawing.Point(9, 226);
            this.dgBlockList.Margin = new System.Windows.Forms.Padding(2);
            this.dgBlockList.Name = "dgBlockList";
            this.dgBlockList.ReadOnly = true;
            this.dgBlockList.RowTemplate.Height = 24;
            this.dgBlockList.Size = new System.Drawing.Size(584, 232);
            this.dgBlockList.TabIndex = 16;
            this.dgBlockList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgBlockList_CellClick);
            // 
            // BlockNo
            // 
            this.BlockNo.FillWeight = 50.76143F;
            this.BlockNo.HeaderText = "Sector/Floor";
            this.BlockNo.Name = "BlockNo";
            this.BlockNo.ReadOnly = true;
            // 
            // BlockName
            // 
            this.BlockName.FillWeight = 149.2386F;
            this.BlockName.HeaderText = "Name";
            this.BlockName.Name = "BlockName";
            this.BlockName.ReadOnly = true;
            // 
            // ProjectNo
            // 
            this.ProjectNo.HeaderText = "Project ID";
            this.ProjectNo.Name = "ProjectNo";
            this.ProjectNo.ReadOnly = true;
            // 
            // UOMid
            // 
            this.UOMid.HeaderText = "UOM";
            this.UOMid.Name = "UOMid";
            this.UOMid.ReadOnly = true;
            this.UOMid.Visible = false;
            // 
            // TotalArea
            // 
            this.TotalArea.HeaderText = "TotalArea";
            this.TotalArea.Name = "TotalArea";
            this.TotalArea.ReadOnly = true;
            this.TotalArea.Visible = false;
            // 
            // DecArea
            // 
            this.DecArea.HeaderText = "DecArea";
            this.DecArea.Name = "DecArea";
            this.DecArea.ReadOnly = true;
            this.DecArea.Visible = false;
            // 
            // ID1
            // 
            this.ID1.HeaderText = "ID1";
            this.ID1.Name = "ID1";
            this.ID1.ReadOnly = true;
            this.ID1.Visible = false;
            // 
            // cmbProjectID
            // 
            this.cmbProjectID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjectID.FormattingEnabled = true;
            this.cmbProjectID.Location = new System.Drawing.Point(83, 87);
            this.cmbProjectID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProjectID.Name = "cmbProjectID";
            this.cmbProjectID.Size = new System.Drawing.Size(247, 21);
            this.cmbProjectID.TabIndex = 0;
            this.cmbProjectID.SelectedIndexChanged += new System.EventHandler(this.cmbProjectID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sector/Floor";
            // 
            // txtBlockno
            // 
            this.txtBlockno.Location = new System.Drawing.Point(83, 109);
            this.txtBlockno.Margin = new System.Windows.Forms.Padding(2);
            this.txtBlockno.MaxLength = 50;
            this.txtBlockno.Name = "txtBlockno";
            this.txtBlockno.Size = new System.Drawing.Size(247, 20);
            this.txtBlockno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Project ID";
            // 
            // txtBlockname
            // 
            this.txtBlockname.Location = new System.Drawing.Point(83, 131);
            this.txtBlockname.Margin = new System.Windows.Forms.Padding(2);
            this.txtBlockname.MaxLength = 100;
            this.txtBlockname.Name = "txtBlockname";
            this.txtBlockname.Size = new System.Drawing.Size(247, 20);
            this.txtBlockname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Unit of M";
            // 
            // cmbUoM
            // 
            this.cmbUoM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUoM.FormattingEnabled = true;
            this.cmbUoM.Location = new System.Drawing.Point(83, 156);
            this.cmbUoM.Name = "cmbUoM";
            this.cmbUoM.Size = new System.Drawing.Size(246, 21);
            this.cmbUoM.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Total Area";
            // 
            // txtTotalArea
            // 
            this.txtTotalArea.Location = new System.Drawing.Point(83, 180);
            this.txtTotalArea.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalArea.MaxLength = 50;
            this.txtTotalArea.Name = "txtTotalArea";
            this.txtTotalArea.Size = new System.Drawing.Size(247, 20);
            this.txtTotalArea.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Dev. Area";
            // 
            // txtDevArea
            // 
            this.txtDevArea.Location = new System.Drawing.Point(83, 202);
            this.txtDevArea.Margin = new System.Windows.Forms.Padding(2);
            this.txtDevArea.MaxLength = 100;
            this.txtDevArea.Name = "txtDevArea";
            this.txtDevArea.Size = new System.Drawing.Size(247, 20);
            this.txtDevArea.TabIndex = 5;
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
            this.toolStrip2.Size = new System.Drawing.Size(599, 60);
            this.toolStrip2.TabIndex = 6;
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
            // frmBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 462);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalArea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDevArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbUoM);
            this.Controls.Add(this.cmbProjectID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBlockno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBlockname);
            this.Controls.Add(this.dgBlockList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBlock";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Block/Sector/Floor Info";
            this.Load += new System.EventHandler(this.frmBlock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBlockList)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBlockList;
        private System.Windows.Forms.ComboBox cmbProjectID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBlockno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBlockname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUoM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDevArea;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UOMid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn DecArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
    }
}