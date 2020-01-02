using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TMR.GP.GrandCityAddon
{
    public partial class DataAccess
    {
        public bool AddTransferHistory(clsTransferHistory info, ref int id)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddTransferHistory"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@RegistrationNo", info.strRegistrationNo);
                            cmd.Parameters.AddWithValue("@TransferFromID", info.strTransferFromID);
                            cmd.Parameters.AddWithValue("@TransferToID", info.strTransferToID);
                            cmd.Parameters.AddWithValue("@TransferDate", info.dtTransferDate);
                            cmd.Parameters.AddWithValue("@Name", info.strName);
                            cmd.Parameters.AddWithValue("@FatherOrHusbandType", info.strFatherOrHusbandType);
                            cmd.Parameters.AddWithValue("@FatherOrHusbandName", info.strFatherOrHusband);
                            cmd.Parameters.AddWithValue("@CNIC", info.strNIDOrCNIC);
                            cmd.Parameters.AddWithValue("@Nationality", info.strNationality);
                            cmd.Parameters.AddWithValue("@DOB", info.dtDOB);
                            cmd.Parameters.AddWithValue("@CurrentAddress1", info.strCurrentAddress1);
                            cmd.Parameters.AddWithValue("@CurrentAddress2", info.strCurrentAddress2);
                            cmd.Parameters.AddWithValue("@CurrentAddress3", info.strCurrentAddress3);
                            cmd.Parameters.AddWithValue("@Country", info.strCountry);
                            cmd.Parameters.AddWithValue("@City", info.strCity);
                            cmd.Parameters.AddWithValue("@PhOff", info.strPhOff);
                            cmd.Parameters.AddWithValue("@Res", info.strRes);
                            cmd.Parameters.AddWithValue("@Mob", info.strMob);
                            cmd.Parameters.AddWithValue("@EmailAddress", info.strEmailAddress);
                            cmd.Parameters.AddWithValue("@ApprovalStatusCode", info.ApprovalStatusCode);
                            cmd.Parameters.AddWithValue("@ApprovalActionUser", info.ApprovalActionUser);
                            cmd.Parameters.AddWithValue("@ApprovalActionDate", info.ApprovalActionDate);
                            cmd.Parameters.AddWithValue("@CreatedBy", info.CreatedBy);
                            cmd.Parameters.AddWithValue("@CreationDate", info.CreationDate);
                            cmd.Parameters.AddWithValue("@LastUpdateUser", info.LastUpdateUser);
                            cmd.Parameters.AddWithValue("@LastUpdateDate", info.LastUpdateDate);
                            cmd.Parameters.AddWithValue("@ID", info.intID);

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
        public List<clsTransferHistory> GetAllTransferHistoryList(clsDocumentFilter clsdoc)
        {
            List<clsTransferHistory> lst = new List<clsTransferHistory>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetAllTransferHistory"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@RegistrationNo", clsdoc.strRegistrationNo);
                    cmd.Parameters.AddWithValue("@ProjectID", clsdoc.strProjectID);
                    cmd.Parameters.AddWithValue("@TransferFromID", clsdoc.strClientID);
                    cmd.Parameters.AddWithValue("@TransferToID", clsdoc.strToClientID);
                    cmd.Parameters.AddWithValue("@StartDate", clsdoc.dateStartDate);
                    cmd.Parameters.AddWithValue("@EndDate", clsdoc.dateEndDate);
                    cmd.Parameters.AddWithValue("@ApprovalStatusCode", clsdoc.intApprovalStatusCode);
                    
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsTransferHistory();

                        info.intID = Convert.ToInt32(reader["ID"].ToString());
                        info.strRegistrationNo = reader["RegistrationNo"].ToString();
                        info.strTransferFromID = reader["TransferFromID"].ToString();
                        info.strTransferToID = reader["TransferToID"].ToString();
                        info.dtTransferDate = Convert.ToDateTime(reader["TransferDate"]);
                        info.ApprovalStatusCode = Convert.ToInt32(reader["ApprovalStatusCode"].ToString());
                        info.ApprovalStatusDescription = reader["ApprovalStatusDescription"].ToString();
                        info.ApprovalActionUser = reader["ApprovalActionUser"].ToString();
                        info.ApprovalStatusCode = Convert.ToInt32(reader["ApprovalStatusCode"].ToString());
                        info.ApprovalStatusDescription = reader["ApprovalStatusDescription"].ToString();
                        info.ApprovalActionUser = reader["ApprovalActionUser"].ToString();
                        info.ApprovalActionDate = Convert.ToDateTime(reader["ApprovalActionDate"]);
                        info.CreatedBy = reader["CreatedBy"].ToString();
                        info.CreationDate = Convert.ToDateTime(reader["CreationDate"].ToString());
                        info.LastUpdateUser = reader["LastUpdateUser"].ToString();
                        info.LastUpdateDate = Convert.ToDateTime(reader["LastUpdateDate"]);
                        info.strName = reader["Name"].ToString();
                        info.strFatherOrHusbandType = reader["FatherOrHusbandType"].ToString();
                        info.strFatherOrHusband = reader["FatherOrHusbandName"].ToString();
                        info.strNIDOrCNIC = reader["CNIC"].ToString();
                        info.strNationality = reader["Nationality"].ToString();
                        info.dtDOB = Convert.ToDateTime(reader["DOB"].ToString());
                        info.strCurrentAddress1 = reader["CurrentAddress1"].ToString();
                        info.strCurrentAddress2 = reader["CurrentAddress2"].ToString();
                        info.strCurrentAddress3 = reader["CurrentAddress3"].ToString();
                        info.strCountry = reader["Country"].ToString();
                        info.strCity = reader["City"].ToString();
                        info.strPhOff = reader["PhOff"].ToString();
                        info.strRes = reader["Res"].ToString();
                        info.strMob = reader["Mob"].ToString();
                        
                        info.strEmailAddress = reader["EmailAddress"].ToString();



                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public clsTransferHistory GetTransferHistoryById(int id)
        {
            clsTransferHistory info = new clsTransferHistory();
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("TMR_USP_GetTransferHistoryByID"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@ID", id);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows == false)
                            info = null;

                        while (reader.Read())
                        {
                            info = new clsTransferHistory();

                            info.intID = Convert.ToInt32(reader["ID"].ToString());
                            info.strRegistrationNo = reader["RegistrataionNo"].ToString();
                            info.strTransferFromID = reader["TransferFromID"].ToString();
                            info.strTransferToID = reader["TransferToID"].ToString();
                            info.dtTransferDate = Convert.ToDateTime(reader["TransferDate"]);
                            

                            info.strName = reader["Name"].ToString();
                            info.strFatherOrHusbandType = reader["FatherOrHusbandType"].ToString();
                            info.strFatherOrHusband = reader["FatherOrHusbandName"].ToString();
                            info.strNIDOrCNIC = reader["CNIC"].ToString();
                            info.strNationality = reader["Nationality"].ToString();
                            info.dtDOB = Convert.ToDateTime(reader["DOB"].ToString());
                            info.strCurrentAddress1 = reader["CurrentAddress1"].ToString();
                            info.strCurrentAddress2 = reader["CurrentAddress2"].ToString();
                            info.strCurrentAddress3 = reader["CurrentAddress3"].ToString();
                            info.strCountry = reader["Country"].ToString();
                            info.strCity = reader["City"].ToString();
                            info.strPhOff = reader["PhOff"].ToString();
                            info.strRes = reader["Res"].ToString();
                            info.strMob = reader["Mob"].ToString();
                            //info.strFax = reader["Fax"].ToString();
                            info.strEmailAddress = reader["EmailAddress"].ToString();

                            info.ApprovalStatusCode = Convert.ToInt32(reader["ApprovalStatusCode"].ToString());
                            info.ApprovalStatusDescription = reader["ApprovalStatusDescription"].ToString();
                            info.ApprovalActionUser = reader["ApprovalActionUser"].ToString();
                            info.ApprovalStatusCode = Convert.ToInt32(reader["ApprovalStatusCode"].ToString());
                            info.ApprovalStatusDescription = reader["ApprovalStatusDescription"].ToString();
                            info.ApprovalActionUser = reader["ApprovalActionUser"].ToString();
                            info.ApprovalActionDate = Convert.ToDateTime(reader["ApprovalActionDate"]);
                            info.CreatedBy = reader["CreatedBy"].ToString();
                            info.CreationDate = Convert.ToDateTime(reader["CreationDate"].ToString());
                            info.LastUpdateUser = reader["LastUpdateUser"].ToString();
                            info.LastUpdateDate = Convert.ToDateTime(reader["LastUpdateDate"]);


                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception exc)
            {
                info = null;
            }
            finally { }
            return info;
        }
        public bool AddTransferImage(clsTransferImage info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddTransferImage"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@TransferID", info.TransferID);
                            cmd.Parameters.AddWithValue("@RegistrationNo", info.RegistrationNo);
                            cmd.Parameters.AddWithValue("@ClientID", info.ClientID);
                            cmd.Parameters.AddWithValue("@ImageId", info.ImageId);
                            cmd.Parameters.AddWithValue("@Image", info.Image);
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
        public clsTransferImage GetTransferImage(int TransferID)
        {
            clsTransferImage image = new clsTransferImage();

            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("TMR_USP_GetTransferImage"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        //conn.Open();
                        cmd.Parameters.AddWithValue("@TransferID", TransferID);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            image.ImageId = reader["PictureID"].ToString();
                            image.Image = (byte[])reader["Picture"];
                        }
                        conn.Close();
                    }

                }

            }
            catch (Exception ex)
            {
                return image = null;
            }
            return image;
        }
        public bool AddTransferCNIC(clsTransferCNIC info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddTransferCNIC"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@TransferID", info.TransferID);
                            cmd.Parameters.AddWithValue("@RegistrationNo", info.RegistrationNo);
                            cmd.Parameters.AddWithValue("@ClientID", info.ClientID);
                            cmd.Parameters.AddWithValue("@ImageId", info.ImageId);
                            cmd.Parameters.AddWithValue("@Image", info.Image);
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
        public clsTransferCNIC GetTransferCNIC(int TransferID)
        {
            clsTransferCNIC image = new clsTransferCNIC();
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("TMR_USP_GetTransferCNIC"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        //conn.Open();
                        cmd.Parameters.AddWithValue("@TransferID", TransferID);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            image.ImageId = reader["PictureID"].ToString();
                            image.Image = (byte[])reader["Picture"];
                        }
                        conn.Close();
                    }

                }

            }
            catch (Exception ex)
            {
                return image = null;
            }
            return image;
        }
        public bool AddTransferAttachment(clsTransferAttachment attachment)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddTransferAttachment"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@TransferID", attachment.TransferId);
                            cmd.Parameters.AddWithValue("@RegistrationNo", attachment.RegistrationNo);
                            cmd.Parameters.AddWithValue("@ClientID", attachment.ClientID);
                            cmd.Parameters.AddWithValue("@filedata", attachment.FileContents);
                            cmd.Parameters.AddWithValue("@fileName", attachment.FileName);
                            cmd.Parameters.AddWithValue("@remarks", attachment.Remarks);
                            cmd.Parameters.AddWithValue("@filedate", attachment.FileDate);
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
        public clsTransferAttachment GetTransferAttachment(int id)
        {
            clsTransferAttachment attachment1 = new clsTransferAttachment();

            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_GetTransferAttachment"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@id", id);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    attachment1.RegistrationNo = reader["RegistrationNo"].ToString();
                                    attachment1.ClientID = reader["ClientID"].ToString();
                                    attachment1.FileName = reader["fileName"].ToString();
                                    attachment1.FileContents = (byte[])reader["fileData"];
                                }
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex) { }
            return attachment1;
        }
        public List<clsTransferAttachment> GetTransferAttachments(int id)
        {
            List<clsTransferAttachment> attachments = new List<clsTransferAttachment>();

            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_GetTransferAttachments"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@TransferID", id);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    clsTransferAttachment attach = new clsTransferAttachment();

                                    attach.RegistrationNo = reader["RegistrationNo"].ToString();
                                    attach.ClientID = reader["ClientID"].ToString();
                                    attach.FileName = reader["fileName"].ToString();
                                    attach.FileDate = Convert.ToDateTime(reader["FileDate"]);
                                    attach.Remarks = reader["Remarks"].ToString();
                                    attach.id = Convert.ToInt32(reader["id"]);

                                    attachments.Add(attach);
                                }
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex) { }
            return attachments;
        }
        public bool AddMemberImageonTransfer(int Transferid)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddMemberImageOnTansfer"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@TransferID", Transferid);
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
        public bool AddMemberCNIConTransfer(int Transferid)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddMemberCNICOnTansfer"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@TransferID", Transferid);
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

    }
}