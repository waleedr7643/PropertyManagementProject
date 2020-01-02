using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TMR.GP.REMSDal
{
    public partial class DataAccess
    {
        public bool AddCommissionEntry(clsCommission info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_Add_CommissionEntry"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@RegistrationNo", info.strRegistration);
                            cmd.Parameters.AddWithValue("@Project", info.strProject);
                            cmd.Parameters.AddWithValue("@ClientID", info.strClientID);
                            cmd.Parameters.AddWithValue("@ClientName", info.strClientName);

                            cmd.Parameters.AddWithValue("@Dealer", info.strDealer);
                            cmd.Parameters.AddWithValue("@EntryNumber", info.strEntryNumber);
                            cmd.Parameters.AddWithValue("@EntryType", info.intEntryType);
                            cmd.Parameters.AddWithValue("@DocumentDate", info.DocumentDate);

                            cmd.Parameters.AddWithValue("@NetPrice", info.decNetPrice);
                            cmd.Parameters.AddWithValue("@Percentage", info.decPercentage);
                            cmd.Parameters.AddWithValue("@Amount", info.decAmount);
                            cmd.Parameters.AddWithValue("@Remarks", info.strRemarks);

                            cmd.Parameters.AddWithValue("@SentToGp", info.bSentToGP);
                            cmd.Parameters.AddWithValue("@id", info.intID);

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
        public List<clsCommission> GetAllCommList(clsDocumentFilter clsdoc)
        {
            List<clsCommission> lst = new List<clsCommission>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetAllCommissionList"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@RegistrationNo", clsdoc.strRegistrationNo);
                    cmd.Parameters.AddWithValue("@ProjectID", clsdoc.strProjectID);
                    cmd.Parameters.AddWithValue("@ClientID", clsdoc.strClientID);
                    cmd.Parameters.AddWithValue("@StartDate", clsdoc.dateStartDate);
                    cmd.Parameters.AddWithValue("@EndDate", clsdoc.dateEndDate);
                    cmd.Parameters.AddWithValue("@EntryNumber", clsdoc.strDocNumber);


                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsCommission();

                        info.strRegistration = reader["RegistrationNo"].ToString();
                        info.strClientID = reader["ClientID"].ToString();
                        info.strClientName = reader["ClientName"].ToString();
                        info.strEntryNumber = reader["EntryNumber"].ToString();
                        info.DocumentDate = Convert.ToDateTime(reader["DocumentDate"]);
                        info.decAmount = Convert.ToDecimal(reader["Amount"]);
                        info.strRemarks = reader["Remarks"].ToString();
                        info.intID = Convert.ToInt32(reader["id"]);
                        //RegistrationNo, ClientID, ClientName, EntryNumber, DocumentDate, Amount, Remarks, id
                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public clsCommission GetCommissionEntry(int id)
        {
            clsCommission entry = new clsCommission();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetCommEntry"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        entry.strRegistration = reader["RegistrationNo"].ToString();
                        entry.strProject = reader["Project"].ToString();
                        entry.strClientID = reader["ClientID"].ToString();
                        entry.strClientName = reader["ClientName"].ToString();
                        entry.strDealer = reader["Dealer"].ToString();
                        entry.strEntryNumber = reader["EntryNumber"].ToString(); 
                        entry.intEntryType = Convert.ToInt32(reader["EntryType"]);
                        entry.decNetPrice = Convert.ToDecimal(reader["NetPrice"]);
                        entry.DocumentDate = Convert.ToDateTime(reader["DocumentDate"]);
                        entry.decPercentage = Convert.ToDecimal(reader["Percentage"]);
                        entry.decAmount = Convert.ToDecimal(reader["Amount"]);
                        entry.strRemarks = reader["Remarks"].ToString(); 
                        entry.bSentToGP = Convert.ToBoolean(reader["SentToGp"]);
                        entry.intID = Convert.ToInt32(reader["id"]);
                    }
                    conn.Close();
                }
            }
            return entry;
        }
        public string GetNextCommissionNumber()
        {
            string result = "";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("TMR_USP_GenerateCommEntryNumber"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        result = reader["EntryNumber"].ToString();
                    }
                    conn.Close();
                }
            }
            return result;
        }
        public List<clsCommission> GetUnsentCommissionList()
        {
            List<clsCommission> lst = new List<clsCommission>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetUnsentToGPCommList"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var entry = new clsCommission();

                        entry.strRegistration = reader["RegistrationNo"].ToString();
                        entry.strProject = reader["Project"].ToString();
                        entry.strClientID = reader["ClientID"].ToString();
                        entry.strClientName = reader["ClientName"].ToString();
                        entry.strDealer = reader["Dealer"].ToString();
                        entry.strEntryNumber = reader["EntryNumber"].ToString();
                        entry.intEntryType = Convert.ToInt32(reader["EntryType"]);
                        entry.decNetPrice = Convert.ToDecimal(reader["NetPrice"]);
                        entry.DocumentDate = Convert.ToDateTime(reader["DocumentDate"]);
                        entry.decPercentage = Convert.ToDecimal(reader["Percentage"]);
                        entry.decAmount = Convert.ToDecimal(reader["Amount"]);
                        entry.strRemarks = reader["Remarks"].ToString();
                        entry.bSentToGP = Convert.ToBoolean(reader["SentToGp"]);
                        entry.intID = Convert.ToInt32(reader["id"]);

                        lst.Add(entry);

                    }
                    conn.Close();
                }
            }
            return lst;
        }

        //TMR_USP_GenerateCommEntryNumber
    }
}