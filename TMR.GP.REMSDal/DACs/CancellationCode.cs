using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TMR.GP.REMSDal
{
    public partial class DataAccess
    {
       
        public bool AddCancellationInfo(clsCancellation info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddCancellation"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@id", info.id);
                            cmd.Parameters.AddWithValue("@RegistrationNo", info.RegistrationOrBookingNo);
                            cmd.Parameters.AddWithValue("@ProjectID", info.strProjectid);
                            cmd.Parameters.AddWithValue("@Block", info.strBlock);
                            cmd.Parameters.AddWithValue("@UnitID", info.strUnitID);
                            cmd.Parameters.AddWithValue("@ClientID", info.ClientID);
                            cmd.Parameters.AddWithValue("@CancellationDate", info.CancellationDate.Date);
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

        public List<clsCancellation> GetAllCancellationList(clsDocumentFilter clsdoc)
        {
            List<clsCancellation> lst = new List<clsCancellation>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetAllCancellation"))
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
                        var info = new clsCancellation();

                        info.RegistrationOrBookingNo = reader["RegistrationNo"].ToString();
                        info.ClientID = reader["ClientID"].ToString();
                        info.strProjectid = reader["ProjectID"].ToString();
                        info.strBlock = reader["Block"].ToString();
                        info.strUnitID = reader["UnitID"].ToString();
                        info.CancellationDate = Convert.ToDateTime(reader["CancellationDate"]);
                        info.Approved = Convert.ToBoolean(reader["Approve"].ToString());
                        info.Remarks = reader["Remarks"].ToString();
                        info.ApprovalStatusCode = Convert.ToInt32(reader["ApprovalStatusCode"]);
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

        public clsCancellation GetCancellationById(int id)
        {
            clsCancellation info = new clsCancellation();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetCancellationByID"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@id", id);

                    //cmd.Parameters.AddWithValue("@SizeCode", strSizeCode);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        info.RegistrationOrBookingNo = reader["RegistrationNo"].ToString();
                        info.strProjectid = reader["ProjectID"].ToString();
                        info.strBlock = reader["Block"].ToString();
                        info.strUnitID = reader["UnitID"].ToString();
                        info.ClientID = reader["ClientID"].ToString();
                        info.CancellationDate = Convert.ToDateTime(reader["CancellationDate"]);
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

        public bool UpdateMemberRegistrationAfterCancellation(clsMemberRegistration info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_UpdateMemRegAfterCancellation"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@RegistrationNo", info.RegistrationNo);
                            cmd.Parameters.AddWithValue("@ClientID", info.ClientID);
                            cmd.Parameters.AddWithValue("@StatusCode", info.intStatusCode);

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
        /// Filter Member with status
        /// </summary>
        /// <param name="strProject"></param>
        /// <param name="strBlock"></param>
        /// <returns></returns>
        public List<clsMemberStatusFilter> GetMemberByStatus(bool approve)
        {


            List<clsMemberStatusFilter> lst = new List<clsMemberStatusFilter>();


            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                try
                {

                    using (SqlCommand cmd = new SqlCommand("TMR_USP_GetCancellationByStatus"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@Approve", approve);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            var info = new clsMemberStatusFilter();

                            info.strRegistrationNo = reader["RegistrationNo"].ToString();
                            info.strClientID = reader["ClientID"].ToString();
                           
                            info.dtCancellationDate = Convert.ToDateTime(reader["CancellationDate"].ToString());
                            info.boolApprove = Convert.ToBoolean(reader["Approve"].ToString());
                            info.strRemarks = reader["Remarks"].ToString();
                            info.id = reader["id"].ToString();


                            lst.Add(info);

                        }
                        conn.Close();
                    }


                }

                catch (Exception ex) { }

            }

            return lst;
        }

        /// <summary>
        /// Get Cancellation Status Info
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public List<clsMemberRegistration> GetMemberByStatusFromMemberRegistration(string status)
        {


            List<clsMemberRegistration> lst = new List<clsMemberRegistration>();


            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                try
                {

                    using (SqlCommand cmd = new SqlCommand("TMR_USP_GetCancellationByStatus"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@Status", status);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {

                            clsMemberRegistration info = new clsMemberRegistration();

                            info.RegistrationNo = reader["RegistrationNo"].ToString();
                            info.ClientID = reader["ClientID"].ToString();
                            info.Name = reader["Name"].ToString();
                            info.FatherOrHusbandType = reader["FatherOrHusbandType"].ToString();
                            info.FatherOrHusband = reader["FatherOrHusbandName"].ToString();
                            info.NIDOrCNIC = reader["CNIC"].ToString();
                            info.Nationality = reader["Nationality"].ToString();
                            info.DOB = Convert.ToDateTime(reader["DOB"].ToString());
                            info.CurrentAddress1 = reader["CurrentAddress1"].ToString();
                            info.CurrentAddress2 = reader["CurrentAddress2"].ToString();
                            info.CurrentAddress3 = reader["CurrentAddress3"].ToString();
                            info.Country = reader["Country"].ToString();
                            info.City = reader["City"].ToString();
                            info.PhOff = reader["PhOff"].ToString();
                            info.Res = reader["Res"].ToString();
                            info.Mob = reader["Mob"].ToString();
                            info.Fax = reader["Fax"].ToString();
                            info.EmailAddress = reader["EmailAddress"].ToString();
                            info.Plan = reader["Plan"].ToString();
                            info.Booking = Convert.ToDateTime(reader["Booking"].ToString());
                            info.strProjectid = reader["ProjectID"].ToString();
                            info.Block = reader["Block"].ToString();
                            info.Plot = reader["Plot"].ToString();
                            info.UnitRate = Convert.ToDecimal(reader["UnitRate"].ToString());
                            info.TotalPrice = Convert.ToDecimal(reader["TotalPrice"].ToString());
                            info.FinanceAmt = Convert.ToDecimal(reader["FinanceAmt"].ToString());
                            info.RebatAmt = Convert.ToDecimal(reader["RebatAmt"].ToString());
                            info.NetOrRetailPrice = Convert.ToDecimal(reader["NetPrice"].ToString());
                            info.BookingPrice = Convert.ToDecimal(reader["BookingPrice"].ToString());


                            lst.Add(info);

                        }
                        conn.Close();
                    }


                }

                catch (Exception ex) { }

            }

            return lst;
        }


    }
}