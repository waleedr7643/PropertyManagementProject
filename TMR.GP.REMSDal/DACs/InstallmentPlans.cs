using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TMR.GP.REMSDal
{
    public partial class DataAccess
    {
        public bool AddInstallmentPlan(clsInstallmentPlan info, ref int id)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddInstallmentPlan"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@IntallmentPlanCode", info.strIntallmentPlanCode);
                            cmd.Parameters.AddWithValue("@InstallmentPlanName", info.strInstallmentPlanName);
                            cmd.Parameters.AddWithValue("@Inactive", info.bInactive);
                            cmd.Parameters.AddWithValue("@InstallmentFrequency", info.intInstallmentFrequency);
                            cmd.Parameters.AddWithValue("@SizeCode", info.strSizeCode);
                            cmd.Parameters.AddWithValue("@ProjectNo", info.strProjectNo);
                            cmd.Parameters.AddWithValue("@id", info.intId);
                            cmd.Parameters.AddWithValue("@NoOfInstallments", info.intNoOfInstallments);
                            cmd.Parameters.AddWithValue("@StartAfterMonths", info.intInstallmentStartAfter);
                            cmd.Parameters.AddWithValue("@InstallmentAmount", info.decInstallmentAmount);

                            SqlParameter parm = new SqlParameter();
                            parm.ParameterName = "@Outid";
                            parm.SqlDbType = SqlDbType.Int;
                            parm.Direction = ParameterDirection.Output;
                            //parm.Value = info.id;

                            cmd.Parameters.Add(parm);

                            st = cmd.ExecuteNonQuery();

                            id = (int)parm.Value;
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
        public bool AddInstallmentPlanDetail(clsInstallmentPlanDetails info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddInstallmentPlanDetails"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            
                            cmd.Parameters.AddWithValue("@IntallmentPlanCode", info.strInstallmentPlanCode);
                            cmd.Parameters.AddWithValue("@IntallmentPlanID", info.intInstallmentPlanID);
                            cmd.Parameters.AddWithValue("@InstallmentType", info.intInstallmentType);
                            cmd.Parameters.AddWithValue("@InstallmentDueAfterMonths", info.intInstallmentDueAfterMonths);
                            cmd.Parameters.AddWithValue("@InstallmentPercentage", info.decInstallmentPercentage);
                            cmd.Parameters.AddWithValue("@InstallmentNumber", info.intInstallmentNumber);
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
        public List<clsInstallmentPlan> GetInstallmentPlans()
        {
            List<clsInstallmentPlan> lst = new List<clsInstallmentPlan>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetInstallmentPlans"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    
                    
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsInstallmentPlan();

                        info.strInstallmentPlanName = reader["InstallmentPlanName"].ToString();
                        info.bInactive = Convert.ToBoolean(reader["Inactive"]);
                        info.strIntallmentPlanCode = reader["IntallmentPlanCode"].ToString();
                        info.intId = Convert.ToInt32(reader["id"].ToString());
                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public clsInstallmentPlan GetInstallmentPlanById(int id)
        {
            clsInstallmentPlan info = new clsInstallmentPlan();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetInstallmentPlanById"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        info.strInstallmentPlanName = reader["InstallmentPlanName"].ToString();
                        info.bInactive = Convert.ToBoolean(reader["Inactive"]);
                        info.strIntallmentPlanCode = reader["IntallmentPlanCode"].ToString();
                        info.intInstallmentFrequency = Convert.ToInt32(reader["InstallmentFrequency"]);                        
                        info.intNoOfInstallments = Convert.ToInt32(reader["NoOfInstallments"]);
                        info.intInstallmentStartAfter = Convert.ToInt32(reader["StartAfterMonths"]);
                        info.decInstallmentAmount = Convert.ToDecimal(reader["InstallmentAmount"]);

                        info.strProjectNo = Convert.ToString(reader["ProjectNo"]);
                        info.strSizeCode = Convert.ToString(reader["SizeCode"]);
                        info.intId = Convert.ToInt32(reader["id"].ToString());
                    }
                    conn.Close();
                }
            }
            return info;
        }
        public List<clsInstallmentPlanDetails> GetInstallmentPlanDetailsByPlanId(int id)
        {
            List<clsInstallmentPlanDetails> lst = new List<clsInstallmentPlanDetails>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetInstallmentPlanDetails"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@InstallmentPlanid", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsInstallmentPlanDetails();
                        info.intId = Convert.ToInt32(reader["id"]);
                        info.strInstallmentPlanCode = reader["InstallmentPlanCode"].ToString();
                        info.intInstallmentPlanID = Convert.ToInt32(reader["InstallmentPlanID"]);
                        info.intInstallmentType = Convert.ToInt32(reader["InstallmentType"]);
                        info.strInstallmentTypeName = reader["InstallmentTypeName"].ToString();
                        info.intInstallmentDueAfterMonths = Convert.ToInt32(reader["InstallmentDueAfterMonths"]);
                        info.decInstallmentPercentage = Convert.ToDecimal(reader["InstallmentPercentage"]);
                        info.intInstallmentNumber = Convert.ToInt32(reader["InstallmentNumber"]);

                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public List<clsInstallmentPlanDetails> GetInstallmentPlanDetailsByPlanCode(string id)
        {
            List<clsInstallmentPlanDetails> lst = new List<clsInstallmentPlanDetails>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetInstallmentPlanDetailsByPlanCode"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@InstallmentPlanCode", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsInstallmentPlanDetails();
                        info.intId = Convert.ToInt32(reader["id"]);
                        info.strInstallmentPlanCode = reader["InstallmentPlanCode"].ToString();
                        info.intInstallmentPlanID = Convert.ToInt32(reader["InstallmentPlanID"]);
                        info.intInstallmentType = Convert.ToInt32(reader["InstallmentType"]);
                        info.strInstallmentTypeName = reader["InstallmentTypeName"].ToString();
                        info.intInstallmentDueAfterMonths = Convert.ToInt32(reader["InstallmentDueAfterMonths"]);
                        info.decInstallmentPercentage = Convert.ToDecimal(reader["InstallmentPercentage"]);
                        info.intInstallmentNumber = Convert.ToInt32(reader["InstallmentNumber"]);

                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public clsInstallmentPlan GetInstallmentPlanByPlanCode(string InstallmentPlan)
        {
            clsInstallmentPlan info = new clsInstallmentPlan();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetInstallmentPlansBySizecode"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@InstallmentPlan", InstallmentPlan);
                    
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        info.strInstallmentPlanName = reader["InstallmentPlanName"].ToString();
                        info.bInactive = Convert.ToBoolean(reader["Inactive"]);
                        info.strIntallmentPlanCode = reader["IntallmentPlanCode"].ToString();
                        info.intInstallmentFrequency = Convert.ToInt32(reader["InstallmentFrequency"]);
                        info.intNoOfInstallments = Convert.ToInt32(reader["NoOfInstallments"]);
                        info.intInstallmentStartAfter = Convert.ToInt32(reader["StartAfterMonths"]);
                        info.decInstallmentAmount = Convert.ToDecimal(reader["InstallmentAmount"]);
                        info.strSizeCode = Convert.ToString(reader["SizeCode"]);
                        info.strProjectNo = Convert.ToString(reader["ProjectNo"]);
                        info.intId = Convert.ToInt32(reader["id"].ToString());
                    }
                    conn.Close();
                }
            }
            return info;
        }
        public List<clsInstallmentPlan> GetInstallmentPlanByProjectSizeCode(string sizecode, string strProject)
        {
            List<clsInstallmentPlan> lst = new List<clsInstallmentPlan>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetInstallmentPlansBySizecodeProject"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@Sizecode", sizecode);
                    cmd.Parameters.AddWithValue("@ProjectNo", strProject);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsInstallmentPlan();
                        info.strInstallmentPlanName = reader["InstallmentPlanName"].ToString();
                        info.bInactive = Convert.ToBoolean(reader["Inactive"]);
                        info.strIntallmentPlanCode = reader["IntallmentPlanCode"].ToString();
                        info.intInstallmentFrequency = Convert.ToInt32(reader["InstallmentFrequency"]);
                        info.intNoOfInstallments = Convert.ToInt32(reader["NoOfInstallments"]);
                        info.intInstallmentStartAfter = Convert.ToInt32(reader["StartAfterMonths"]);
                        info.decInstallmentAmount = Convert.ToDecimal(reader["InstallmentAmount"]);
                        info.strSizeCode = Convert.ToString(reader["SizeCode"]);
                        info.strProjectNo = Convert.ToString(reader["ProjectNo"]);
                        info.intId = Convert.ToInt32(reader["id"].ToString());
                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        } 
    }

}