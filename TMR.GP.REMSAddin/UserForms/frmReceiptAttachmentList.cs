using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMR.GP.REMSDal;

namespace TMR.GP.REMSAddin
{
    public partial class frmReceiptAttachmentList : Form
    {

        public AttachmentType attachmentType { get; set; }

        DataAccess da = new DataAccess();
        public string strRegistrationNo { get; set; }        
        public string strReceiptNumber { get; set; }
        public frmReceiptAttachmentList()
        {
            InitializeComponent();
        }
        private void frmAttachmentList_Load(object sender, EventArgs e)
        {           
            txtReceiptNumber.Text = strReceiptNumber;
            txtRegistrationNo.Text = strRegistrationNo;
            LoadAttachments();
        }
        private void LoadAttachments()
        {
            dgList.Rows.Clear();

            int SRNo = 1;

            var attachments = da.GetReceiptAttachments(strRegistrationNo, strReceiptNumber);

            foreach (var attachment in attachments)
            {
                int rowIndex = dgList.Rows.Add();
                dgList.Rows[rowIndex].Cells["SRNo"].Value = SRNo;
                dgList.Rows[rowIndex].Cells["FileName"].Value = attachment.FileName;
                dgList.Rows[rowIndex].Cells["ID"].Value = attachment.id;
                dgList.Rows[rowIndex].Cells["FileDate"].Value = attachment.FileDate.ToString("dd/MM/yyy");
                dgList.Rows[rowIndex].Cells["Remarks"].Value = attachment.Remarks;

                SRNo++;
            }

        }
        private void tsbViewAttachments_Click(object sender, EventArgs e)
        {
            if (dgList.SelectedRows.Count == 0)
                return;

            int id = Convert.ToInt32(dgList.SelectedRows[0].Cells["id"].Value);
            var result = da.GetReceiptAttachment(id);
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save";
            saveDialog.Filter = "Excel Files (*.xls;*.xlsx)|*.xls;*.xlsx" + "|" +
            "Word Files(*.dox;*.docx)|*.dox;*.docx" + "|" +
            "PDF Files(*.pdf;)|*.pdf;" + "|" +
            "Image Files (*.png;*.jpg)|*.png;*.jpg";

            saveDialog.FileName = result.FileName;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveDialog.FileName;
                System.IO.FileStream fs = new System.IO.FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.Write);
                fs.Write(result.FileContents, 0, result.FileContents.Length);
                fs.Flush();
                fs.Close();
            }
        }
        byte[] fileData;
        private void tsbAttach_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDlg = new OpenFileDialog();

            openFileDlg.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDlg.Filter = "Excel Files (*.xls;*.xlsx)|*.xls;*.xlsx" + "|" +
                                 "Word Files(*.dox;*.docx)|*.dox;*.docx" + "|" +
                                 "PDF Files(*.pdf;)|*.pdf;" + "|" +
                                 "Image Files (*.png;*.jpg)|*.png;*.jpg";

            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {

                FileInfo fi = new FileInfo(openFileDlg.FileName);
                txtFileName.Text = fi.Name;
                FileStream fs = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read);
                BinaryReader rdr = new BinaryReader(fs);
                fileData = rdr.ReadBytes((int)fs.Length);
                rdr.Close();
                fs.Close();
            }
        }
        private void btnAddAttachment_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text.Trim() == "")
                return;
            if (fileData == null)
                return;
            bool result = false;

            result = da.AddReceiptAttachment(new clsReceiptAttachment
           {
               RegistrationNo = txtRegistrationNo.Text,
               ReceiptNumber = txtReceiptNumber.Text,
               FileName = txtFileName.Text,
               FileContents = fileData,
               FileDate = DateTime.Now,
               Remarks = txtRemarks.Text
           });


            if (result == false)
            {
                MessageBox.Show("An Error occurred");
                return;
            }

            txtFileName.Text = "";
            txtRemarks.Text = "";
            fileData = null;
            LoadAttachments();
        }
    }
}
