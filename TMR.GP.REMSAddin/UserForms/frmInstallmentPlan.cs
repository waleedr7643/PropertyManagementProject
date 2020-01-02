using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMR.GP.REMSDal;

namespace TMR.GP.REMSAddin
{
    public partial class frmInstallmentPlan : Form
    {
        DataAccess da = new DataAccess();

        //public int NumberOfInstallments { get; set; }

        public frmInstallmentPlan()
        {
            InitializeComponent();
        }
        private void frmInstallmentPlan_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            bool result; int InstallmentCount;
            result = Int32.TryParse(txtInstallments.Text, out InstallmentCount);
            int SRNo = 0;

            DateTime Duedate = dTPStartDate.Value.Date;
            decimal NetAmt = Convert.ToDecimal(txtNetRetailPrice.Text);
            decimal BookingPrice = Convert.ToDecimal(txtBookingPrice.Text);

            //NumberOfInstallments = Convert.ToInt32(NetAmt / InstallmentNo);
            decimal CalculateAmt = (NetAmt - BookingPrice) / InstallmentCount;
            var Frequency = cmbFrequency.Text;
            var Startdate = dTPStartDate.Value.Date;

            dgInstallments.Rows.Clear();


            for (int nmbr = 1; nmbr <= InstallmentCount; nmbr++)
            {
                int intRowIndex = dgInstallments.Rows.Add();
                dgInstallments.Rows[intRowIndex].Cells["SNo"].Value = nmbr;
                dgInstallments.Rows[intRowIndex].Cells["Amt"].Value = CalculateAmt.ToString("N2");

                //if (nmbr == 1)
                //{
                //    Duedate = dTPStartDate.Value.Date;
                //}
                //else
                {
                    if (Frequency == "Monthly")
                    {

                        Duedate = Startdate.AddMonths((nmbr - 1) * 1);

                    }
                    else if (Frequency == "BiMonthly")
                    {
                        Duedate = Startdate.AddMonths((nmbr - 1) * 2);
                    }
                    else if (Frequency == "Quaterly")
                    {
                        Duedate = Startdate.AddMonths((nmbr - 1) * 3);
                    }
                    else if (Frequency == "BiAnnually")
                    {
                        Duedate = Startdate.AddMonths((nmbr - 1) * 6);
                    }
                    else if (Frequency == "Annually")
                    {
                        Duedate = Startdate.AddMonths((nmbr - 1) * 12);
                    }
                }
                dgInstallments.Rows[intRowIndex].Cells["DueDate"].Value = Duedate.ToString("dd/MM/yyy");

                SRNo++;
            }

            SRNo = 1;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmMemberLookup frm = new frmMemberLookup();
            frm.memberlookupCode = memberLookupCodes.All;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtRegistrationNo.Text = frm.strMemberShipID;
                LoadInformation();
                txtRegistrationNo.Focus();
                btnSelect.Focus();
            }
        }
        private void LoadInformation()
        {
            if (txtRegistrationNo.Text.Trim() == "")
                return;

            var info = da.GetMemberRegistrationInfo(txtRegistrationNo.Text);

            if (info == null || info.id == 0)
                return;

            txtClientID.Enabled = false;
            txtRegistrationNo.Enabled = false;


            txtRegistrationNo.Text = info.RegistrationNo;
            txtClientID.Text = info.ClientID;
            txtName.Text = info.Name;

            txtSizeCode.Text = info.Plan;
            dTPBooking.Value = info.Booking;
            txtProjects.Text = info.strProjectid;
            txtTotalPrice.Text = info.TotalPrice.ToString("N2");

            txtRebatAmt.Text = info.RebatAmt.ToString("N2");
            txtNetRetailPrice.Text = info.NetOrRetailPrice.ToString("N2");
            txtBookingPrice.Text = info.BookingPrice.ToString("N2");
        }
      
    }
}
