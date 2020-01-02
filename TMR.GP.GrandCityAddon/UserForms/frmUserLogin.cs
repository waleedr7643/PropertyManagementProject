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
    public partial class frmUserLogin : Form
    {
        DataAccess da = new DataAccess();
        public string strUserID { get; set; }
        public frmUserLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter valid credentials");
                return;
            }

            var User = da.GetUserByUserID(txtUserID.Text.Trim());

            if (User == null)
            {
                MessageBox.Show("Please enter valid credentials");
                return;
            }
            if (User.PassWord != txtPassword.Text)
            {
                MessageBox.Show("Please enter valid credentials");
                return;
            }

            this.strUserID = User.UserID;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
