namespace TMR.GP.REMSAddin
{
    partial class frmReceiptAttachmentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceiptAttachmentList));
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tsbLoadAttachments = new System.Windows.Forms.ToolStripButton();
            this.tsbAttach = new System.Windows.Forms.ToolStripButton();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.SRNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtReceiptNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddAttachment = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.Enabled = false;
            this.txtRegistrationNo.Location = new System.Drawing.Point(95, 74);
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.Size = new System.Drawing.Size(174, 20);
            this.txtRegistrationNo.TabIndex = 122;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(7, 78);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(83, 13);
            this.label52.TabIndex = 123;
            this.label52.Text = "Registration No.";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tsbLoadAttachments,
            this.tsbAttach});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(573, 60);
            this.toolStrip1.TabIndex = 220;
            this.toolStrip1.Text = "toolStrip1";
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
            // 
            // tsbLoadAttachments
            // 
            this.tsbLoadAttachments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLoadAttachments.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadAttachments.Image")));
            this.tsbLoadAttachments.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLoadAttachments.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadAttachments.Name = "tsbLoadAttachments";
            this.tsbLoadAttachments.Size = new System.Drawing.Size(46, 57);
            this.tsbLoadAttachments.Text = "toolStripButton1";
            this.tsbLoadAttachments.Click += new System.EventHandler(this.tsbViewAttachments_Click);
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
            this.ID,
            this.FileName,
            this.FileDate,
            this.Remarks});
            this.dgList.Location = new System.Drawing.Point(12, 200);
            this.dgList.Name = "dgList";
            this.dgList.Size = new System.Drawing.Size(546, 210);
            this.dgList.TabIndex = 221;
            // 
            // SRNo
            // 
            this.SRNo.FillWeight = 71.06599F;
            this.SRNo.HeaderText = "Sr No.";
            this.SRNo.Name = "SRNo";
            // 
            // ID
            // 
            this.ID.HeaderText = "id";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // FileName
            // 
            this.FileName.FillWeight = 109.6447F;
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            // 
            // FileDate
            // 
            this.FileDate.FillWeight = 109.6447F;
            this.FileDate.HeaderText = "Date";
            this.FileDate.Name = "FileDate";
            // 
            // Remarks
            // 
            this.Remarks.FillWeight = 109.6447F;
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            // 
            // txtReceiptNumber
            // 
            this.txtReceiptNumber.Enabled = false;
            this.txtReceiptNumber.Location = new System.Drawing.Point(95, 96);
            this.txtReceiptNumber.Name = "txtReceiptNumber";
            this.txtReceiptNumber.Size = new System.Drawing.Size(174, 20);
            this.txtReceiptNumber.TabIndex = 222;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 223;
            this.label1.Text = "Receipt #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 225;
            this.label3.Text = "File Name";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(95, 144);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemarks.MaxLength = 50;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(463, 20);
            this.txtRemarks.TabIndex = 224;
            // 
            // txtFileName
            // 
            this.txtFileName.Enabled = false;
            this.txtFileName.Location = new System.Drawing.Point(95, 120);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFileName.MaxLength = 50;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(463, 20);
            this.txtFileName.TabIndex = 224;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 225;
            this.label2.Text = "Remarks";
            // 
            // btnAddAttachment
            // 
            this.btnAddAttachment.Location = new System.Drawing.Point(95, 168);
            this.btnAddAttachment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAttachment.Name = "btnAddAttachment";
            this.btnAddAttachment.Size = new System.Drawing.Size(56, 28);
            this.btnAddAttachment.TabIndex = 226;
            this.btnAddAttachment.Text = "Add";
            this.btnAddAttachment.UseVisualStyleBackColor = true;
            this.btnAddAttachment.Click += new System.EventHandler(this.btnAddAttachment_Click);
            // 
            // frmReceiptAttachmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 419);
            this.Controls.Add(this.btnAddAttachment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtReceiptNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtRegistrationNo);
            this.Controls.Add(this.label52);
            this.Name = "frmReceiptAttachmentList";
            this.Text = "Receipt Attachments";
            this.Load += new System.EventHandler(this.frmAttachmentList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbLoadAttachments;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.TextBox txtReceiptNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsbAttach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddAttachment;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
    }
}