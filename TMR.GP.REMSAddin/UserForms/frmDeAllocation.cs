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
    public partial class frmDeAllocation : Form
    {


        clsDeAllocation clsDAloc = new clsDeAllocation();
        clsMemberRegistration info1 = new clsMemberRegistration();
        DataAccess da = new DataAccess();
        List<clsProjects> projects = new List<clsProjects>();
        clsDeAllocation infoDeAloc =  new clsDeAllocation();
        List<clsBlock> blocks = new List<clsBlock>();
        
        
        public frmDeAllocation()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool result = false;

            if (txtRegistrationNo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Registration Cannot Be Empty");
                txtRegistrationNo.Focus();
                return;
            }

            if (dTDeallocationDate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Date Cannot Be Empty");
                dTDeallocationDate.Focus();
                return;
            }

            if (txtClientID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Client ID Cannot Be Empty");
                txtClientID.Focus();
                return;
            }

            if (txtRemarks.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Remarks Cannot Be Empty");
                txtRemarks.Focus();
                return;
            }


            clsDAloc.RegistrationOrBookingNo = txtRegistrationNo.Text;
            clsDAloc.ClientID = txtClientID.Text;
            clsDAloc.DeAllocationDate = Convert.ToDateTime(dTDeallocationDate.Text);
            clsDAloc.Remarks = txtRemarks.Text.Trim();

            if (chkBoxApproved.ThreeState == true)
            {
                clsDAloc.Approved = true;

            }
            else
            {
                clsDAloc.Approved = false;
            }


            result = da.AddDeallocationInfo(clsDAloc);

            if (result == false)
            {
                MessageBox.Show("Unsuccessfull");
            }

            //result = da.UpdateMemberRegistrationAfterCancellation(txtRegistrationNo.Text.Trim(), "Marked for Deallocation");

            if (result == false)
            {
                MessageBox.Show("An Error Occoured While Updation Process");
            }


            if (result == true)
            {
                MessageBox.Show("Deallocation Marked successfuly against following  Client ID :" + txtClientID.Text);
            }
        


        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmMemberLookup frm = new frmMemberLookup();
            frm.memberlookupCode = memberLookupCodes.Deallocte;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtRegistrationNo.Text = frm.strMemberShipID;
                txtProjectNo.Text = frm.strProjectID;
                txtBlockNo.Text = frm.strBlock;
                txtUnit.Text = frm.strPlot;
                txtRegistrationNo.Focus();
                btnSelect.Focus();
            }
        }

       

        private void btnDeAllocationSave_Click(object sender, EventArgs e)
        {

            if (txtProjectNo.Text == "")
            {
                MessageBox.Show("Project No not found");
                txtProjectNo.Focus();
                return;
            }
            if (txtBlockNo.Text == "")
            {
                MessageBox.Show("Block No not found");
                txtBlockNo.Focus();
                return;
            }

            infoDeAloc.RegistrationOrBookingNo = txtRegistrationNo.Text;
            infoDeAloc.ClientID = txtClientID.Text;
            infoDeAloc.DeAllocationDate = dTDeallocationDate.Value;
            if (chkBoxApproved.Checked == true)
            {
                infoDeAloc.Approved = true;
            }
            if (chkBoxApproved.Checked == false)
            {
                infoDeAloc.Approved = false;
            }
            
            infoDeAloc.Remarks = txtRemarks.Text;


            bool result = da.AddDeallocationInfo(infoDeAloc);

            if (result == false)
            {
                MessageBox.Show("An Error Occoured");
                return;
            }

            if (result == true)
            {
                info1.RegistrationNo = txtRegistrationNo.Text;
                info1.strStatus = "Deallocated";
                info1.strProjectid = txtProjectNo.Text;
                info1.Block = "";
                info1.Plan = "";
                info1.Plot = "";
                info1.bitAllocated = false;
                info1.intStatusCode = (int)memberLookupCodes.Deallocte;

                #region      /////////////////// Member Status in Member Registraion

                if (info1.strStatus == "Marked for Deallocation" || info1.strStatus == "Marked for Deallocation" || info1.strStatus == "Deallocation")
                {
                    result = da.UpdateMemberRegistrationAfterDeallocation(info1);
                }

                if (result == false)
                {
                    MessageBox.Show("An Error Occoured While Update Process");
                }

                if (result == true)
                {
                    MessageBox.Show("Successfully Marked For Deallocation");
                }
                #endregion

            }

            #region    //////////////////// Unit Status Unit
            /// Get Unit Info
            /// 

            bool unit = da.GetUnitIDAvailability(txtUnit.Text);

            if (unit == true)
            {
                da.UpdateUnitStatus("Cancelled", txtUnit.Text, txtRegistrationNo.Text, (int)memberLookupCodes.Allocated);
                result = da.UpdateMemberRegistrationAfterAllocation(info1);

                if (result == true)
                {
                    MessageBox.Show("frmMemberReg Form: Status Updated");
                }


                MessageBox.Show("frmUnits Form: Status Updated");

            }
            else
            {
                MessageBox.Show("Unit is unavailable");
            }

            if (result == false)
            {
                MessageBox.Show("An Error Occoured While Update Process");
            }




            #endregion


            Clear();

        }

        private void txtRegistrationNo_TextChanged(object sender, EventArgs e)
        {

            #region Loading Member Registration Table Info
            if (!string.IsNullOrEmpty(txtRegistrationNo.Text))
            {

                info1.RegistrationNo = txtRegistrationNo.Text;
                info1 = da.GetMemberRegistrationInfo(txtRegistrationNo.Text);
                txtRegistrationNo.Text = info1.RegistrationNo;
                txtSizeCode.Text = info1.Plan;
                txtBookingDate.Text = info1.Booking.ToShortDateString();
                txtClientID.Text = info1.ClientID;
                txtRebatAmt.Text = Convert.ToString(info1.RebatAmt);
                txtNetRetailPrice.Text = Convert.ToString(info1.NetOrRetailPrice);
                txtBookingPrice.Text = Convert.ToString(info1.BookingPrice);
                txtClientName.Text = info1.Name;
                
                var res = da.GetMemberImage(txtRegistrationNo.Text, txtClientID.Text);

                if (!(res == null || res.Image == null))
                    pBMemberRegistration.Image = byteArrayToImage(res.Image);

               
               
            }
            #endregion
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);

            if (ms != null)
            {
                Image returnimage = Image.FromStream(ms);
                return returnimage;
            }

            else
            {
                return null;
            }
        }
        private void tsbClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            txtRegistrationNo.Text = "";
            txtClientID.Text = "";
            txtClientName.Text = "";
            txtSizeCode.Text = "";
            txtTotalPrice.Text = "0.00";
            txtRebatAmt.Text = "0.00";
            txtNetRetailPrice.Text = "0.00";
            txtBookingPrice.Text = "0.00";
            dTDeallocationDate.Text = "";
            txtProjectNo.Text = "";
            txtBlockNo.Text = "";
            txtUnit.Text = "";
            chkBoxApproved.Checked = false;
            txtBookingDate.Text = "";

        }
        private void frmDeAllocation_Load(object sender, EventArgs e)
        {
            

        }

        /// <summary>
        /// This Function Loads
        /// Data in Projects combobox
        /// </summary>
        private void LoadFunction()
        {

            //projects = da.GetAllProjectsInfo();

            //foreach (var project in projects)
            //    txt.Items.Add(project.strProjectid);

        }
        private void btnSelectUnit_Click(object sender, EventArgs e)
        {
            /*if (cmbBlock.SelectedIndex == -1)
                return;
            if (cmbProject.SelectedIndex == -1)
                return;
            if (txtRegistrationNo.Text == "")
                return;

            frmUnitsLookUp lookup = new frmUnitsLookUp();
            lookup.strProject = cmbProject.Text;
            lookup.strBlock = cmbBlock.Text;
            lookup.strSizeCode = txtSizeCode.Text;
            
            if (lookup.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtUnit.Text = lookup.strunitID;
            }
             
             */
        }

     
      
    }
}
