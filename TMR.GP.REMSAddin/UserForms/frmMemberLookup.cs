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

    public partial class frmMemberLookup : Form
    {
        public memberLookupCodes memberlookupCode { get; set; }
        public bool bForProcess { get; set; }
        public string strProject { get; set; }
        DataAccess da = new DataAccess();
        List<clsProjects> lstProjects = new List<clsProjects>();
        List<clsBlock> lstBlocks = new List<clsBlock>();


        public string strMemberShipID { get; set; }
        public string strClientID { get; set; }
        public string strClientName { get; set; }
        public string strProjectID { get; set; }
        public DateTime strBookingDate { get; set; }
        public string strSizeCode { get; set; }
        public string strBlock { get; set; }
        public string strPlot { get; set; }

        List<clsMemberRegistration> lstMemberRegistration;

        //  public string strUnitID { get; set; }

        public string strunitID { get; set; }


        public frmMemberLookup()
        {
            InitializeComponent();
        }

        private void frmMemberLookup_Load(object sender, EventArgs e)
        {
            Loadprojects();
            //cmbProject.Text = "All";
            if (strProject == "" || strProject == null)
            {
                cmbProject.Text = "All";
            }
            else
                cmbProject.Text = strProject;

            cmbBlock.Text = "All";
            cmbSearchBy.Text = "Membership ID";

            #region All

            if (this.memberlookupCode == memberLookupCodes.All)
            {
                cmbAllocated.Text = "All";
                cmbStatus.Text = "All";
            }
            else if (this.memberlookupCode == memberLookupCodes.Unallocated)
            {
                cmbAllocated.Text = "Unallocated";
                cmbStatus.Text = "All";
                cmbAllocated.Enabled = false;
            }
            else if (this.memberlookupCode == memberLookupCodes.Cancelled)
            {
                cmbAllocated.Text = "All";
                cmbStatus.Text = "Cancelled";
                cmbStatus.Enabled = false;
            }
            else if (this.memberlookupCode == memberLookupCodes.Reactivate)
            {
                cmbAllocated.Text = "All";
                cmbStatus.Text = "Reactivated";
                cmbStatus.Enabled = false;
            }
            else if (this.memberlookupCode == memberLookupCodes.Refunded)
            {
                cmbAllocated.Text = "All";
                cmbStatus.Text = "Refunded";
                cmbStatus.Enabled = false;
            }
            else if (this.memberlookupCode == memberLookupCodes.Transferred)
            {
                cmbAllocated.Text = "All";
                cmbStatus.Text = "Transferred";
                cmbStatus.Enabled = false;
            }

            clsMemberShipFilter filter = MakeFilter();

            lstMemberRegistration = da.GetMemberRegistration(filter);
            PopulateGrid(lstMemberRegistration);


            //}

            #endregion

            #region Unlocated

            //if (this.memberlookupCode == memberLookupCodes.Unallocated)
            //{
            //    cmbBlock.Visible = false;
            //    cmbProject.Visible = false;
            //    lblProject.Visible = false;
            //    lblBlock.Visible = false;

            //    lstMemberRegistration = da.GetUnallocatedMemberRegistration(new clsMemberShipFilter());
            //    PopulateGrid(lstMemberRegistration);


            //}

            #endregion

            #region Cancellation

            //cmbSearchBy.Text = "Membership ID";


            //if (this.memberlookupCode == memberLookupCodes.Cancelled)
            //{

            //    cmbBlock.Visible = false;
            //    cmbProject.Visible = false;
            //    lblProject.Visible = false;
            //    lblBlock.Visible = false;
            //    lstMemberRegistration = da.GetMemberForCancellation();
            //    PopulateGrid(lstMemberRegistration);


            //}

            #endregion

            #region Deallocation

            //else if (this.memberlookupCode == memberLookupCodes.Deallocte)
            //{
            //    cmbBlock.Visible = false;
            //    cmbProject.Visible = false;
            //    lblProject.Visible = false;
            //    lblBlock.Visible = false;
            //    lstMemberRegistration = da.GetMemberRegistrationForDeallocation(new clsMemberShipFilter());
            //    PopulateGrid(lstMemberRegistration);


            //}


            #endregion

            #region Reactivation

            //else if (this.memberlookupCode == memberLookupCodes.Reactivate)
            //{
            //    cmbBlock.Visible = false;
            //    cmbProject.Visible = false;
            //    lblProject.Visible = false;
            //    lblBlock.Visible = false;
            //    lstMemberRegistration = da.GetMemberForReactivation();
            //    PopulateGrid(lstMemberRegistration);


            //}


            #endregion

            #region Refund

            //else if (this.memberlookupCode == memberLookupCodes.Refunded)
            //{
            //    cmbBlock.Visible = false;
            //    cmbProject.Visible = false;
            //    lblProject.Visible = false;
            //    lblBlock.Visible = false;
            //    //txtSearchValue.Visible = false;
            //    //lblValue.Visible = false;
            //    //btnFilter.Visible = false;
            //    lstMemberRegistration = da.GetMemberForRefund();
            //    PopulateGrid(lstMemberRegistration);


            //}
            //else
            //{

            //}

            #endregion

        }

        private clsMemberShipFilter MakeFilter()
        {
            clsMemberShipFilter filter = new clsMemberShipFilter();

            filter.strProjectID = cmbProject.Text;
            filter.strBlockNo = cmbBlock.Text;
            if (cmbAllocated.Text == "Allocated") { filter.bAllocated = true; ; filter.bFilterAllocated = true; }
            else if (cmbAllocated.Text == "Unallocated") { filter.bAllocated = false; ; filter.bFilterAllocated = true; }
            else if (cmbAllocated.Text == "All") { filter.bAllocated = false; filter.bFilterAllocated = false; }

            if (cmbStatus.Text == "All")
                filter.membershipStatus = memberLookupCodes.All;
            else if (cmbStatus.Text == "New")
                filter.membershipStatus = memberLookupCodes.New;
            else if (cmbStatus.Text == "Cancelled")
                filter.membershipStatus = memberLookupCodes.Cancelled;
            else if (cmbStatus.Text == "Refunded")
                filter.membershipStatus = memberLookupCodes.Refunded;
            else if (cmbStatus.Text == "Reactivated")
                filter.membershipStatus = memberLookupCodes.Reactivate;
            else if (cmbStatus.Text == "Transferred")
                filter.membershipStatus = memberLookupCodes.Transferred;

            if (cmbSearchBy.Text == "Membership ID")
                filter.strMemberShipID = txtSearchValue.Text.Trim();
            else if (cmbSearchBy.Text == "Client ID")
                filter.strClientID = txtSearchValue.Text.Trim();
            else if (cmbSearchBy.Text == "Member Name")
                filter.strName = txtSearchValue.Text.Trim();
            else if (cmbSearchBy.Text == "Unit ID")
                filter.strUnitID = txtSearchValue.Text.Trim();

            filter.bForProcess = this.bForProcess;

            return filter;
        }

        private void Loadprojects()
        {
            cmbProject.Items.Add("All");
            lstProjects = da.GetAllProjectsInfo();
            foreach (var project in lstProjects)
                cmbProject.Items.Add(project.strProjectid);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBlock.Text = "";
            cmbBlock.Items.Clear();
            cmbBlock.Items.Add("All");
            lstBlocks = da.GetBlocksByProjectNo(cmbProject.Text);
            foreach (var block in lstBlocks)
                cmbBlock.Items.Add(block.BlockNo);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

            clsMemberShipFilter filter = MakeFilter();
            lstMemberRegistration = da.GetMemberRegistration(filter);
            PopulateGrid(lstMemberRegistration);
        }

        #region PopulateDataGrid
        private void PopulateGrid(List<clsMemberRegistration> list)
        {
            
            dgList.Rows.Clear();

            int SRNo = 1;
          
            foreach (var item in list)
            {
                int rowIndex = dgList.Rows.Add();

                dgList.Rows[rowIndex].Cells["SRNo"].Value = SRNo;
                dgList.Rows[rowIndex].Cells["MembershipID"].Value = item.RegistrationNo;
                dgList.Rows[rowIndex].Cells["Allocated"].Value = item.bitAllocated.ToString();
                dgList.Rows[rowIndex].Cells["MemberName"].Value = item.Name;
                dgList.Rows[rowIndex].Cells["MobileNumber"].Value = item.Mob;
                dgList.Rows[rowIndex].Cells["ProjectID"].Value = item.strProjectid;
                dgList.Rows[rowIndex].Cells["BlockID"].Value = item.Block;
                dgList.Rows[rowIndex].Cells["UnitID"].Value = item.Plot;
                dgList.Rows[rowIndex].Cells["ClientID"].Value = item.ClientID;
                dgList.Rows[rowIndex].Cells["Plan"].Value = item.Plan;
                dgList.Rows[rowIndex].Cells["Booking"].Value = item.Booking;
                dgList.Rows[rowIndex].Cells["Plot"].Value = item.Plot;
                dgList.Rows[rowIndex].Cells["Block"].Value = item.Block;
                dgList.Rows[rowIndex].Cells["Status"].Value = item.strStatus;
                //dgList.Rows[rowIndex].Cells["Percentage"].Value = item.intPercentage.ToString();

                SRNo++;

            }
        }

        #endregion
        private void tsbSelect_Click(object sender, EventArgs e)
        {
            if (dgList.SelectedRows.Count == 0)
                return;

            strMemberShipID = dgList.SelectedRows[0].Cells["MembershipID"].Value.ToString();
            strClientID = dgList.SelectedRows[0].Cells["ClientID"].Value.ToString();
            strPlot = dgList.SelectedRows[0].Cells["Plot"].Value.ToString();
            strProjectID = dgList.SelectedRows[0].Cells["ProjectID"].Value.ToString();
            strBlock = dgList.SelectedRows[0].Cells["Block"].Value.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void dgList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgList.SelectedRows.Count == 0)
                return;
            strMemberShipID = dgList.SelectedRows[0].Cells["MembershipID"].Value.ToString();
            strClientID = dgList.SelectedRows[0].Cells["ClientID"].Value.ToString();
            strPlot = dgList.SelectedRows[0].Cells["Plot"].Value.ToString();
            strProjectID = dgList.SelectedRows[0].Cells["ProjectID"].Value.ToString();
            strBlock = dgList.SelectedRows[0].Cells["Block"].Value.ToString();
            strClientName = dgList.SelectedRows[0].Cells["MemberName"].Value.ToString();

            this.DialogResult = DialogResult.OK;

        }
    }
}
