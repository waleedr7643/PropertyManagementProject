using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TMR.GP.REMSDal
{
    public partial class DataAccess
    {
        public clsMemberRegistration GetMemberRegistrationInfoById(int id)
        {
            clsMemberRegistration info = new clsMemberRegistration();
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("TMR_USP_GetMemberRegistrationByID"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        //conn.Open();
                        cmd.Parameters.AddWithValue("@id", id);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows == false)
                            info = null;

                        while (reader.Read())
                        {
                            info = new clsMemberRegistration();
                            info.RegistrationNo = reader["RegistrationNo"].ToString();
                            info.ClientID = reader["ClientID"].ToString();
                            info.strProjectid = reader["ProjectID"].ToString();
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
                            info.Block = reader["Block"].ToString();
                            info.Plot = reader["Plot"].ToString();
                            info.UnitRate = Convert.ToDecimal(reader["UnitRate"].ToString());
                            info.TotalPrice = Convert.ToDecimal(reader["TotalPrice"].ToString());
                            info.FinanceAmt = Convert.ToDecimal(reader["FinanceAmt"].ToString());
                            info.RebatAmt = Convert.ToDecimal(reader["RebatAmt"].ToString());
                            info.NetOrRetailPrice = Convert.ToDecimal(reader["NetPrice"].ToString());
                            info.BookingPrice = Convert.ToDecimal(reader["BookingPrice"].ToString());
                            info.strProjectid = reader["ProjectID"].ToString();
                            info.intPercentage = int.Parse(reader["Percentage"].ToString());
                            info.strStatus = (reader["Status"].ToString());
                            info.intStatusCode = int.Parse(reader["statuscode"].ToString());
                            info.AccountNumber = reader["AccountNumber"].ToString();
                            info.AccountTitle = reader["AccountTitle"].ToString();
                            info.BankName = reader["BankName"].ToString();
                            info.CustomerNumber = (reader["CustomerNumber"].ToString());
                            info.strSalesRep = (reader["SalesRep"].ToString());
                            info.strCustomerClass = (reader["CustomerClass"].ToString());
                            info.bSoleOwner = Convert.ToBoolean(reader["SoleOwner"]);
                            info.bTransferPending = Convert.ToBoolean(reader["TransferPending"]);
                            info.bSendToGP = Convert.ToBoolean(reader["SendToGP"]);
                            info.id = int.Parse(reader["id"].ToString());

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
    }
}
