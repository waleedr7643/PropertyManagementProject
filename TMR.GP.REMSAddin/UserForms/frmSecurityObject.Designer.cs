namespace TMR.GP.REMSAddin
{
    partial class frmSecurityObject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecurityObject));
            this.label24 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUserid = new System.Windows.Forms.ComboBox();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.id = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllowOpen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AllowApprove = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AllowSave = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AllowPrint = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 83);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 13);
            this.label24.TabIndex = 144;
            this.label24.Text = "Role Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(95, 80);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(174, 21);
            this.cmbCategory.TabIndex = 143;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 146;
            this.label1.Text = "GP User ID";
            // 
            // cmbUserid
            // 
            this.cmbUserid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserid.FormattingEnabled = true;
            this.cmbUserid.Location = new System.Drawing.Point(95, 106);
            this.cmbUserid.Name = "cmbUserid";
            this.cmbUserid.Size = new System.Drawing.Size(174, 21);
            this.cmbUserid.TabIndex = 145;
            this.cmbUserid.SelectedIndexChanged += new System.EventHandler(this.cmbUserid_SelectedIndexChanged);
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.AllowUserToResizeColumns = false;
            this.dgList.AllowUserToResizeRows = false;
            this.dgList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.TaskName,
            this.AllowOpen,
            this.AllowApprove,
            this.AllowSave,
            this.AllowPrint});
            this.dgList.Location = new System.Drawing.Point(10, 143);
            this.dgList.MultiSelect = false;
            this.dgList.Name = "dgList";
            this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgList.Size = new System.Drawing.Size(563, 421);
            this.dgList.TabIndex = 223;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(585, 71);
            this.toolStrip2.TabIndex = 224;
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
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // TaskName
            // 
            this.TaskName.HeaderText = "Task Name";
            this.TaskName.Name = "TaskName";
            this.TaskName.Width = 120;
            // 
            // AllowOpen
            // 
            this.AllowOpen.HeaderText = "Allow Open";
            this.AllowOpen.Name = "AllowOpen";
            this.AllowOpen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AllowOpen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AllowOpen.ThreeState = true;
            // 
            // AllowApprove
            // 
            this.AllowApprove.HeaderText = "Allow Approve";
            this.AllowApprove.Name = "AllowApprove";
            this.AllowApprove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AllowApprove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AllowSave
            // 
            this.AllowSave.HeaderText = "Allow Save";
            this.AllowSave.Name = "AllowSave";
            this.AllowSave.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AllowSave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AllowPrint
            // 
            this.AllowPrint.HeaderText = "Allow Print";
            this.AllowPrint.Name = "AllowPrint";
            this.AllowPrint.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AllowPrint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmSecurityObject
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 576);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUserid);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.cmbCategory);
            this.Name = "frmSecurityObject";
            this.Text = "User Security Setup";
            this.Load += new System.EventHandler(this.frmSecurityObject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUserid;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.DataGridViewButtonColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AllowOpen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AllowApprove;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AllowSave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AllowPrint;
    }
}