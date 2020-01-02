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
    public partial class frmReactivationss : Form
    {
        clsReactivation clsReActive = new clsReactivation();
        clsMemberRegistration info1 = new clsMemberRegistration();
        DataAccess da = new DataAccess();
        bool result = false;
        
        public frmReactivationss()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            
            //Count total selections Which enable it to work only when there is something selectd
            int total = dgList.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["Selection"].Value) == true).Count();
            int CountCanUpdate = 0;
            
            if (total > 0)
            {
                
                //Getting Index of Selected Rows
                if (dgList.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dgList.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgList.Rows[selectedrowindex];
                    
                }

                // Run upto whole scope of the rows
                foreach (DataGridViewRow item in dgList.Rows)
                {
                    
                    bool Approval = false;

                    #region// Count Loop
    
                        #region // Check Null

                    int i = item.Index;

                    if (dgList.Rows[i].Cells[0].Value != null)
                        {

                            #region // Check Selection ? work if true

                            if (bool.Parse(dgList.Rows[i].Cells[0].Value.ToString()) == true)
                            {

                                #region Extra
                                //CountCanUpdate = 1; 
                                //CountCanUpdate = dgList.Rows.Cast<DataGridViewRow>().Where
                                //    (p => Convert.ToBoolean(p.Cells["Approve"].Value)== false).Count();
                                //lbStatus.Items.Add(CountCanUpdate + " " + "Unapproved rows found that's can be update");
                                    #endregion

                                #region// Check Approval ? work if fasle

                                if (bool.Parse(item.Cells[5].Value.ToString()) == false)
                                {


                                    #region // Update Selection Only

                                    if (item.Cells[5].Value.ToString() == "False")
                                    {

                                        string strSelection = item.Cells[0].Value.ToString();
                                        string strCancellationID = item.Cells[1].Value.ToString();
                                        string strRegNo = item.Cells[2].Value.ToString();
                                        string strClientID = item.Cells[3].Value.ToString();
                                        DateTime DTCancellationDate = Convert.ToDateTime(item.Cells[4].Value.ToString());
                                        string strApproval = item.Cells[5].Value.ToString();
                                                                              
                                      //  lblSelection.Text = strSelection;

                                      //  lblCancellationID.Text = strCancellationID;

                                     //   lblRegNo.Text = strRegNo;

                                     //   lblClientID.Text = strClientID;

                                     //   lblCancellationDate.Text = DTCancellationDate.ToShortDateString();

                                     //   lblApproval.Text = strApproval;

                                        MessageBox.Show("Approved :" + i);

                                        bool res = da.ReactivationOfCancellation(strCancellationID, "True");

                                        //if (res == true)
                                        //{
                                        //    DataGridRefresh();
                                        //}

                                        if (res == false)
                                        {
                                            MessageBox.Show(strCancellationID + ": Unsccessful");
                                        }

                                    }


                                    #endregion
                                }

                                #endregion

                                #region Extra
                                CountCanUpdate = 1;
                                CountCanUpdate = dgList.Rows.Cast<DataGridViewRow>()
                                    .Where(p => Convert.ToBoolean(p.Cells["Approve"].Value) == false).Count();
                                //lbStatus.Items.Add(CountCanUpdate + " " + "Unapproved rows found that's can be update");
                                #endregion

                                #region// Check Approval ? work if true

                                if (bool.Parse(item.Cells[5].Value.ToString()) == true)
                                {


                                    #region // Update Selection Only

                                    if (item.Cells[5].Value.ToString() == "True")
                                    {

                                        string strSelection = item.Cells[0].Value.ToString();
                                        string strCancellationID = item.Cells[1].Value.ToString();
                                        string strRegNo = item.Cells[2].Value.ToString();
                                        string strClientID = item.Cells[3].Value.ToString();
                                        DateTime DTCancellationDate = Convert.ToDateTime(item.Cells[4].Value.ToString());
                                        string strApproval = item.Cells[5].Value.ToString();

                                        //lblSelection.Text = strSelection;

                                        //lblCancellationID.Text = strCancellationID;

                                        //lblRegNo.Text = strRegNo;

                                        //lblClientID.Text = strClientID;

                                        //lblCancellationDate.Text = DTCancellationDate.ToShortDateString();

                                        //lblApproval.Text = strApproval;

                                        MessageBox.Show("Unapproved :" + i);

                                        bool res = da.ReactivationOfCancellation(strCancellationID, "False");

                                        
                                        if (res == false)
                                        {
                                            //lbStatus.Items.Add(lblCancellationID.Text + ": Unsccessful");
                                            MessageBox.Show(strCancellationID + ": Unsccessful");
                                        }

                                    }


                                    #endregion
                                }

                                #endregion
                            
                            }


                            #endregion
                        }


                        #endregion
                  
                    #endregion



                }


                #region      /////////////////// Member Status in Member Registraion


                if (info1.strStatus != "" || info1.strStatus != null)
                {

                    if (info1.strStatus == "Cancelled")
                    {

                       // result = da.UpdateMemberRegistrationAfterCancellation(txtRegistrationNo.Text.Trim(), "Renew");
                    }

                    if (result == true)
                    {
                        MessageBox.Show("Successfully Marked For Reactivation");
                    }

                    #region Extra
                    //if (result == false)
                    //{
                    //    MessageBox.Show("An Error Occoured While Updation Process");
                    //}

                    //if (result == true)
                    //{
                    //    MessageBox.Show("Reactivation marked successfuly against following  Client ID :" + txtClientID.Text);
                    //}
                    #endregion
                }

                #endregion


            }

            DataGridRefresh();
        
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            DataGridRefresh();

        }




        public void DataGridRefresh()
        {
         
            bool approval = false;


            if (txtStatus.Text == "Approved" || txtStatus.Text == "approved")
            {
                approval = true;
            }
            if (txtStatus.Text == "unpproved" || txtStatus.Text == "Unpproved")
            {
                approval = false;
            }

            dgList.Rows.Clear();
            List<clsMemberStatusFilter> canmem = da.GetMemberByStatus(approval);

            if (canmem != null)
            {
                foreach (clsMemberStatusFilter mem in canmem)
                {
                    int intRowIndex = dgList.Rows.Add();
                    dgList.Rows[intRowIndex].Cells["RegistrationNo"].Value = mem.strRegistrationNo;
                    dgList.Rows[intRowIndex].Cells["ClientID"].Value = mem.strClientID;
                    dgList.Rows[intRowIndex].Cells["CancellationDate"].Value = mem.dtCancellationDate.ToShortDateString();
                    dgList.Rows[intRowIndex].Cells["Approve"].Value = mem.boolApprove.ToString();
                    dgList.Rows[intRowIndex].Cells["Remarks"].Value = mem.strRemarks;
                    dgList.Rows[intRowIndex].Cells["id"].Value = mem.id;


                }
            }

            if (canmem == null)
            {
                MessageBox.Show("No Record for approval");
            }

        }

        private void txtStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridRefresh();
        }


     
    }
}
