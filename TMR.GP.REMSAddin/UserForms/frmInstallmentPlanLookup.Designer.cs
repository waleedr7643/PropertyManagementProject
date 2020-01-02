namespace TMR.GP.REMSAddin
{
    partial class frmInstallmentPlanLookup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstallmentPlanLookup));
            this.dgList = new System.Windows.Forms.DataGridView();
            this.SRNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallmentPlanCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallmentPlanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallmentPlanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SRNo,
            this.InstallmentPlanCode,
            this.InstallmentPlanName,
            this.InstallmentPlanId});
            this.dgList.Location = new System.Drawing.Point(12, 63);
            this.dgList.MultiSelect = false;
            this.dgList.Name = "dgList";
            this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgList.Size = new System.Drawing.Size(701, 388);
            this.dgList.TabIndex = 41;
            // 
            // SRNo
            // 
            this.SRNo.FillWeight = 38.07107F;
            this.SRNo.HeaderText = "Sr No.";
            this.SRNo.Name = "SRNo";
            // 
            // InstallmentPlanCode
            // 
            this.InstallmentPlanCode.FillWeight = 130.9645F;
            this.InstallmentPlanCode.HeaderText = "Installment Plan Code";
            this.InstallmentPlanCode.Name = "InstallmentPlanCode";
            this.InstallmentPlanCode.ReadOnly = true;
            // 
            // InstallmentPlanName
            // 
            this.InstallmentPlanName.FillWeight = 130.9645F;
            this.InstallmentPlanName.HeaderText = "Installment Plan Name";
            this.InstallmentPlanName.Name = "InstallmentPlanName";
            this.InstallmentPlanName.ReadOnly = true;
            // 
            // InstallmentPlanId
            // 
            this.InstallmentPlanId.HeaderText = "id";
            this.InstallmentPlanId.Name = "InstallmentPlanId";
            this.InstallmentPlanId.ReadOnly = true;
            this.InstallmentPlanId.Visible = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbClose});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(721, 60);
            this.toolStrip2.TabIndex = 47;
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
            this.tsbSave.Click += new System.EventHandler(this.tsbSelect_Click);
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
            // frmInstallmentPlanLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 460);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dgList);
            this.Name = "frmInstallmentPlanLookup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Installment Plans Lookup";
            this.Load += new System.EventHandler(this.frmUnitsLookUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitNatureID;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallmentPlanCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallmentPlanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallmentPlanId;
    }
}