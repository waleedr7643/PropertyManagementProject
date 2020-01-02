namespace TMR.GP.REMSAddin
{
    partial class frmRecoveryTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecoveryTypes));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.SRNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncludeInTotal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DueMonthly = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.chkDueMonthly = new System.Windows.Forms.CheckBox();
            this.chkIncludeTotal = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 67);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(90, 89);
            this.txtCNIC.MaxLength = 100;
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(192, 20);
            this.txtCNIC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Recovery Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description";
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
            this.Code,
            this.Desc,
            this.ID1,
            this.IncludeInTotal,
            this.DueMonthly});
            this.dgList.Location = new System.Drawing.Point(8, 138);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.Size = new System.Drawing.Size(492, 243);
            this.dgList.TabIndex = 7;
            this.dgList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgList_RowHeaderMouseDoubleClick);
            // 
            // SRNo
            // 
            this.SRNo.FillWeight = 88.8325F;
            this.SRNo.HeaderText = "SR No.";
            this.SRNo.Name = "SRNo";
            this.SRNo.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.FillWeight = 88.70366F;
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // Desc
            // 
            this.Desc.FillWeight = 116.8801F;
            this.Desc.HeaderText = "Description";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            // 
            // ID1
            // 
            this.ID1.HeaderText = "ID";
            this.ID1.Name = "ID1";
            this.ID1.ReadOnly = true;
            this.ID1.Visible = false;
            // 
            // IncludeInTotal
            // 
            this.IncludeInTotal.FillWeight = 102.7919F;
            this.IncludeInTotal.HeaderText = "Include In Total";
            this.IncludeInTotal.Name = "IncludeInTotal";
            this.IncludeInTotal.ReadOnly = true;
            this.IncludeInTotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IncludeInTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DueMonthly
            // 
            this.DueMonthly.FillWeight = 102.7919F;
            this.DueMonthly.HeaderText = "Due Monthly";
            this.DueMonthly.Name = "DueMonthly";
            this.DueMonthly.ReadOnly = true;
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
            this.toolStrip2.Size = new System.Drawing.Size(512, 60);
            this.toolStrip2.TabIndex = 200;
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
            // chkDueMonthly
            // 
            this.chkDueMonthly.AutoSize = true;
            this.chkDueMonthly.Location = new System.Drawing.Point(90, 115);
            this.chkDueMonthly.Name = "chkDueMonthly";
            this.chkDueMonthly.Size = new System.Drawing.Size(86, 17);
            this.chkDueMonthly.TabIndex = 201;
            this.chkDueMonthly.Text = "Due Monthly";
            this.chkDueMonthly.UseVisualStyleBackColor = true;
            // 
            // chkIncludeTotal
            // 
            this.chkIncludeTotal.AutoSize = true;
            this.chkIncludeTotal.Location = new System.Drawing.Point(182, 115);
            this.chkIncludeTotal.Name = "chkIncludeTotal";
            this.chkIncludeTotal.Size = new System.Drawing.Size(100, 17);
            this.chkIncludeTotal.TabIndex = 202;
            this.chkIncludeTotal.Text = "Include In Total";
            this.chkIncludeTotal.UseVisualStyleBackColor = true;
            // 
            // frmRecoveryTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 389);
            this.Controls.Add(this.chkIncludeTotal);
            this.Controls.Add(this.chkDueMonthly);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecoveryTypes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Recovery Types";
            this.Load += new System.EventHandler(this.frmRecoveryTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCategoryID;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.CheckBox chkDueMonthly;
        private System.Windows.Forms.CheckBox chkIncludeTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IncludeInTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DueMonthly;
    }
}