using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMR.GP.GrandCityAddon
{
    public partial class frmDirectors : Form
    {

        int id = 0;

        DataAccess da = new DataAccess();
        List<clsDirector> lstDirectors = new List<clsDirector>();

        public frmDirectors()
        {
            InitializeComponent();
        }
        private void frmDirectors_Load(object sender, EventArgs e)
        {
            LoadDirectors();
        }

        private void LoadDirectors()
        {
            dgList.Rows.Clear();

            lstDirectors = da.GetAllDirectors();

            if (lstDirectors != null)
            {
                foreach (var director in lstDirectors)
                {
                    int index = dgList.Rows.Add();
                    dgList.Rows[index].Cells["DirectorName"].Value = director.strName;
                    dgList.Rows[index].Cells["CNIC"].Value = director.strCNIC;
                    dgList.Rows[index].Cells["ID1"].Value = director.id;
                    
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter a name.");
                txtName.Focus();
                return;

            }
            if (txtCNIC.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a CNIC #.");
                txtCNIC.Focus();
                return;                
            }

            foreach (DataGridViewRow dgr in dgList.Rows)
            {
                if (dgr.Cells["DirectorName"].Value.ToString().Trim().ToUpper() == txtName.Text.Trim().ToUpper() && this.id != Convert.ToInt32(dgr.Cells["ID1"].Value))
                {
                    MessageBox.Show("A director with same name already exists.");
                    return;
                }
            }

            clsDirector cat = new clsDirector();
            cat.strName = txtName.Text.Trim();
            cat.strCNIC = txtCNIC.Text.Trim();
            cat.id = this.id;

            bool result = da.AddDirector(cat);
            if (result == false)
            {
                MessageBox.Show("An error occurred.");
                return;
            }

            LoadDirectors();

            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dgList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            id = Convert.ToInt32(dgList.Rows[e.RowIndex].Cells["ID1"].Value);
            txtName.Text = dgList.Rows[e.RowIndex].Cells["DirectorName"].Value.ToString();
            txtCNIC.Text = dgList.Rows[e.RowIndex].Cells["CNIC"].Value.ToString();

        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            id = 0;
            txtName.Text = "";
            txtCNIC.Text = "";
        }


    }
}
