using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TMR.GP.REMSDal
{
    public partial class DataAccess
    {
        public bool CreateGPCustomer(clsMemberRegistration info)
        {
            string strDBName = this.GetProjectDBName(info.strProjectid);


            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_CreateCustomer"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@DBName", strDBName);
                            cmd.Parameters.AddWithValue("@custnmbr", info.RegistrationNo);

                            cmd.Parameters.AddWithValue("@Name", info.Name);
                            cmd.Parameters.AddWithValue("@CNTCT", info.Name);

                            cmd.Parameters.AddWithValue("@STMNT", info.Name);
                            cmd.Parameters.AddWithValue("@SHRT", info.Name);
                            cmd.Parameters.AddWithValue("@ADRSCODE", "PRIMARY");//info.FatherOrHusbandType);
                            cmd.Parameters.AddWithValue("@ADRS1", info.CurrentAddress1);
                            cmd.Parameters.AddWithValue("@ADRS2", info.CurrentAddress2);
                            cmd.Parameters.AddWithValue("@ADRS3", info.CurrentAddress2);
                            cmd.Parameters.AddWithValue("@CNtry", info.Country);
                            cmd.Parameters.AddWithValue("@city", info.City);
                            cmd.Parameters.AddWithValue("@custclas", info.strCustomerClass);

                            cmd.Parameters.AddWithValue("@PHONEOFF", info.PhOff);
                            cmd.Parameters.AddWithValue("@PHONERES", info.Res);
                            cmd.Parameters.AddWithValue("@MOBILE", info.Mob);

                            cmd.Parameters.AddWithValue("@CNIC", info.ClientID);
                            cmd.Parameters.AddWithValue("@Project", info.strProjectid);
                            cmd.Parameters.AddWithValue("@Block", info.Block);
                            cmd.Parameters.AddWithValue("@UnitID", info.Plot);


                            //@CNIC varchar(50), @Project varchar(50), @PHONEOFF varchar(50), @PHONERES varchar(50), @MOBILE varchar(50)

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
        public bool UpdateGPCustomer(clsMemberRegistration info)
        {
            string strDBName = this.GetProjectDBName(info.strProjectid);

            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_UpdateCustomer"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@DBName", strDBName);
                            cmd.Parameters.AddWithValue("@custnmbr", info.RegistrationNo);

                            cmd.Parameters.AddWithValue("@Name", info.Name);
                            cmd.Parameters.AddWithValue("@CNTCT", info.Name);

                            cmd.Parameters.AddWithValue("@STMNT", info.Name);
                            cmd.Parameters.AddWithValue("@SHRT", info.Name);
                            cmd.Parameters.AddWithValue("@ADRSCODE", "PRIMARY");//info.FatherOrHusbandType);
                            cmd.Parameters.AddWithValue("@ADRS1", info.CurrentAddress1);
                            cmd.Parameters.AddWithValue("@ADRS2", info.CurrentAddress2);
                            cmd.Parameters.AddWithValue("@ADRS3", info.CurrentAddress2);
                            cmd.Parameters.AddWithValue("@CNtry", info.Country);
                            cmd.Parameters.AddWithValue("@city", info.City);

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
        public List<string> GetClientIdsFromGP()
        {
            List<string> lst = new List<string>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_CR_GetClientIDs"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        lst.Add(reader["comment1"].ToString());

                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public bool CreateCashReceipt(clsReceiptEntry info, string BatchNumber)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_CreateCashReceipt"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@Batch", BatchNumber);
                            cmd.Parameters.AddWithValue("@DOCNUMBR", info.ReceiptNumber);

                            cmd.Parameters.AddWithValue("@CustNMBR", info.RegistrationNo);
                            cmd.Parameters.AddWithValue("@DOCDATE", info.ReceiptDate.Date);

                            cmd.Parameters.AddWithValue("@CSHRCTYP", 0);
                            cmd.Parameters.AddWithValue("@CHEKNMBR", info.InstrumentNumber);
                            cmd.Parameters.AddWithValue("@CHEKBKID", info.DepositBank);//info.FatherOrHusbandType);
                            cmd.Parameters.AddWithValue("@TRXDESCRN", info.Remarks);
                            cmd.Parameters.AddWithValue("@LSTEDTDT", DateTime.Now.Date);
                            cmd.Parameters.AddWithValue("@ORTRXAMT", info.ReceiptAmount);
                            cmd.Parameters.AddWithValue("@GLPOSTDT", DateTime.Now.Date);

                            //@CNIC varchar(50), @Project varchar(50), @PHONEOFF varchar(50), @PHONERES varchar(50), @MOBILE varchar(50)

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
        public bool UpdateCashReceiptSendToGPStatus(int id)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_UpdateSendToGPStatusCashReceipt"))
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
            catch (Exception ex)
            {
                //return ex;
            }
            if (st > 0)
                return true;
            else
                return false;
        }
        public bool UpdateCommissionSendToGPStatus(int id)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_UpdateSendToGPStatusCommEntry"))
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
            catch (Exception ex)
            {
                //return ex;
            }
            if (st > 0)
                return true;
            else
                return false;
        }
    }
}