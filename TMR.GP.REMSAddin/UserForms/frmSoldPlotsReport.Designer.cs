namespace TMR.GP.REMSAddin.UserForms
{
    partial class frmSoldPlotsReport
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cmbBlock = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dTPFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dTPToDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(262, 148);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 276;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(147, 148);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 275;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cmbBlock
            // 
            this.cmbBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlock.Enabled = false;
            this.cmbBlock.FormattingEnabled = true;
            this.cmbBlock.Location = new System.Drawing.Point(132, 49);
            this.cmbBlock.Name = "cmbBlock";
            this.cmbBlock.Size = new System.Drawing.Size(226, 21);
            this.cmbBlock.TabIndex = 272;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 271;
            this.label3.Text = "Block";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(72, 30);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(40, 13);
            this.lblProject.TabIndex = 270;
            this.lblProject.Text = "Project";
            // 
            // cmbProject
            // 
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(132, 27);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(226, 21);
            this.cmbProject.TabIndex = 269;
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 278;
            this.label1.Text = "From Date";
            // 
            // dTPFromDate
            // 
            this.dTPFromDate.CustomFormat = "dd/MM/yyy";
            this.dTPFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPFromDate.Location = new System.Drawing.Point(132, 71);
            this.dTPFromDate.Margin = new System.Windows.Forms.Padding(2);
            this.dTPFromDate.Name = "dTPFromDate";
            this.dTPFromDate.Size = new System.Drawing.Size(226, 20);
            this.dTPFromDate.TabIndex = 277;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 280;
            this.label2.Text = "To Date";
            // 
            // dTPToDate
            // 
            this.dTPToDate.CustomFormat = "dd/MM/yyy";
            this.dTPToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPToDate.Location = new System.Drawing.Point(132, 92);
            this.dTPToDate.Margin = new System.Windows.Forms.Padding(2);
            this.dTPToDate.Name = "dTPToDate";
            this.dTPToDate.Size = new System.Drawing.Size(226, 20);
            this.dTPToDate.TabIndex = 279;
            // 
            // frmSoldPlotsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 193);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dTPToDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dTPFromDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cmbBlock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.cmbProject);
            this.Name = "frmSoldPlotsReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sold Plots Report";
            this.Load += new System.EventHandler(this.frmSoldPlotsReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cmbBlock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTPFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTPToDate;
    }
}