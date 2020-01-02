using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;

namespace TMR.GP.REMSDal
{
    public enum ConnectionType { Company = 1 }
    public partial class DataAccess
    {

        string strConn = ConfigurationManager.ConnectionStrings["GCRems"].ConnectionString;
        public SqlConnection GetDBConection(ConnectionType conntype, string Project)
        {
            string strConn = "";
            if (conntype == ConnectionType.Company)
            {
                strConn = ConfigurationManager.ConnectionStrings[Project].ConnectionString;

            }

            if (strConn == null)
                return null;

            SqlConnection conn = new SqlConnection(strConn);
            return conn;

            //strConn = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;

            if (strConn == null)
                return null;
            Console.Write("connection error");
            //SqlConnection
            conn = new SqlConnection(strConn);
            return conn;

        }
        public SqlConnection GetGPConection(ConnectionType conntype, string Project)
        {
            string strConn = "";
            if (conntype == ConnectionType.Company)
            {
                strConn = ConfigurationManager.ConnectionStrings["GCity"].ConnectionString;

            }

            if (strConn == null)
                return null;

            SqlConnection conn = new SqlConnection(strConn);
            return conn;

            //strConn = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;

            if (strConn == null)
                return null;
            Console.Write("connection error");
            //SqlConnection
            conn = new SqlConnection(strConn);
            return conn;

        }
        public SqlConnectionStringBuilder GetCredentials()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["GCRems"].ConnectionString);
                return builder;
            }
            catch (Exception)
            {
                return new SqlConnectionStringBuilder(@"Data Source=eagleserver;Initial Catalog=PLOTMS;integrated Security =false; USER ID = sa; password = Tmrc123");
            }
        }
        public SqlConnectionStringBuilder GetGPCredentials()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["GCity"].ConnectionString);
                return builder;
            }
            catch (Exception)
            {
                return new SqlConnectionStringBuilder(@"Data Source=eagleserver;Initial Catalog=TWO18;integrated Security =false; USER ID = sa; password = Tmrc123");
            }
        }
        
        public List<clsBlock> GetBlockList()
        {
            List<clsBlock> lst = new List<clsBlock>();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("TMR_USP_VIEWBLOCK"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        clsBlock info = new clsBlock();
                        info.BlockNo = reader["BlockNo"].ToString();
                        info.BlockName = reader["BlockName"].ToString();
                        info.ProjectID = reader["ProjectID"].ToString();
                        info.decDevelopedArea = Convert.ToDecimal(reader["DevelopedArea"]);
                        info.decTotalArea = Convert.ToDecimal(reader["TotalArea"]);
                        info.strUOMid = reader["UOMid"].ToString();
                        info.id = int.Parse(reader["id"].ToString());

                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public List<clsBlock> GetBlocksByProjectNo(string project)
        {
            List<clsBlock> lst = new List<clsBlock>();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetBlockListByProjectInfo"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@projectid", project);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        clsBlock info = new clsBlock();
                        info.BlockNo = reader["BlockNo"].ToString();
                        info.BlockName = reader["BlockName"].ToString();
                        info.ProjectID = reader["ProjectID"].ToString();
                        info.decDevelopedArea = Convert.ToDecimal(reader["DevelopedArea"]);
                        info.decTotalArea = Convert.ToDecimal(reader["TotalArea"]);
                        info.strUOMid = reader["UOMid"].ToString();
                        info.id = int.Parse(reader["id"].ToString());

                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        }
        
        public clsProjects GetMemberShipNoByProjectID(string ProjectID)
        {
            var info = new clsProjects();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_MemberShipIDByProject"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@ProjectID", ProjectID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        info.strProjectid = reader["ProjectID"].ToString();
                        info.strPrefix = reader["Prefix"].ToString();
                        info.strNumber = reader["Number"].ToString();
                        info.strProjectName = reader["ProjectName"].ToString();
                        info.id = Convert.ToInt32(reader["ID"]);
                        info.bSubProject = Convert.ToBoolean(reader["SubProject"]);
                        info.strLocation = reader["Location"].ToString();
                        info.strMainProjecID = reader["MainProjectID"].ToString();
                    }
                    conn.Close();
                }
            }
            return info;
        }
        public bool AddBlockInfo(clsBlock info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddBlock"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@Blockno", info.BlockNo);
                            cmd.Parameters.AddWithValue("@Blockname", info.BlockName);
                            cmd.Parameters.AddWithValue("@ProjectID", info.ProjectID);

                            cmd.Parameters.AddWithValue("@TotalArea", info.decTotalArea);
                            cmd.Parameters.AddWithValue("@DevelopedArea", info.decDevelopedArea);
                            cmd.Parameters.AddWithValue("@UOMid", info.strUOMid);

                            cmd.Parameters.AddWithValue("@ID", info.id);

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
        public bool AddRegistrationINFO(clsMemberRegistration info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddMemberRegistration"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@RegistrationNo", info.RegistrationNo);
                            cmd.Parameters.AddWithValue("@Prefix", info.strPrefix);
                            cmd.Parameters.AddWithValue("@Number", info.strNumber);
                            cmd.Parameters.AddWithValue("@ClientID", info.ClientID);
                            cmd.Parameters.AddWithValue("@Name", info.Name);
                            cmd.Parameters.AddWithValue("@FatherORHusbandType", info.FatherOrHusbandType);
                            cmd.Parameters.AddWithValue("@FatherORHusband", info.FatherOrHusband);
                            cmd.Parameters.AddWithValue("@CNIC", info.NIDOrCNIC);
                            cmd.Parameters.AddWithValue("@Nationality", info.Nationality);
                            cmd.Parameters.AddWithValue("@DOB", info.DOB);
                            cmd.Parameters.AddWithValue("@CurrentAddress1", info.CurrentAddress1);
                            cmd.Parameters.AddWithValue("@CurrentAddress2", info.CurrentAddress2);
                            cmd.Parameters.AddWithValue("@CurrentAddress3", info.CurrentAddress3);
                            cmd.Parameters.AddWithValue("@Country", info.Country);
                            cmd.Parameters.AddWithValue("@City", info.City);
                            cmd.Parameters.AddWithValue("@PhOff", info.PhOff);
                            cmd.Parameters.AddWithValue("@Res", info.Res);
                            cmd.Parameters.AddWithValue("@Mob", info.Mob);
                            cmd.Parameters.AddWithValue("@Fax", info.Fax);
                            cmd.Parameters.AddWithValue("@EmailAddress", info.EmailAddress);
                            cmd.Parameters.AddWithValue("@Plan", info.Plan);
                            cmd.Parameters.AddWithValue("@Booking", info.Booking);
                            cmd.Parameters.AddWithValue("@Block", info.Block);
                            cmd.Parameters.AddWithValue("@Plot", info.Plot);

                            cmd.Parameters.AddWithValue("@UnitType", info.UnitType);
                            cmd.Parameters.AddWithValue("@UnitCategory", info.UnitCategory);

                            cmd.Parameters.AddWithValue("@UnitRate", info.UnitRate);

                            cmd.Parameters.AddWithValue("@UnitAdditionalChrg", info.UnitAdditionPerc);
                            cmd.Parameters.AddWithValue("@UnitAdditionalCharges", info.UntiAdditionalCharges);

                            cmd.Parameters.AddWithValue("@TotalPrice", info.TotalPrice);
                            cmd.Parameters.AddWithValue("@FinanceAmt", info.FinanceAmt);
                            cmd.Parameters.AddWithValue("@RebatAmt", info.RebatAmt);
                            cmd.Parameters.AddWithValue("@NetRetailPrice", info.NetOrRetailPrice);
                            cmd.Parameters.AddWithValue("@BookingPrice", info.BookingPrice);
                            cmd.Parameters.AddWithValue("@ProjectID", info.strProjectid);
                            cmd.Parameters.AddWithValue("@MembershipStatus", (int)info.MembershipStatus);
                            cmd.Parameters.AddWithValue("@Percentage", (int)info.intPercentage);
                            cmd.Parameters.AddWithValue("@CustomerNumber", info.CustomerNumber);
                            cmd.Parameters.AddWithValue("@BankName", info.BankName);
                            cmd.Parameters.AddWithValue("@AccountTitle", info.AccountTitle);
                            cmd.Parameters.AddWithValue("@AccountNumber", info.AccountNumber);
                            cmd.Parameters.AddWithValue("@SoleOwner", info.bSoleOwner);
                           
                            cmd.Parameters.AddWithValue("@TransferPending", info.bTransferPending);
                            cmd.Parameters.AddWithValue("@SendToGP", info.bSendToGP);
                            cmd.Parameters.AddWithValue("@InstallmentPlanCode", info.strInstallmentPlan);
                            cmd.Parameters.AddWithValue("@CustomerClass", info.strCustomerClass);                            
                            cmd.Parameters.AddWithValue("@Active", info.bActive);

                            cmd.Parameters.AddWithValue("@Installmentcount", info.intInstallmentCount);
                            cmd.Parameters.AddWithValue("@InstallmentFrequency", info.intInstallmentFrequency);
                            cmd.Parameters.AddWithValue("@InstallmentPlanType", info.strInstallmentPlanType);
                            cmd.Parameters.AddWithValue("@InstallmentStartDate", info.dateInstallmentStartDate);
                            cmd.Parameters.AddWithValue("@SalesRep", info.strSalesRep);
                            cmd.Parameters.AddWithValue("@SalesRepPercentage", info.decSalesRepPercentage);
                            cmd.Parameters.AddWithValue("@Dealer", info.strDealer);
                            cmd.Parameters.AddWithValue("@DealerPercentage", info.decDealerPercentage);

                            cmd.Parameters.AddWithValue("@SubDealer", info.strSubDealer);
                            cmd.Parameters.AddWithValue("@SubDealerPercentage", info.decSubDealerPercentage);
                            
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
        public bool DeleteRegistrationINFO(string strRegistrationNumber)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_DeleteMembership"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@RegNo", strRegistrationNumber);
                            

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
        public bool UpdateRegistrationonTransfer(clsMemberRegistration info, string olcdClientID)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_UpdateMemberRegistrationonTransfer"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@RegistrationNo", info.RegistrationNo);
                            cmd.Parameters.AddWithValue("@OldClientID", olcdClientID);
                            cmd.Parameters.AddWithValue("@ClientID", info.ClientID);
                            cmd.Parameters.AddWithValue("@Name", info.Name);
                            cmd.Parameters.AddWithValue("@FatherORHusbandType", info.FatherOrHusbandType);
                            cmd.Parameters.AddWithValue("@FatherORHusband", info.FatherOrHusband);
                            cmd.Parameters.AddWithValue("@CNIC", info.NIDOrCNIC);
                            cmd.Parameters.AddWithValue("@Nationality", info.Nationality);
                            cmd.Parameters.AddWithValue("@DOB", info.DOB);
                            cmd.Parameters.AddWithValue("@CurrentAddress1", info.CurrentAddress1);
                            cmd.Parameters.AddWithValue("@CurrentAddress2", info.CurrentAddress2);
                            cmd.Parameters.AddWithValue("@CurrentAddress3", info.CurrentAddress3);
                            cmd.Parameters.AddWithValue("@Country", info.Country);
                            cmd.Parameters.AddWithValue("@City", info.City);
                            cmd.Parameters.AddWithValue("@PhOff", info.PhOff);
                            cmd.Parameters.AddWithValue("@Res", info.Res);
                            cmd.Parameters.AddWithValue("@Mob", info.Mob);
                            cmd.Parameters.AddWithValue("@Fax", info.Fax);
                            cmd.Parameters.AddWithValue("@EmailAddress", info.EmailAddress);
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
        public bool AddMemberImage(clsMemberImage info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddMemberImage"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@RegistrationNo", info.RegistrationOrBookingNo);
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
        public clsMemberImage GetMemberImage(string RegistrationNumber, string ClientID)
        {
            clsMemberImage image = new clsMemberImage();

            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("TMR_USP_GetMemberImage"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        //conn.Open();
                        cmd.Parameters.AddWithValue("@RegistrationNo", RegistrationNumber);
                        cmd.Parameters.AddWithValue("@ClientID", ClientID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            image.RegistrationOrBookingNo = reader["RegistrationNo"].ToString();
                            image.ImageId = reader["PictureID"].ToString();

                            image.ClientID = reader["ClientID"].ToString();
                            image.Image = (byte[])reader["Picture"];




                            //info.id = int.Parse(reader["id"].ToString());

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
        public bool AddMemberCnic(clsMemberImage info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddMemberCNIC"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@RegistrationNo", info.RegistrationOrBookingNo);
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
        public clsMemberImage GetMemberCnic(string RegistrationNumber, string ClientID)
        {
            clsMemberImage image = new clsMemberImage();

            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("TMR_USP_GetMemberCNIC"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        //conn.Open();
                        cmd.Parameters.AddWithValue("@RegistrationNo", RegistrationNumber);
                        cmd.Parameters.AddWithValue("@ClientID", ClientID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            image.RegistrationOrBookingNo = reader["RegistrationNo"].ToString();
                            image.ImageId = reader["PictureID"].ToString();

                            image.ClientID = reader["ClientID"].ToString();
                            image.Image = (byte[])reader["Picture"];




                            //info.id = int.Parse(reader["id"].ToString());

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
        public clsMemberRegistration GetMemberRegistrationInfo(string strRegistrationNo)
        {
            clsMemberRegistration info = new clsMemberRegistration();
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("TMR_USP_GetMemberRegistration"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        //conn.Open();
                        cmd.Parameters.AddWithValue("@reg", strRegistrationNo);

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
                            info.UnitType = reader["UnitType"].ToString();
                            info.UnitCategory = reader["UnitCategory"].ToString();
                            info.UnitRate = Convert.ToDecimal(reader["UnitRate"].ToString());
                            info.UnitAdditionPerc = Convert.ToDecimal(reader["UnitAdditionalChrg"]);
                            info.UntiAdditionalCharges = Convert.ToDecimal(reader["UnitAdditionalCharges"]);                            
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
                            info.bSoleOwner = Convert.ToBoolean(reader["SoleOwner"]);
                            info.bTransferPending = Convert.ToBoolean(reader["TransferPending"]);
                            info.bSendToGP = Convert.ToBoolean(reader["SendToGP"]);
                            info.bitAllocated = Convert.ToBoolean(reader["Allocated"]);
                            info.strInstallmentPlan = reader["InstallmentPlanCode"].ToString();
                            info.strCustomerClass = reader["CustomerClass"].ToString();
                            info.intInstallmentCount = Convert.ToInt32(reader["Installmentcount"]);
                            info.intInstallmentFrequency = Convert.ToInt32(reader["InstallmentFrequency"]);
                            info.strInstallmentPlanType = reader["InstallmentPlanType"].ToString();
                            info.dateInstallmentStartDate = Convert.ToDateTime(reader["InstallmentStartDate"]);
                            info.strDealer = reader["Dealer"].ToString();
                            info.decDealerPercentage = Convert.ToDecimal(reader["DealerPercentage"]);
                            info.strSubDealer = reader["SubDealer"].ToString();
                            info.decSubDealerPercentage = Convert.ToDecimal(reader["SubDealerPercentage"]);                            
                            info.strSalesRep = (reader["SalesRep"].ToString());
                            info.decSalesRepPercentage = Convert.ToDecimal(reader["SalesRepPercentage"]);
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
        public clsMemberRegistration GetMemberRegistrationInfoByMembershipAndCNIC(string strRegistrationNo, string ClientID)
        {
            clsMemberRegistration info = new clsMemberRegistration();
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("TMR_USP_GetMemberRegistrationByRegistrationClientID"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        //conn.Open();
                        cmd.Parameters.AddWithValue("@reg", strRegistrationNo);
                        cmd.Parameters.AddWithValue("@ClientID", ClientID);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows == false)
                            info = null;

                        while (reader.Read())
                        {
                            info = new clsMemberRegistration();
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

                            info.CustomerNumber = reader["CustomerNumber"].ToString();
                            info.BankName = reader["BankName"].ToString();
                            info.AccountTitle = reader["AccountTitle"].ToString();
                            info.AccountNumber = reader["AccountNumber"].ToString();
                            info.strInstallmentPlan = reader["InstallmentPlanCode"].ToString();

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
        public clsMemberRegistration GetMemberInfoByClientId(string ClientID)
        {
            clsMemberRegistration info = new clsMemberRegistration();
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("TMR_USP_GetMemberRegistrationByClientID"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@ClientID", ClientID);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows == false)
                            info = null;

                        while (reader.Read())
                        {
                            info = new clsMemberRegistration();
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
                            info.EmailAddress = reader["EmailAddress"].ToString();
                            info.ClientID = reader["Clientid"].ToString();

                            info.CustomerNumber = reader["CustomerNumber"].ToString();
                            info.AccountNumber = reader["AccountNumber"].ToString();
                            info.AccountTitle = reader["AccountTitle"].ToString();
                            info.BankName = reader["BankName"].ToString();

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
        public string GenerateCustomerNumber(string ClientID)
        {
            string strNumber = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("TMR_USP_GenerateCustomerNumber"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@ClientID", ClientID);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows == false)
                            return "";

                        while (reader.Read())
                        {
                            strNumber = reader["CurrentNumber"].ToString();

                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception exc)
            {
                strNumber = "";
            }
            finally { }
            return strNumber;
        }
        public bool AddMemberAttachment(clsMemberAttachment attachment)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddMemberAttachment"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
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
        public clsMemberAttachment GetMemberAttachment(int id)
        {
            clsMemberAttachment attachment1 = new clsMemberAttachment();

            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_GetMemberAttachment"))
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
        public List<clsMemberAttachment> GetMemberAttachments(string strMember, string strClient)
        {
            List<clsMemberAttachment> attachments = new List<clsMemberAttachment>();

            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_GetMemberAttachments"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@RegistrationNo", strMember);
                            cmd.Parameters.AddWithValue("@ClientID", strClient);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    clsMemberAttachment attach = new clsMemberAttachment();

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
        public bool AddNomineeINFO(clsNominee info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddNomineeInfo"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@RegistrationNo", info.RegistrationOrBookingNo);
                            cmd.Parameters.AddWithValue("@NomineeID", info.NomineeID);
                            cmd.Parameters.AddWithValue("@ClientID", info.ClientID);
                            cmd.Parameters.AddWithValue("@Name", info.Name);
                            cmd.Parameters.AddWithValue("@FatherORHusband", info.FatherOrHusband);
                            cmd.Parameters.AddWithValue("@CNIC", info.NIDOrCNIC);
                            cmd.Parameters.AddWithValue("@CurrentAddress1", info.CurrentAddress1);
                            cmd.Parameters.AddWithValue("@CurrentAddress2", info.CurrentAddress2);
                            cmd.Parameters.AddWithValue("@CurrentAddress3", info.CurrentAddress3);
                            cmd.Parameters.AddWithValue("@Country", info.Country);
                            cmd.Parameters.AddWithValue("@City", info.City);
                            cmd.Parameters.AddWithValue("@Relation", info.Relation);
                            cmd.Parameters.AddWithValue("@Percentage", info.Percentage);
                            cmd.Parameters.AddWithValue("@id", info.id);

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
        public List<clsNominee> GetNomineeByMemberRegistrationNo(string regno, string clientid)
        {
            List<clsNominee> lst = new List<clsNominee>();
            try
            {

                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("TMR_USP_GetNomineeInfo"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        //conn.Open();
                        cmd.Parameters.AddWithValue("@reg", regno);
                        cmd.Parameters.AddWithValue("@clientID", clientid);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            clsNominee info = new clsNominee();
                            //info.strProjectid = reader["ProjectID"].ToString();
                            info.RegistrationOrBookingNo = reader["RegistrationNo"].ToString();
                            info.NomineeID = reader["NomineeID"].ToString();
                            info.ClientID = reader["ClientID"].ToString();
                            info.Name = reader["Name"].ToString();
                            info.FatherOrHusband = reader["FatherOrHusbandName"].ToString();
                            info.NIDOrCNIC = reader["CNIC"].ToString();
                            info.CurrentAddress1 = reader["CurrentAddress1"].ToString();
                            info.CurrentAddress2 = reader["CurrentAddress2"].ToString();
                            info.CurrentAddress3 = reader["CurrentAddress3"].ToString();
                            info.Country = reader["Country"].ToString();
                            info.City = reader["City"].ToString();
                            info.Relation = reader["Relation"].ToString();
                            info.Percentage = Convert.ToInt32(reader["Percentage"]);
                            info.id = int.Parse(reader["id"].ToString());
                            lst.Add(info);

                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                lst = null;
            }
            finally { }
            return lst;
        }
        public bool AddNomineeImage(clsNomineeImage info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddNomineeImage"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@RegistrationNo", info.RegistrationOrBookingNo);
                            cmd.Parameters.AddWithValue("@NomineeID", info.NomineeID);
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

        /// <summary>
        /// Add Partner Image
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns
        /// 
        /// 
        /// >
        public bool AddPartnerImage(clsPartnerImage info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddPartnerImage"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@RegistrationNo", info.RegistrationNo);
                            cmd.Parameters.AddWithValue("@PartnerID", info.PartnerID);
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

        /// <summary>
        /// Add Partner CNIC
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool AddPartnerCNIC(clsPartnerCNIC info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddPartnerCNIC"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@RegistrationNo", info.RegistrationNo);
                            cmd.Parameters.AddWithValue("@PartnerID", info.PartnerID);
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

        /// <summary>
        /// Add Nominee CNIC
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool AddNomineeCNIC(clsNomineeCNIC info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddNomineeCNIC"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@RegistrationNo", info.RegistrationNo);
                            cmd.Parameters.AddWithValue("@NomineeID", info.NomineeID);
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

        /// <summary Get Nominee Image>
        /// Get Nominee Image
        /// </summary>
        /// <param name="RegistrationNumber, ClientID, NomineeID"></param>
        /// <returns></returns>
        /// 
        public clsNomineeImage GetNomineeImage(string RegistrationNumber, string ClientID, string NomineeID)
        {
            clsNomineeImage image = new clsNomineeImage();

            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("TMR_USP_GetNomineeImage"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        //conn.Open();
                        cmd.Parameters.AddWithValue("@RegistrationNo", RegistrationNumber);
                        cmd.Parameters.AddWithValue("@NomineeID", NomineeID);
                        cmd.Parameters.AddWithValue("@ClientID", ClientID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            image.RegistrationOrBookingNo = reader["RegistrationNo"].ToString();
                            image.NomineeID = reader["NomineeID"].ToString();

                            image.ImageId = reader["PictureID"].ToString();

                            image.ClientID = reader["ClientID"].ToString();
                            image.Image = (byte[])reader["Picture"];




                            //info.id = int.Parse(reader["id"].ToString());

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

        /// <summary Get Nominee CNIC>
        /// Get Nominee CNIC
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        /// 
        public clsNomineeCNIC GetNomineeCNIC(string RegistrationNumber, string ClientID, string NomineeID)
        {
            clsNomineeCNIC image = new clsNomineeCNIC();

            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("TMR_USP_GetNomineeCNIC"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        //conn.Open();
                        cmd.Parameters.AddWithValue("@RegistrationNo", RegistrationNumber);
                        cmd.Parameters.AddWithValue("@NomineeID", NomineeID);
                        cmd.Parameters.AddWithValue("@ClientID", ClientID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            image.RegistrationNo = reader["RegistrationNo"].ToString();
                            image.NomineeID = reader["NomineeID"].ToString();

                            image.ImageId = reader["PictureID"].ToString();

                            image.ClientID = reader["ClientID"].ToString();
                            image.Image = (byte[])reader["Picture"];




                            //info.id = int.Parse(reader["id"].ToString());

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

        /// <summary Get Partner Image>
        /// Get Partner Image
        /// </summary>
        /// <param name="RegistrationNumber, ClientID, PartnerID"></param>
        /// <returns></returns>
        /// 
        public clsPartnerImage GetPartnerImage(string RegistrationNumber, string ClientID, string PartnerID)
        {
            clsPartnerImage image = new clsPartnerImage();

            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("TMR_USP_GetPartnerImage"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        //conn.Open();
                        cmd.Parameters.AddWithValue("@RegistrationNo", RegistrationNumber);
                        cmd.Parameters.AddWithValue("@PartnerID", PartnerID);
                        cmd.Parameters.AddWithValue("@ClientID", ClientID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            image.RegistrationNo = reader["RegistrationNo"].ToString();
                            image.PartnerID = reader["PartnerID"].ToString();

                            image.ImageId = reader["PictureID"].ToString();

                            image.ClientID = reader["ClientID"].ToString();
                            image.Image = (byte[])reader["Picture"];




                            //info.id = int.Parse(reader["id"].ToString());

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

        /// <summary Get Partner CNIC>
        /// Get Partner CNIC
        /// </summary>
        /// <param name="RegistrationNumber, ClientID, PartnerID"></param>
        /// <returns></returns>
        /// 
        public clsPartnerCNIC GetPartnerCNIC(string RegistrationNumber, string ClientID, string PartnerID)
        {
            clsPartnerCNIC image = new clsPartnerCNIC();

            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("TMR_USP_GetPartnerCNIC"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        //conn.Open();
                        cmd.Parameters.AddWithValue("@RegistrationNo", RegistrationNumber);
                        cmd.Parameters.AddWithValue("@PartnerID", PartnerID);
                        cmd.Parameters.AddWithValue("@ClientID", ClientID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            image.RegistrationNo = reader["RegistrationNo"].ToString();
                            image.PartnerID = reader["PartnerID"].ToString();

                            image.ImageId = reader["PictureID"].ToString();

                            image.ClientID = reader["ClientID"].ToString();
                            image.Image = (byte[])reader["Picture"];




                            //info.id = int.Parse(reader["id"].ToString());

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
        public bool AddPartnerINFO(clsPartner info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddPartnerInfo"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@RegistrationNo", info.RegistrationOrBookingNo);
                            cmd.Parameters.AddWithValue("@PartnerID", info.PartnerID);
                            cmd.Parameters.AddWithValue("@ClientID", info.ClientID);
                            cmd.Parameters.AddWithValue("@Name", info.Name);
                            cmd.Parameters.AddWithValue("@FatherORHusband", info.FatherOrHusband);
                            cmd.Parameters.AddWithValue("@CNIC", info.NIDOrCNIC);
                            cmd.Parameters.AddWithValue("@CurrentAddress1", info.CurrentAddress1);
                            cmd.Parameters.AddWithValue("@CurrentAddress2", info.CurrentAddress2);
                            cmd.Parameters.AddWithValue("@CurrentAddress3", info.CurrentAddress3);
                            cmd.Parameters.AddWithValue("@Country", info.Country);
                            cmd.Parameters.AddWithValue("@City", info.City);
                            cmd.Parameters.AddWithValue("@Relation", info.Relation);
                            cmd.Parameters.AddWithValue("@Percentage", info.Percentage);
                            cmd.Parameters.AddWithValue("@BankName", info.BankName);
                            cmd.Parameters.AddWithValue("@AccountTitle", info.AccountTitle);
                            cmd.Parameters.AddWithValue("@AccountNumber", info.AccountNumber);
                            cmd.Parameters.AddWithValue("@id", info.id);


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
        public List<clsPartner> GetPartnerByMemberRegistrationNo(string regno, string clientID)
        {
            List<clsPartner> lst = new List<clsPartner>();

            try
            {

                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("TMR_USP_GetPartnerInfo"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        //conn.Open();
                        cmd.Parameters.AddWithValue("@reg", regno);
                        cmd.Parameters.AddWithValue("@clientID", clientID);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            clsPartner info = new clsPartner();
                            //info.strProjectid = reader["ProjectID"].ToString();
                            info.RegistrationOrBookingNo = reader["RegistrationNo"].ToString();
                            info.PartnerID = reader["PartnerID"].ToString();
                            info.ClientID = reader["ClientID"].ToString();
                            info.Name = reader["Name"].ToString();
                            info.FatherOrHusband = reader["FatherOrHusbandName"].ToString();
                            info.NIDOrCNIC = reader["CNIC"].ToString();
                            info.CurrentAddress1 = reader["CurrentAddress1"].ToString();
                            info.CurrentAddress2 = reader["CurrentAddress2"].ToString();
                            info.CurrentAddress3 = reader["CurrentAddress3"].ToString();
                            info.Country = reader["Country"].ToString();
                            info.City = reader["City"].ToString();

                            info.BankName = reader["BankName"].ToString();
                            info.AccountNumber = reader["AccountNumber"].ToString();
                            info.AccountTitle = reader["AccountTitle"].ToString();

                            info.Relation = reader["Relation"].ToString();
                            info.Percentage = Convert.ToInt32(reader["Percentage"]);

                            info.id = int.Parse(reader["id"].ToString());
                            lst.Add(info);

                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception exc)
            {
                lst = null;
            }
            finally { }
            return lst;
        }
        public bool AddTransferInfo(clsTransfer info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddTrensferInfo"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@RegistrationNo", info.RegistrationOrBookingNo);
                            cmd.Parameters.AddWithValue("@TransferID", info.TransferID);
                            cmd.Parameters.AddWithValue("@Name", info.Name);
                            cmd.Parameters.AddWithValue("@FatherORHusbandType", info.FatherOrHusbandType);
                            cmd.Parameters.AddWithValue("@FatherORHusband", info.FatherOrHusband);
                            cmd.Parameters.AddWithValue("@CNIC", info.NIDOrCNIC);
                            cmd.Parameters.AddWithValue("@Nationality", info.Nationality);
                            cmd.Parameters.AddWithValue("@DOB", info.DOB);
                            cmd.Parameters.AddWithValue("@CurrentAddress1", info.CurrentAddress1);
                            cmd.Parameters.AddWithValue("@CurrentAddress2", info.CurrentAddress2);
                            cmd.Parameters.AddWithValue("@CurrentAddress3", info.CurrentAddress3);
                            cmd.Parameters.AddWithValue("@Country", info.Country);
                            cmd.Parameters.AddWithValue("@City", info.City);
                            cmd.Parameters.AddWithValue("@PhOff", info.PhOff);
                            cmd.Parameters.AddWithValue("@Res", info.Res);
                            cmd.Parameters.AddWithValue("@Mob", info.Mob);
                            cmd.Parameters.AddWithValue("@Fax", info.Fax);
                            cmd.Parameters.AddWithValue("@EmailAddress", info.EmailAddress);

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
        public clsTransfer GetTransferInfo(string strRegistrationNo)
        {
            clsTransfer info = new clsTransfer();
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("TMR_USP_GetTransferInfo"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        //conn.Open();
                        cmd.Parameters.AddWithValue("@reg", strRegistrationNo);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows == false)
                            info = null;

                        while (reader.Read())
                        {
                            info = new clsTransfer();
                            info.RegistrationOrBookingNo = reader["RegistrationNo"].ToString();
                            info.TransferID = reader["TransferID"].ToString();
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
                            //info.id = int.Parse(reader["id"].ToString());

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
       
        /// <summary>
        /// Update MemberReg After Deallocation 
        /// </summary>
        /// <param name="regNo"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public bool UpdateMemberRegistrationAfterDeallocation(clsMemberRegistration info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_UpdateMemRegAfterDeAllocation"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@RegistrationNo", info.RegistrationNo);
                            cmd.Parameters.AddWithValue("@ProjectID", info.strProjectid);
                            cmd.Parameters.AddWithValue("@Block", info.Block);
                            cmd.Parameters.AddWithValue("@Plot", info.Plot);
                            cmd.Parameters.AddWithValue("@Status", info.strStatus);
                            cmd.Parameters.AddWithValue("@Allocated", info.bitAllocated);
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
        /// Insert into Deallocation Table
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool AddDeallocationInfo(clsDeAllocation info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddDeAllocation"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@RegistrationNo", info.RegistrationOrBookingNo);
                            cmd.Parameters.AddWithValue("@ClientID", info.ClientID);
                            cmd.Parameters.AddWithValue("@DeAllocationDate", info.DeAllocationDate);

                            cmd.Parameters.AddWithValue("@Approve", info.Approved);
                            cmd.Parameters.AddWithValue("@Remarks", info.Remarks);



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
        public List<clsDeAllocation> GetAllDeallocationList()
        {
            List<clsDeAllocation> lst = new List<clsDeAllocation>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetAllDeallocations"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsDeAllocation();

                        info.RegistrationOrBookingNo = reader["RegistrationNo"].ToString();
                        info.ClientID = reader["ClientID"].ToString();
                        info.DeAllocationDate = Convert.ToDateTime(reader["DeAllocationDate"].ToString());
                        info.Approved = Convert.ToBoolean(reader["Approve"].ToString());
                        info.Remarks = reader["Remarks"].ToString();
                        info.id = Convert.ToInt32(reader["id"].ToString());

                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }      
        public clsTransferImage GetTransferImage(string RegistrationNumber, string ClientID)
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
                       
                        cmd.Parameters.AddWithValue("@RegistrationNo", RegistrationNumber);
                        cmd.Parameters.AddWithValue("@ClientID", ClientID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            image.RegistrationNo = reader["RegistrationNo"].ToString();
                            image.ImageId = reader["PictureID"].ToString();

                            image.ClientID = reader["ClientID"].ToString();
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

        public clsTransferCNIC GetTransferCNIC(string RegistrationNumber, string ClientID)
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

                        cmd.Parameters.AddWithValue("@RegistrationNo", RegistrationNumber);
                        cmd.Parameters.AddWithValue("@ClientID", ClientID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            image.RegistrationNo = reader["RegistrationNo"].ToString();
                            image.ImageId = reader["PictureID"].ToString();

                            image.ClientID = reader["ClientID"].ToString();
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

        public bool UpdateTransferStatus(int id)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_UpdateTransferStatus"))
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

        public bool UpdateSendToGPStatus(int id)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_UpdateSendToGPStatus"))
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
