using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TMR.GP.REMSDal
{
    public partial class DataAccess
    {
        public bool AddRecoveryType(clsRecoveryType info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddRecoveryType"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@Code", info.strCode);
                            cmd.Parameters.AddWithValue("@Description", info.strDescription);
                            cmd.Parameters.AddWithValue("@DueMonthly", info.bDueMonthly);
                            cmd.Parameters.AddWithValue("@IncludeinTotal", info.bIncludeTotal);
                            cmd.Parameters.AddWithValue("@ID", info.intId);

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
        public List<clsRecoveryType> GetRecoveryTypes()
        {
            List<clsRecoveryType> lst = new List<clsRecoveryType>();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetRecoveryTypes"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        clsRecoveryType info = new clsRecoveryType();
                        info.strCode = reader["code"].ToString();
                        info.strDescription = reader["description"].ToString();
                        info.bDueMonthly = Convert.ToBoolean(reader["DueMonthly"]);
                        info.bIncludeTotal = Convert.ToBoolean(reader["IncludeinTotal"]);
                        info.intId = int.Parse(reader["id"].ToString());

                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public bool DeleteOtherRecoveryPlan(string Plan)//SizeCode
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_DeleteOtherRecoveryPaymentPlan"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@SizeCode", Plan);

                            st = cmd.ExecuteNonQuery();
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex) { }
            if (st < 0)
                return false;
            else
                return true;
        }
        public bool AddOtherRecoveryPlan(List<clsOtherRecoveryPlan> lst)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    {
                        foreach (var planline in lst)
                        {
                            using (SqlCommand cmd = new SqlCommand("TMR_USP_AddOtherRecoveryPlanRow"))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Connection = conn;
                                cmd.Parameters.AddWithValue("@SizeCode", planline.strSizeCode);
                                cmd.Parameters.AddWithValue("@InstallmentNo", planline.intInstallmentNo);
                                cmd.Parameters.AddWithValue("@RecoveryType", planline.strRecoveryType);
                                cmd.Parameters.AddWithValue("@RecoveryTypeid", planline.intId);
                                cmd.Parameters.AddWithValue("@AmountDue", planline.decAmountDue);
                                cmd.Parameters.AddWithValue("@DueAfterMonths", planline.intDueAfterMonths);
                                cmd.Parameters.AddWithValue("@Project", planline.strProject);
                                cmd.Parameters.AddWithValue("@PlanName", planline.strPlan);

                                st = cmd.ExecuteNonQuery();
                                if (st < 0)
                                    break;
                            }
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
        public List<clsOtherRecoveryPlan> GetOtherRecoveryPlan(string strPlan)
        {
            List<clsOtherRecoveryPlan> lst = new List<clsOtherRecoveryPlan>();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetOtherRecoveryPlanByPlanID"))
                {

                    cmd.Parameters.AddWithValue("@Plan", strPlan);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    conn.Open();
                    clsOtherRecoveryPlan obj = new clsOtherRecoveryPlan();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        clsOtherRecoveryPlan info = new clsOtherRecoveryPlan();
                        info.intDueAfterMonths = Convert.ToInt32(reader["DueAfterMonths"]);
                        info.intInstallmentNo = Convert.ToInt32(reader["InstallmentNo"]);
                        info.strSizeCode = reader["SizeCode"].ToString();
                        info.strRecoveryType = reader["RecoveryType"].ToString();

                        info.strPlan = reader["PlanName"].ToString();
                        info.strPlan = reader["ProjectNo"].ToString();

                        info.decAmountDue = Convert.ToDecimal(reader["AmountDue"]);
                        info.intRecoveryTypeid = Convert.ToInt32(reader["RecoveryTypeid"]);

                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public bool AddMemberOtherRecoveryPlan(List<clsMemberRecoveryPlan> lst)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    {
                        foreach (var planline in lst)
                        {
                            using (SqlCommand cmd = new SqlCommand("TMR_USP_AddMemberRecoveryPlan"))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Connection = conn;
                                cmd.Parameters.AddWithValue("@RegistrationNo", planline.strRegistrationNo);
                                cmd.Parameters.AddWithValue("@ClientID", planline.strClientID);
                                cmd.Parameters.AddWithValue("@Membership_id", planline.intMembershipid);
                                cmd.Parameters.AddWithValue("@InstallmentNo", planline.intInstallmentNo);
                                cmd.Parameters.AddWithValue("@RecoveryType", planline.strRecoveryType);
                                cmd.Parameters.AddWithValue("@AmountDue", planline.decAmountDue);
                                cmd.Parameters.AddWithValue("@DueDate", planline.dateDue);
                                cmd.Parameters.AddWithValue("@AmountWaived", planline.decAmountWaived);
                                cmd.Parameters.AddWithValue("@AmountReceived", planline.decAmountApplied);
                                cmd.Parameters.AddWithValue("@OutStandingAmount", planline.decOutStandingAmount);
                                cmd.Parameters.AddWithValue("@Delete", planline.Delete);
                                cmd.Parameters.AddWithValue("@id", planline.intId);


                                st = cmd.ExecuteNonQuery();
                                if (st < 0)
                                    break;
                            }
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
        public bool UpdateMemberOtherRecoveryPlan(List<clsMemberRecoveryPlan> lst)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    {
                        foreach (var planline in lst)
                        {
                            using (SqlCommand cmd = new SqlCommand("TMR_USP_UpdateMemberRecoveryPlan"))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Connection = conn;
                                cmd.Parameters.AddWithValue("@AmountWaived", planline.decAmountWaived);
                                cmd.Parameters.AddWithValue("@AmountReceived", planline.decAmountApplied);
                                cmd.Parameters.AddWithValue("@OutStandingAmount", planline.decOutStandingAmount);
                                cmd.Parameters.AddWithValue("@id", planline.intId);


                                st = cmd.ExecuteNonQuery();
                                if (st < 0)
                                    break;
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex) { }
            if (st >= 0)
                return true;
            else
                return false;
        }
        public List<clsMemberRecoveryPlan> GetMemberOtherRecoveryPlan(string strMember)
        {
            List<clsMemberRecoveryPlan> lst = new List<clsMemberRecoveryPlan>();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetMemberOtherPaymentPlan"))
                {

                    cmd.Parameters.AddWithValue("@membership", strMember);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        clsMemberRecoveryPlan info = new clsMemberRecoveryPlan()
                        {
                            strRegistrationNo = reader["RegistrationNo"].ToString(),
                            strClientID = reader["ClientID"].ToString(),
                            intMembershipid = Convert.ToInt32(reader["Membership_id"]),
                            intInstallmentNo = Convert.ToInt32(reader["InstallmentNo"]),
                            strRecoveryType = reader["RecoveryType"].ToString(),
                            dateDue = Convert.ToDateTime(reader["DueDate"]),
                            decAmountDue = Convert.ToDecimal(reader["AmountDue"]),
                            decTotalAmountReceived = Convert.ToDecimal(reader["AmountReceived"]),
                            decTotalAmountWaived = Convert.ToDecimal(reader["AmountWaived"]),
                            decOutStandingAmount = Convert.ToDecimal(reader["OutStandingAmount"]),
                            intId = Convert.ToInt32(reader["id"]),
                        };
                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public List<clsMemberRecoveryPlan> GetMemberInstallmentPlan(string strMember)
        {
            List<clsMemberRecoveryPlan> lst = new List<clsMemberRecoveryPlan>();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetMemberInstallmentPlan"))
                {

                    cmd.Parameters.AddWithValue("@membership", strMember);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        clsMemberRecoveryPlan info = new clsMemberRecoveryPlan()
                        {
                            strRegistrationNo = reader["RegistrationNo"].ToString(),
                            strClientID = reader["ClientID"].ToString(),
                            intMembershipid = Convert.ToInt32(reader["Membership_id"]),
                            intInstallmentNo = Convert.ToInt32(reader["InstallmentNo"]),
                            strRecoveryType = reader["RecoveryType"].ToString(),
                            dateDue = Convert.ToDateTime(reader["DueDate"]),
                            decAmountDue = Convert.ToDecimal(reader["AmountDue"]),
                            decTotalAmountReceived = Convert.ToDecimal(reader["AmountReceived"]),
                            decTotalAmountWaived = Convert.ToDecimal(reader["AmountWaived"]),
                            decOutStandingAmount = Convert.ToDecimal(reader["OutStandingAmount"]),
                            intId = Convert.ToInt32(reader["id"]),
                        };
                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public bool DeleteMemberInstallmentRow(int id)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_DeleteMemberRecoveryPlanRow"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@id", id);
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
        public bool DeleteMemberInstallments(string RegNo)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_DeleteMemberInstallmentPlan"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@RegNo", RegNo);
                            st = cmd.ExecuteNonQuery();
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex) { }
            if (st < 0)
                return false;
            else
                return true;
        }
        public string GetNextReceiptNumber()
        {
            string result = "";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("TMR_USP_GenerateReceiptNumber"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        result = reader["ReceiptNumber"].ToString();
                    }
                    conn.Close();
                }
            }
            return result;
        }
        public bool AddReceiptEntry(clsReceiptEntry entry)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    {

                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddReceiptEntry"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@RegistrationNo", entry.RegistrationNo);
                            cmd.Parameters.AddWithValue("@ClientID", entry.ClientID);
                            cmd.Parameters.AddWithValue("@ClientName", entry.ClientName);
                            cmd.Parameters.AddWithValue("@Membership_id", entry.Membership_id);
                            cmd.Parameters.AddWithValue("@ReceiptNumber", entry.ReceiptNumber);
                            cmd.Parameters.AddWithValue("@ReceiptDate", entry.ReceiptDate);
                            cmd.Parameters.AddWithValue("@ReceiptAmount", entry.ReceiptAmount);

                            cmd.Parameters.AddWithValue("@AppliedAmount", entry.AppliedAmount);
                            cmd.Parameters.AddWithValue("@CurrentAmount", entry.CurrentAmount);
                            cmd.Parameters.AddWithValue("@ReceiptMode", entry.ReceiptMode);
                            cmd.Parameters.AddWithValue("@InstrumentNumber", entry.InstrumentNumber);
                            cmd.Parameters.AddWithValue("@InstrumentDate", entry.InstrumentDate);
                            cmd.Parameters.AddWithValue("@DraweeBank", entry.DraweeBank);
                            cmd.Parameters.AddWithValue("@DraweeBranch", entry.DraweeBranch);

                            cmd.Parameters.AddWithValue("@DepositBank", entry.DepositBank);
                            cmd.Parameters.AddWithValue("@DepositAccount", entry.DepositAccount);
                            cmd.Parameters.AddWithValue("@DepositBy", entry.DepositBy);
                            cmd.Parameters.AddWithValue("@DepositDate", entry.DepositDate);
                            cmd.Parameters.AddWithValue("@ClearanceDate", entry.ClearanceDate);
                            cmd.Parameters.AddWithValue("@Remarks", entry.Remarks);

                            cmd.Parameters.AddWithValue("@Cleared", entry.Cleared);
                            cmd.Parameters.AddWithValue("@sentToGP", entry.SentToGP);
                            cmd.Parameters.AddWithValue("@Project", entry.Project);

                            cmd.Parameters.AddWithValue("@OnAccount", entry.OnAccountOf);
                            cmd.Parameters.AddWithValue("@ClearedStatus", entry.ClearStatus);

                            cmd.Parameters.AddWithValue("@id", entry.intId);



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
        public bool AddReceiptApply(List<clsReceiptApply> entries)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    {
                        foreach (var entry in entries)
                        {
                            using (SqlCommand cmd = new SqlCommand("TMR_USP_AddReceiptApply"))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Connection = conn;
                                cmd.Parameters.AddWithValue("@RegistrationNo", entry.RegistrationNo);
                                cmd.Parameters.AddWithValue("@ClientID", entry.ClientID);
                                cmd.Parameters.AddWithValue("@AppliedAmount", entry.decAppliedAmount);
                                cmd.Parameters.AddWithValue("@ReceiptNumber", entry.Receiptnumber);
                                cmd.Parameters.AddWithValue("@WaivedAmount", entry.decWaivedAmount);
                                cmd.Parameters.AddWithValue("@RecoveryPlanID", entry.RecoveryPlanid);
                                st = cmd.ExecuteNonQuery();

                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex) { }
            if (st >= 0)
                return true;
            else
                return false;
        }
        public List<clsReceiptEntry> GetAllReceiptsList(clsDocumentFilter clsdoc)
        {
            List<clsReceiptEntry> lst = new List<clsReceiptEntry>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetAllReceiptsList"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@RegistrationNo", clsdoc.strRegistrationNo);
                    cmd.Parameters.AddWithValue("@ProjectID", clsdoc.strProjectID);
                    cmd.Parameters.AddWithValue("@ClientID", clsdoc.strClientID);
                    cmd.Parameters.AddWithValue("@StartDate", clsdoc.dateStartDate);
                    cmd.Parameters.AddWithValue("@EndDate", clsdoc.dateEndDate);
                    cmd.Parameters.AddWithValue("@ReceiptNumber", clsdoc.strDocNumber);


                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsReceiptEntry();

                        info.RegistrationNo = reader["RegistrationNo"].ToString();
                        info.ClientID = reader["ClientID"].ToString();
                        info.ClientName = reader["ClientName"].ToString();
                        info.ReceiptNumber = reader["ReceiptNumber"].ToString();
                        info.ReceiptDate = Convert.ToDateTime(reader["ReceiptDate"]);
                        info.ReceiptAmount = Convert.ToDecimal(reader["ReceiptAmount"]);
                        info.Remarks = reader["Remarks"].ToString();
                        info.intId = Convert.ToInt32(reader["id"]);

                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public List<clsReceiptEntry> GetUnsentReceiptsList()
        {
            List<clsReceiptEntry> lst = new List<clsReceiptEntry>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetUnsentToGPReceiptsList"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    //cmd.Parameters.AddWithValue("@RegistrationNo", clsdoc.strRegistrationNo);
                    //cmd.Parameters.AddWithValue("@ProjectID", clsdoc.strProjectID);
                    //cmd.Parameters.AddWithValue("@ClientID", clsdoc.strClientID);
                    //cmd.Parameters.AddWithValue("@StartDate", clsdoc.dateStartDate);
                    //cmd.Parameters.AddWithValue("@EndDate", clsdoc.dateEndDate);
                    //cmd.Parameters.AddWithValue("@ReceiptNumber", clsdoc.strDocNumber);


                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsReceiptEntry();

                        info.RegistrationNo = reader["RegistrationNo"].ToString();
                        info.ClientID = reader["ClientID"].ToString();
                        info.ClientName = reader["ClientName"].ToString();
                        info.ReceiptNumber = reader["ReceiptNumber"].ToString();
                        info.ReceiptDate = Convert.ToDateTime(reader["ReceiptDate"]);
                        info.ReceiptAmount = Convert.ToDecimal(reader["ReceiptAmount"]);
                        info.Remarks = reader["Remarks"].ToString();
                        info.ClearanceDate = Convert.ToDateTime(reader["ClearanceDate"]);
                        info.DepositBank = reader["DepositBank"].ToString();
                        info.intId = Convert.ToInt32(reader["id"]);

                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public clsReceiptEntry GetReceiptEntry(int id)
        {
            clsReceiptEntry entry = new clsReceiptEntry();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetReceiptEntry"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        entry.intId = Convert.ToInt32(reader["id"]);
                        entry.RegistrationNo = reader["RegistrationNo"].ToString();
                        entry.ClientName = reader["ClientName"].ToString();
                        entry.ClientID = reader["ClientID"].ToString();
                        entry.ReceiptAmount = Convert.ToDecimal(reader["ReceiptAmount"]);
                        entry.AppliedAmount = Convert.ToDecimal(reader["AppliedAmount"]);
                        entry.CurrentAmount = Convert.ToDecimal(reader["CurrentAmount"]);
                        entry.ReceiptMode = reader["ReceiptMode"].ToString();
                        entry.InstrumentNumber = reader["InstrumentNumber"].ToString();
                        entry.InstrumentDate = Convert.ToDateTime(reader["InstrumentDate"]);
                        entry.DraweeBank = reader["DraweeBank"].ToString();
                        entry.DraweeBranch = reader["DraweeBranch"].ToString();
                        entry.DepositBank = reader["DepositBank"].ToString();
                        entry.DepositAccount = reader["DepositAccount"].ToString();
                        entry.DepositBy = reader["DepositBy"].ToString();
                        entry.DepositDate = Convert.ToDateTime(reader["DepositDate"]);
                        entry.ClearanceDate = Convert.ToDateTime(reader["ClearanceDate"]);
                        entry.Remarks = reader["Remarks"].ToString();
                        entry.ReceiptDate = Convert.ToDateTime(reader["ReceiptDate"]);
                        entry.ReceiptNumber = reader["ReceiptNumber"].ToString();
                        entry.OnAccountOf = reader["OnAccount"].ToString();
                        entry.ClearStatus = reader["ClearedStatus"].ToString();
                        
                        entry.Cleared = Convert.ToBoolean(reader["Cleared"]);
                        entry.Project = reader["Project"].ToString();
                        entry.SentToGP = Convert.ToBoolean(reader["SentToGp"]);
                    }
                    conn.Close();
                }
            }
            return entry;
        }
        public bool AddReceiptAttachment(clsReceiptAttachment attachment)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddReceiptAttachment"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@RegistrationNo", attachment.RegistrationNo);
                            cmd.Parameters.AddWithValue("@ReceiptNumber", attachment.ReceiptNumber);
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
        public List<clsReceiptAttachment> GetReceiptAttachments(string strMember, string strReceiptNumber)
        {
            List<clsReceiptAttachment> attachments = new List<clsReceiptAttachment>();

            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_GetReceiptAttachments"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@RegistrationNo", strMember);
                            cmd.Parameters.AddWithValue("@ReceiptNumber", strReceiptNumber);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    clsReceiptAttachment attach = new clsReceiptAttachment();

                                    attach.RegistrationNo = reader["RegistrationNo"].ToString();
                                    attach.ReceiptNumber = reader["ReceiptNumber"].ToString();
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
        public clsReceiptAttachment GetReceiptAttachment(int id)
        {
            clsReceiptAttachment attachment1 = new clsReceiptAttachment();

            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_GetReceiptAttachment"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@id", id);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    attachment1.RegistrationNo = reader["RegistrationNo"].ToString();
                                    attachment1.ReceiptNumber = reader["ReceiptNumber"].ToString();
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

        public List<clsMemberRecoveryPlan> GetMemberInstallmentPlanFromReceipt(string strReceipt)
        {
            List<clsMemberRecoveryPlan> lst = new List<clsMemberRecoveryPlan>();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetMemberInstallmentPlanFromReceipt"))
                {

                    cmd.Parameters.AddWithValue("@ReceiptNumber", strReceipt);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        clsMemberRecoveryPlan info = new clsMemberRecoveryPlan()
                        {
                            strRegistrationNo = reader["RegistrationNo"].ToString(),
                            strClientID = reader["ClientID"].ToString(),
                            intMembershipid = Convert.ToInt32(reader["Membership_id"]),
                            intInstallmentNo = Convert.ToInt32(reader["InstallmentNo"]),
                            strRecoveryType = reader["RecoveryType"].ToString(),
                            dateDue = Convert.ToDateTime(reader["DueDate"]),
                            decAmountDue = Convert.ToDecimal(reader["AmountDue"]),
                            decTotalAmountReceived = Convert.ToDecimal(reader["TotalAmountReceived"]),
                            decTotalAmountWaived = Convert.ToDecimal(reader["TotalAmountWaived"]),
                            decAmountApplied = Convert.ToDecimal(reader["AppliedAmount"]),
                            decAmountWaived = Convert.ToDecimal(reader["WaivedAmount"]),
                            decOutStandingAmount = Convert.ToDecimal(reader["OutStandingAmount"]),
                            Applied = Convert.ToBoolean(reader["Applied"]),
                            intId = Convert.ToInt32(reader["id"]),
                        };
                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public List<clsMemberRecoveryPlan> GetMemberOtherRecoveryPlanFromReceipt(string strReceipt)
        {
            List<clsMemberRecoveryPlan> lst = new List<clsMemberRecoveryPlan>();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetMemberOtherRecoveryPlanFromReceipt"))
                {

                    cmd.Parameters.AddWithValue("@ReceiptNumber", strReceipt);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        clsMemberRecoveryPlan info = new clsMemberRecoveryPlan()
                        {
                            strRegistrationNo = reader["RegistrationNo"].ToString(),
                            strClientID = reader["ClientID"].ToString(),
                            intMembershipid = Convert.ToInt32(reader["Membership_id"]),
                            intInstallmentNo = Convert.ToInt32(reader["InstallmentNo"]),
                            strRecoveryType = reader["RecoveryType"].ToString(),
                            dateDue = Convert.ToDateTime(reader["DueDate"]),
                            decAmountDue = Convert.ToDecimal(reader["AmountDue"]),
                            decTotalAmountReceived = Convert.ToDecimal(reader["TotalAmountReceived"]),
                            decTotalAmountWaived = Convert.ToDecimal(reader["TotalAmountWaived"]),
                            decAmountApplied = Convert.ToDecimal(reader["AppliedAmount"]),
                            decAmountWaived = Convert.ToDecimal(reader["WaivedAmount"]),
                            decOutStandingAmount = Convert.ToDecimal(reader["OutStandingAmount"]),
                            Applied = Convert.ToBoolean(reader["Applied"]),
                            intId = Convert.ToInt32(reader["id"]),
                        };
                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public List<clsCheckBook> GetCheckBooks()
        {
            List<clsCheckBook> lst = new List<clsCheckBook>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetCheckbookInformation"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsCheckBook();

                        info.strCheckbookid = reader["CHEKBKID"].ToString();
                        info.strCheckbookDesc = reader["DSCRIPTN"].ToString();
                        info.intAccountid = Convert.ToInt32(reader["ACTINDX"].ToString());
                        info.strBank = reader["BANKID"].ToString();

                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }
    }
}