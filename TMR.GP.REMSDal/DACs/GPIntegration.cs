using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TMR.GP.REMSDal
{
    public partial class DataAccess
    {
        public List<clsMemberRegistration> GetAllTransferPending()
        {
            List<clsMemberRegistration> lst = new List<clsMemberRegistration>();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetTransferPending"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        clsMemberRegistration info = new clsMemberRegistration();

                        info.id = int.Parse(reader["id"].ToString());
                        info.RegistrationNo = reader["RegistrationNo"].ToString();
                        info.ClientID = reader["ClientID"].ToString();
                        info.Name = reader["Name"].ToString();
                        info.Booking = Convert.ToDateTime(reader["Booking"]);
                        info.strProjectid = reader["ProjectID"].ToString();
                        info.Plan = reader["Plan"].ToString();


                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public List<clsMemberRegistration> GetAllUnSentToGP()
        {
            List<clsMemberRegistration> lst = new List<clsMemberRegistration>();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetUnSentToGP"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        clsMemberRegistration info = new clsMemberRegistration();

                        info.id = int.Parse(reader["id"].ToString());
                        info.RegistrationNo = reader["RegistrationNo"].ToString();
                        info.ClientID = reader["ClientID"].ToString();
                        info.Name = reader["Name"].ToString();
                        info.Booking = Convert.ToDateTime(reader["Booking"]);
                        info.strProjectid = reader["ProjectID"].ToString();
                        info.Plan = reader["Plan"].ToString();


                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public List<string> GetCashReceiptBatches()
        {
            List<string> lst = new List<string>();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetCashReceiptBatches"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string info = reader["bachnumb"].ToString();
                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public List<string> GetVendorInvoiceBatches()
        {
            List<string> lst = new List<string>();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetVendorInvoiceBatches"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string info = reader["bachnumb"].ToString();
                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        }

    }
}