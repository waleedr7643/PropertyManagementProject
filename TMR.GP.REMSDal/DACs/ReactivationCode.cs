using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TMR.GP.REMSDal
{
    public partial class DataAccess
    {
        /// <summary>
        /// Add Reactivation Info
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool AddReActivation(clsReactivation info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddReActivation"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@id", info.id);
                            cmd.Parameters.AddWithValue("@RegistrationNo", info.RegistrationOrBookingNo);
                            cmd.Parameters.AddWithValue("@ClientID", info.ClientID);
                            cmd.Parameters.AddWithValue("@ProjectID", info.strProjectid);
                            cmd.Parameters.AddWithValue("@ReactivationDate", info.ReActivationDate);
                            cmd.Parameters.AddWithValue("@Approve", info.Approved);
                            cmd.Parameters.AddWithValue("@Remarks", info.Remarks);
                            cmd.Parameters.AddWithValue("@ApprovalStatusCode", info.ApprovalStatusCode);
                            cmd.Parameters.AddWithValue("@ApprovalActionUser", info.ApprovalActionUser);
                            cmd.Parameters.AddWithValue("@ApprovalActionDate", info.ApprovalActionDate);
                            cmd.Parameters.AddWithValue("@CreatedBy", info.CreatedBy);
                            cmd.Parameters.AddWithValue("@CreationDate", info.CreationDate);
                            cmd.Parameters.AddWithValue("@LastUpdateUser", info.LastUpdateUser);
                            cmd.Parameters.AddWithValue("@LastUpdateDate", info.LastUpdateDate);
                            cmd.Parameters.AddWithValue("@PreviousStatusCode", info.intPreviousStatusCode);
                           


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

        /// <summary>
        /// Get All Reactivation Info
        /// </summary>
        /// <returns></returns>
        /// 
        public List<clsReactivation> GetAllReactivationList(clsDocumentFilter clsdoc)
        {
            List<clsReactivation> lst = new List<clsReactivation>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetAllReactivations"))
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
                        var info = new clsReactivation();

                        info.RegistrationOrBookingNo = reader["RegistrationNo"].ToString();
                        info.ClientID = reader["ClientID"].ToString();
                        info.ReActivationDate = Convert.ToDateTime(reader["ReActivationDate"].ToString());
                        info.Approved = Convert.ToBoolean(reader["Approve"].ToString());
                        info.Remarks = reader["Remarks"].ToString();
                        info.strProjectid = reader["ProjectID"].ToString();
                        info.ApprovalStatusCode = Convert.ToInt32(reader["ApprovalStatusCode"].ToString());
                        info.ApprovalStatusDescription = reader["ApprovalStatusDescription"].ToString();
                        info.ApprovalActionUser = reader["ApprovalActionUser"].ToString();
                        info.ApprovalActionDate = Convert.ToDateTime(reader["ApprovalActionDate"]);
                        info.CreatedBy = reader["CreatedBy"].ToString();
                        info.CreationDate = Convert.ToDateTime(reader["CreationDate"].ToString());
                        info.LastUpdateUser = reader["LastUpdateUser"].ToString();
                        info.LastUpdateDate = Convert.ToDateTime(reader["LastUpdateDate"]);
                        info.intPreviousStatusCode = Convert.ToInt32(reader["PreviousStatusCode"].ToString());
                        info.StatusDescription = reader["StatusDescription"].ToString();
                        info.id = Convert.ToInt32(reader["id"].ToString());
              

                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }
       
        /// <summary>
        /// Updte Cancellation Status only Unapproved
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Approval"></param>
        /// <returns></returns>
        public bool ReactivationOfCancellation(string id, string Approval)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_UpdateCancellation"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@Approve", Approval);

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
        
        #region GetReactivationById
        //public clsReactivation GetReactivationById(int id)
        //{
        //    clsReactivation obj = new clsReactivation();
        //    using (SqlConnection conn = new SqlConnection(strConn))
        //    {
        //        conn.Open();

        //        using (SqlCommand cmd = new SqlCommand("TMR_USP_GetReactivationByID"))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Connection = conn;
        //            cmd.Parameters.AddWithValue("@id", id);

        //            //cmd.Parameters.AddWithValue("@SizeCode", strSizeCode);
        //            SqlDataReader reader = cmd.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                obj.RegistrationOrBookingNo = reader["RegistrationNo"].ToString();
        //                obj.ClientID = reader["ClientID"].ToString();
        //                obj.Remarks = reader["Remarks"].ToString();
        //                obj.ReActivationDate = Convert.ToDateTime(reader["ReActivationDate"]);
        //                obj.Approved = Convert.ToBoolean(reader["Approve"]);
        //                obj.id = Convert.ToInt32(reader["id"]);


        //            }
        //            conn.Close();
        //        }
        //    }
        //    return obj;
        //}
        #endregion

        public clsReactivation GetReactivationById(int id)
        {
            clsReactivation info = new clsReactivation();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetReactivationByID"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@id", id);

                    //cmd.Parameters.AddWithValue("@SizeCode", strSizeCode);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        info.RegistrationOrBookingNo = reader["RegistrationNo"].ToString();
                        info.ClientID = reader["ClientID"].ToString();
                        info.strProjectid = reader["ProjectID"].ToString();
                        info.ReActivationDate = Convert.ToDateTime(reader["ReActivationDate"]);
                        info.Approved = Convert.ToBoolean(reader["Approve"].ToString());
                        info.Remarks = reader["Remarks"].ToString();
                        info.intPreviousStatusCode = Convert.ToInt32(reader["PreviousStatusCode"]);
                        info.ApprovalStatusCode = Convert.ToInt32(reader["ApprovalStatusCode"].ToString());
                        info.ApprovalStatusDescription = reader["ApprovalStatusDescription"].ToString();
                        info.ApprovalActionUser = reader["ApprovalActionUser"].ToString();
                        info.ApprovalActionDate = Convert.ToDateTime(reader["ApprovalActionDate"].ToString());
                        info.CreatedBy = reader["CreatedBy"].ToString();
                        info.CreationDate = Convert.ToDateTime(reader["CreationDate"].ToString());
                        info.LastUpdateUser = reader["LastUpdateUser"].ToString();
                        info.LastUpdateDate = Convert.ToDateTime(reader["LastUpdateDate"].ToString());
                        info.id = Convert.ToInt32(reader["id"]);

                    }
                    conn.Close();
                }
            }
            return info;
        }
        
    }
}