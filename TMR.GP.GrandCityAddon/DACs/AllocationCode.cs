using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TMR.GP.GrandCityAddon
{
    public partial class DataAccess
    {
        public bool AddAllocationINFO(clsAllocation info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddAllocation"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@id", info.id);
                            cmd.Parameters.AddWithValue("@RegistrationNo", info.RegistrationOrBookingNo);
                            cmd.Parameters.AddWithValue("@ProjectID", info.strProjectid);
                            cmd.Parameters.AddWithValue("@Block", info.strBlock);
                            cmd.Parameters.AddWithValue("@UnitID", info.strUnitID);
                            cmd.Parameters.AddWithValue("@ClientID", info.strClientID);
                            cmd.Parameters.AddWithValue("@AllocationDate", info.dtAllocationDate);
                            cmd.Parameters.AddWithValue("@Approve", info.bitApprove);
                            cmd.Parameters.AddWithValue("@DirectorName", info.strDirector);
                            cmd.Parameters.AddWithValue("@Remarks", info.strRemarks);
                            cmd.Parameters.AddWithValue("@ApprovalStatusCode", info.ApprovalStatusCode);                            
                            cmd.Parameters.AddWithValue("@ApprovalActionUser", info.ApprovalActionUser);
                            cmd.Parameters.AddWithValue("@ApprovalActionDate", info.ApprovalActionDate);
                            cmd.Parameters.AddWithValue("@CreatedBy", info.CreatedBy);
                            cmd.Parameters.AddWithValue("@CreationDate", info.CreationDate);
                            cmd.Parameters.AddWithValue("@LastUpdateUser", info.LastUpdateUser);
                            cmd.Parameters.AddWithValue("@LastUpdateDate", info.LastUpdateDate);
                            cmd.Parameters.AddWithValue("@StatusCode", info.intPreviousStatusCode);
                           
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
        public clsAllocation GetAllocationByID(int id)
        {
            clsAllocation info = new clsAllocation();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetAllocationByID"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    //conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        info.RegistrationOrBookingNo = reader["RegistrationNo"].ToString();
                        info.strProjectid = reader["ProjectID"].ToString();
                        info.strBlock = reader["Block"].ToString();
                        info.strUnitID = reader["UnitID"].ToString();
                        info.strClientID = reader["ClientID"].ToString();
                        info.dtAllocationDate = Convert.ToDateTime(reader["AllocationDate"]);
                        info.bitApprove = Convert.ToBoolean(reader["Approve"].ToString());
                        info.strRemarks = reader["Remarks"].ToString();
                        info.strDirector = reader["DirectorName"].ToString();
                        info.ApprovalStatusCode = Convert.ToInt32(reader["ApprovalStatusCode"].ToString());
                        info.ApprovalStatusDescription = reader["ApprovalStatusDescription"].ToString();
                        info.ApprovalActionUser = reader["ApprovalActionUser"].ToString();
                        info.ApprovalActionDate = Convert.ToDateTime(reader["ApprovalActionDate"].ToString());
                        info.CreatedBy = reader["CreatedBy"].ToString();
                        info.CreationDate = Convert.ToDateTime(reader["CreationDate"].ToString());
                        info.LastUpdateUser = reader["LastUpdateUser"].ToString();
                        info.LastUpdateDate = Convert.ToDateTime(reader["LastUpdateDate"].ToString());
                        info.intPreviousStatusCode = Convert.ToInt32(reader["PreviousStatusCode"]);
                        info.id = Convert.ToInt32(reader["id"]);

                    }
                    conn.Close();
                }
            }
            return info;
        }
        public bool UpdateMemberRegistrationAfterAllocation(clsMemberRegistration info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_UpdateMemRegAtAllocation"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@RegistrationNo", info.RegistrationNo);
                            cmd.Parameters.AddWithValue("@ClientID", info.ClientID);                            
                            cmd.Parameters.AddWithValue("@Block", info.Block);
                            cmd.Parameters.AddWithValue("@Plot", info.Plot);                            
                            cmd.Parameters.AddWithValue("@Allocated", info.bitAllocated);
                            cmd.Parameters.AddWithValue("@StatusCode", info.intStatusCode);
                            cmd.Parameters.AddWithValue("@DirectorName", string.IsNullOrEmpty(info.strDirectorName) ? string.Empty : info.strDirectorName);

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
        public List<clsAllocation> GetAllAllocationList(clsDocumentFilter clsdoc)
        {
            List<clsAllocation> lst = new List<clsAllocation>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetAllAllocations"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@RegistrationNo", clsdoc.strRegistrationNo);
                    cmd.Parameters.AddWithValue("@ProjectID", clsdoc.strProjectID);
                    cmd.Parameters.AddWithValue("@ClientID", clsdoc.strClientID);
                    cmd.Parameters.AddWithValue("@StartDate", clsdoc.dateStartDate);
                    cmd.Parameters.AddWithValue("@EndDate", clsdoc.dateEndDate);
                    cmd.Parameters.AddWithValue("@ApprovalStatusCode", clsdoc.intApprovalStatusCode);
                    

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsAllocation();

                        info.RegistrationOrBookingNo = reader["RegistrationNo"].ToString();
                        info.strProjectid = reader["ProjectID"].ToString();
                        info.strBlock = reader["Block"].ToString();
                        info.strUnitID = reader["UnitID"].ToString();
                        info.strClientID = reader["ClientID"].ToString();
                        info.dtAllocationDate = Convert.ToDateTime(reader["AllocationDate"]);
                        info.bitApprove = Convert.ToBoolean(reader["Approve"]);
                        info.strRemarks = reader["Remarks"].ToString();
                        info.ApprovalStatusCode = Convert.ToInt32(reader["ApprovalStatusCode"].ToString());
                        info.ApprovalStatusDescription = reader["ApprovalStatusDescription"].ToString();
                        info.ApprovalActionUser = reader["ApprovalActionUser"].ToString();
                        info.ApprovalActionDate = Convert.ToDateTime(reader["ApprovalActionDate"]);
                        info.CreatedBy = reader["CreatedBy"].ToString();
                        info.CreationDate = Convert.ToDateTime(reader["CreationDate"].ToString());
                        info.LastUpdateUser = reader["LastUpdateUser"].ToString();
                        info.LastUpdateDate = Convert.ToDateTime(reader["LastUpdateDate"]);
                        info.intPreviousStatusCode = Convert.ToInt32(reader["PreviousStatusCode"]);
                        info.StatusDescription = reader["StatusDescription"].ToString();
                        info.id = Convert.ToInt32(reader["id"].ToString());
                        
                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }

   

       
    }
}