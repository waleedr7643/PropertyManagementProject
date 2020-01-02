using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TMR.GP.REMSDal
{
    public partial class DataAccess
    {
        public bool AddProspectPlan(clsProspect info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {

                            using (SqlCommand cmd = new SqlCommand("TMR_USP_AddProspect"))
                            {

                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Connection = conn;
                                cmd.Parameters.AddWithValue("@ProjectNo", info.ProjectNo);
                                cmd.Parameters.AddWithValue("@Sector", info.Sector);
                                cmd.Parameters.AddWithValue("@Unit", info.UPlot);
                                cmd.Parameters.AddWithValue("@ProspectName", info.ProspectName);
                                cmd.Parameters.AddWithValue("@ProspectFatherName", info.ProspectFatherName);
                                cmd.Parameters.AddWithValue("@CNIC", info.CNIC);
                                cmd.Parameters.AddWithValue("@ContactNo", info.ContactNo);
                                cmd.Parameters.AddWithValue("@ProspectPaymentPlan", info.ProspectPaymentPlan);
                                cmd.Parameters.AddWithValue("@SizeCode", info.SizeCode);
                                cmd.Parameters.AddWithValue("@ProspectStartDate", info.ProspectStartDate);
                                cmd.Parameters.AddWithValue("@UnitType", info.UnitType);
                                cmd.Parameters.AddWithValue("@UnitCategory", info.UnitCategory);
                                cmd.Parameters.AddWithValue("@UnitAdditionalChrg", info.UnitAdditionalChrg);
                                cmd.Parameters.AddWithValue("@PlotPrice", info.PlotPrice);
                                cmd.Parameters.AddWithValue("@PlotAdditionalCharges", info.PlotAdditionalCharges);
                                cmd.Parameters.AddWithValue("@TotalPrice", info.TotalPrice);
                                cmd.Parameters.AddWithValue("@Discount", info.Discount);                              
                                cmd.Parameters.AddWithValue("@id", info.id);

                                st = cmd.ExecuteNonQuery();

                            }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex) { }
            if (st > 0)
                return true;
            else
                return false;
        }
        public List<clsProspect> GetAllProspects(string projectid, DateTime startdate, DateTime enddate)
        {
            List<clsProspect> lst = new List<clsProspect>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetProspect"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@projectid", projectid);
                    cmd.Parameters.AddWithValue("@StartDate", startdate);
                    cmd.Parameters.AddWithValue("@EndDate", enddate);


                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsProspect();

                        info.ProjectNo = reader["ProjectNo"].ToString();
                        info.Sector = reader["Sector"].ToString();
                        info.UPlot = reader["Unit"].ToString();
                        info.ProspectName = reader["ProspectName"].ToString();
                        info.ProspectFatherName = reader["ProspectFatherName"].ToString();
                        info.CNIC = reader["CNIC"].ToString();
                        info.ContactNo = reader["ContactNo"].ToString();
                        info.ProspectPaymentPlan = reader["ProspectPaymentPlan"].ToString();
                        info.SizeCode = reader["SizeCode"].ToString();
                        info.ProspectStartDate = Convert.ToDateTime(reader["ProspectStartDate"].ToString());
                        info.UnitType = reader["UnitType"].ToString();
                        info.UnitCategory = reader["UnitCategory"].ToString();
                        info.UnitAdditionalChrg = Convert.ToDecimal(reader["UnitAdditionalChrg"]);
                        info.PlotPrice = Convert.ToDecimal(reader["PlotPrice"]);
                        info.PlotAdditionalCharges = Convert.ToDecimal(reader["PlotAdditionalCharges"]);
                        info.TotalPrice = Convert.ToDecimal(reader["TotalPrice"]);
                        info.Discount = Convert.ToDecimal(reader["Discount"]);
                        info.id = Convert.ToInt32(reader["id"].ToString());
                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        }

        public clsProspect GetProspectByID(int prosid)
        {
            clsProspect info = new clsProspect();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetProspectByID"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@id", prosid);
                    

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        
                        info.ProjectNo = reader["ProjectNo"].ToString();
                        info.Sector = reader["Sector"].ToString();
                        info.UPlot = reader["Unit"].ToString();
                        info.ProspectName = reader["ProspectName"].ToString();
                        info.ProspectFatherName = reader["ProspectFatherName"].ToString();
                        info.CNIC = reader["CNIC"].ToString();
                        info.ContactNo = reader["ContactNo"].ToString();
                        info.ProspectPaymentPlan = reader["ProspectPaymentPlan"].ToString();
                        info.SizeCode = reader["SizeCode"].ToString();
                        info.ProspectStartDate = Convert.ToDateTime(reader["ProspectStartDate"].ToString());
                        info.UnitType = reader["UnitType"].ToString();
                        info.UnitCategory = reader["UnitCategory"].ToString();
                        info.UnitAdditionalChrg = Convert.ToDecimal(reader["UnitAdditionalChrg"]);
                        info.PlotPrice = Convert.ToDecimal(reader["PlotPrice"]);
                        info.PlotAdditionalCharges = Convert.ToDecimal(reader["PlotAdditionalCharges"]);
                        info.TotalPrice = Convert.ToDecimal(reader["TotalPrice"]);
                        info.Discount = Convert.ToDecimal(reader["Discount"]);
                        info.id = Convert.ToInt32(reader["id"].ToString());

                        
                    }
                    conn.Close();
                }
            }
            return info;
        }
    }
}