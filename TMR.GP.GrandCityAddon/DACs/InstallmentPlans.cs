using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TMR.GP.GrandCityAddon
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
                            cmd.Parameters.AddWithValue("@id", info.intId);

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
                            cmd.Parameters.AddWithValue("@InstallmentPercentage", info.intInstallmentPercentage);
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
                        info.intInstallmentPercentage = Convert.ToInt32(reader["InstallmentPercentage"]);
                        info.intInstallmentNumber = Convert.ToInt32(reader["InstallmentNumber"]);

                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        }
       
    }

}