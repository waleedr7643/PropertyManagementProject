using Microsoft.Dexterity.Applications;
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
    public partial class frmUnitRevaluation : Form
    {
        DataAccess da = new DataAccess();
        ApprovalStatus EntryApproved = ApprovalStatus.Pending;
        List<clsProjects> lstprojects = new List<clsProjects>();
        List<clsBlock> lstBlocks = new List<clsBlock>();
        List<clsSizeCodes> lstSizecodes = new List<clsSizeCodes>();
        clsSizeCodePriceList clspricelist = new clsSizeCodePriceList();
        public int id { get; set; }
        public frmUnitRevaluation()
        {
            InitializeComponent();
        }
        private void frmUnitRevaluation_Load(object sender, EventArgs e)
        {
            cmbApprovalStatus.Text = "Not Saved";

            LoadCombos();
            if (id != 0)
                LoadInformation();
        }

        private void LoadCombos()
        {
            lstprojects = da.GetAllProjectsInfo();
            foreach (var project in lstprojects)
                cmbProject.Items.Add(project.strProjectid);

        }

        private void DataGridRefresh()
        {
            if (cmbProject.SelectedIndex == -1)
                return;
            if (cmbBlock.SelectedIndex == -1)
                return;

            dgList.Rows.Clear();

            if (id == 0)
            {
                if (cmbBlock.Text == "All")
                {
                    foreach (var sizeCode in lstSizecodes)
                    {
                        foreach (var block in lstBlocks)
                        {
                            int index = dgList.Rows.Add();
                            dgList.Rows[index].Cells["SizeCode"].Value = sizeCode.strUnitSizeCode;
                            dgList.Rows[index].Cells["RowId"].Value = 0;
                            dgList.Rows[index].Cells["BlockID"].Value = block.BlockNo;

                            clspricelist.strProjectID = cmbProject.Text;
                            clspricelist.strBlockID = block.BlockNo;
                            clspricelist.strSizeCode = sizeCode.strUnitSizeCode;

                            clsSizeCodePriceList price = da.GetSizeCodePriceList(clspricelist);
                            dgList.Rows[index].Cells["OldPrice"].Value = price.dPrice.ToString();
                        }
                    }
                }
                else
                {
                    foreach (var sizeCode in lstSizecodes)
                    {
                        int index = dgList.Rows.Add();
                        dgList.Rows[index].Cells["SizeCode"].Value = sizeCode.strUnitSizeCode;
                        dgList.Rows[index].Cells["RowId"].Value = 0;
                        dgList.Rows[index].Cells["BlockID"].Value = cmbBlock.Text;

                        clspricelist.strProjectID = cmbProject.Text;
                        clspricelist.strBlockID = cmbBlock.Text;
                        clspricelist.strSizeCode = sizeCode.strUnitSizeCode;

                        clsSizeCodePriceList price = da.GetSizeCodePriceList(clspricelist);
                        dgList.Rows[index].Cells["OldPrice"].Value = price.dPrice.ToString();
                    }
                }
            }
        }
        private void LoadInformation()
        {
            dgList.Rows.Clear();

            clsUnitRevaluation reval = da.GetUnitRevaluationById(id);
            if (reval == null)
                return;

            cmbProject.Text = reval.strProject;
            cmbBlock.Text = reval.strBlock;
            dtpDate.Value = reval.dateRevaluationDate;

            cmbProject.Enabled = false;
            cmbBlock.Enabled = false;

            EntryApproved = (ApprovalStatus)reval.ApprovalStatusCode;

            if ((ApprovalStatus)reval.ApprovalStatusCode == ApprovalStatus.Pending)
                cmbApprovalStatus.Text = "Pending";
            else if ((ApprovalStatus)reval.ApprovalStatusCode == ApprovalStatus.Approved)
                cmbApprovalStatus.Text = "Approved";
            else if ((ApprovalStatus)reval.ApprovalStatusCode == ApprovalStatus.Rejected)
                cmbApprovalStatus.Text = "Rejected";

            List<clsUnitRevaluationListItem> revalList = da.GetUnitRevaluationListItemsById(id);


            foreach (var item in revalList)
            {
                int index = dgList.Rows.Add();
                dgList.Rows[index].Cells["BlockID"].Value = item.BlockID;
                dgList.Rows[index].Cells["SizeCode"].Value = item.SizeCode;
                dgList.Rows[index].Cells["RowId"].Value = item.id;
                dgList.Rows[index].Cells["NewPrice"].Value = item.NewPrice;
                dgList.Rows[index].Cells["OldPrice"].Value = item.OldPrice;
                clspricelist.strProjectID = cmbProject.Text;
                clspricelist.strBlockID = cmbBlock.Text;
                clspricelist.strSizeCode = item.SizeCode;
            }


        }
        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProject.SelectedIndex == -1)
                return;

            cmbBlock.Text = "";
            cmbBlock.Items.Clear();

            lstBlocks = da.GetBlocksByProjectNo(cmbProject.Text);
            cmbBlock.Items.Add("All");
            foreach (var block in lstBlocks)
                cmbBlock.Items.Add(block.BlockNo);

            lstSizecodes = da.GetAllSizeCodeInfoByProject(cmbProject.Text);

            DataGridRefresh();
        }
        private void tsbClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (cmbProject.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a project.");
                return;
            }
            if (cmbBlock.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a block.");
                return;
            }
            decimal value; bool result;
            List<clsUnitRevaluationListItem> lst = new List<clsUnitRevaluationListItem>();
            List<clsSizeCodePriceList> lst2 = new List<clsSizeCodePriceList>();

            foreach (DataGridViewRow dgr in dgList.Rows)
            {

                if (dgr.Cells["NewPrice"].Value == null)
                {
                    MessageBox.Show("Please enter a valid old price.");
                    return;
                }

                else
                    result = decimal.TryParse(dgr.Cells["OldPrice"].Value.ToString(), out value);

                if (result == false)
                {
                    MessageBox.Show("Please enter a valid old price.");
                    return;
                }

                if (dgr.Cells["OldPrice"].Value == null)
                {
                    MessageBox.Show("Please enter a valid old price.");
                    return;
                }
                else
                    result = decimal.TryParse(dgr.Cells["OldPrice"].Value.ToString(), out value);
                if (result == false)
                {
                    MessageBox.Show("Please enter a valid old price.");
                    return;
                }

                lst.Add(new clsUnitRevaluationListItem
                {
                    id = Convert.ToInt32(dgr.Cells["Rowid"].Value),
                    NewPrice = Convert.ToDecimal(dgr.Cells["NewPrice"].Value),
                    OldPrice = Convert.ToDecimal(dgr.Cells["OldPrice"].Value),
                    SizeCode = (dgr.Cells["SizeCode"].Value.ToString()),
                    BlockID = (dgr.Cells["BlockID"].Value.ToString()),
                });

                lst2.Add(new clsSizeCodePriceList
                {
                    id = Convert.ToInt32(dgr.Cells["Rowid"].Value),
                    strSizeCode = (dgr.Cells["SizeCode"].Value.ToString()),
                    dPrice = Convert.ToDecimal(dgr.Cells["NewPrice"].Value),
                    strProjectID = cmbProject.Text,
                    strBlockID = (dgr.Cells["BlockID"].Value.ToString()),

                });
            }

            clsUnitRevaluation revaluation = new clsUnitRevaluation()
            {
                strProject = cmbProject.Text,
                strBlock = cmbBlock.Text,
                dateRevaluationDate = dtpDate.Value.Date
            };

            if (id == 0)
            {
                revaluation.CreatedBy = Dynamics.Globals.UserId;
                revaluation.CreationDate = DateTime.Now;
                revaluation.ApprovalStatusCode = (int)ApprovalStatus.Pending;
                revaluation.LastUpdateDate = new DateTime(1900, 1, 1);
                revaluation.LastUpdateUser = "";
                revaluation.ApprovalActionUser = "";
                revaluation.ApprovalActionDate = new DateTime(1900, 1, 1);
            }
            else if (id != 0)
            {
                revaluation.ApprovalStatusCode = (int)ApprovalStatus.Pending;
                revaluation.LastUpdateDate = DateTime.Now;
                revaluation.LastUpdateUser = Dynamics.Globals.UserId;
                revaluation.ApprovalActionUser = "";
                revaluation.ApprovalActionDate = new DateTime(1900, 1, 1);
            }
            int intRevalID = 0;

            result = da.AddUnitRevaluation(revaluation, ref intRevalID);
            if (result == false)
            {
                MessageBox.Show("Error saving unit revaluation.");
                return;
            }
            else
            {
                foreach (var item in lst)
                {
                    item.Revaluationid = intRevalID;
                    result = da.AddUnitRevaluationItem(item);
                    if (result == false)
                    {
                        MessageBox.Show("Error saving unit revaluation.");
                        return;
                    }
                }
            }



            foreach (var item in lst2)
            {
                item.Fk_RevaluationID = intRevalID;
                result = da.AddSizeCodePriceList(item);
                if (result == false)
                {
                    MessageBox.Show("Error saving unit revaluation.");
                    return;
                }
            }



            id = intRevalID;
            LoadInformation();
            DataGridRefresh();

        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            id = 0;
            dgList.Rows.Clear();
            cmbProject.SelectedIndex = -1;
            cmbBlock.SelectedIndex = -1;
            cmbApprovalStatus.Text = "Not Saved";
            EntryApproved = ApprovalStatus.Pending;
            cmbProject.Enabled = true;
            cmbBlock.Enabled = true;
        }

        private void tsbApprove_Click(object sender, EventArgs e)
        {

        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            DataGridRefresh();
        }

        private void dgList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgList.IsCurrentCellDirty)
            {
                dgList.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void cmbBlock_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridRefresh();
        }
    }
}
