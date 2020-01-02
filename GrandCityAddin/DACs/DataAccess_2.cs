using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TMR.GP.GrandCityAddon
{
    public partial class DataAccess
    {

        public bool AddUOMInfo(clsUnitofMeasure info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddUOMInfo"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@UnitID", info.strUOMid);
                            cmd.Parameters.AddWithValue("@UnitDescription", info.strUOMDesc);
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
        public List<clsUnitofMeasure> GetAllUOMsInfo()
        {
            List<clsUnitofMeasure> lst = new List<clsUnitofMeasure>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetUOMInfo"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsUnitofMeasure();

                        info.strUOMid = reader["UnitofMID"].ToString();
                        info.strUOMDesc = reader["UnitofMDescription"].ToString();
                        info.id = Convert.ToInt32(reader["ID"]);

                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public bool AddUnitCategory(clsUnitCategory info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddUnitCategory"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@UnitCategoryID", info.strUnitCategoryID);
                            cmd.Parameters.AddWithValue("@UnitCategoryDescription", info.strDesc);
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
        public List<clsUnitCategory> GetAllUnitCategoryInfo()
        {
            List<clsUnitCategory> lst = new List<clsUnitCategory>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetUnitCategory"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsUnitCategory();

                        info.strUnitCategoryID = reader["UnitCategoryID"].ToString();
                        info.strDesc = reader["UnitCategoryDescription"].ToString();
                        info.id = Convert.ToInt32(reader["ID"]);

                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public bool AddUnitType(clsUnitType info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddUnitType"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@UnitTypeID", info.strUnitTypeID);
                            cmd.Parameters.AddWithValue("@UnitTypeDescription", info.strDesc);
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
        public List<clsUnitType> GetAllUnitTypeInfo()
        {
            List<clsUnitType> lst = new List<clsUnitType>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetUnitType"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsUnitType();

                        info.strUnitTypeID = reader["UnitTypeID"].ToString();
                        info.strDesc = reader["UnitTypeDescription"].ToString();
                        info.id = Convert.ToInt32(reader["ID"]);

                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public bool AddSizeCode(clsSizeCodes info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddSizeCode"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@Project", info.strProject);
                            cmd.Parameters.AddWithValue("@UnitSizeCode", info.strUnitSizeCode);
                            cmd.Parameters.AddWithValue("@UnitSizeDescription", info.strUnitSizeDescription);
                            cmd.Parameters.AddWithValue("@Area", info.decArea);
                            cmd.Parameters.AddWithValue("@UnitID", info.UoMID);
                            cmd.Parameters.AddWithValue("@UnitDescription", info.UoMDescription);
                            cmd.Parameters.AddWithValue("@Prefix", info.strPrefix);
                            cmd.Parameters.AddWithValue("@CurrentNumber", info.strCurrentNumber);
                            cmd.Parameters.AddWithValue("@ID", info.ID);
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
        public List<clsSizeCodes> GetAllSizeCodeInfo()
        {
            List<clsSizeCodes> lst = new List<clsSizeCodes>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetSizeCode"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@id", 0);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsSizeCodes();
                        info.strProject = reader["Project"].ToString();
                        info.strUnitSizeCode = reader["UnitSizeCode"].ToString();
                        info.strUnitSizeDescription = reader["UnitSizeDescription"].ToString();
                        info.decArea = Convert.ToDecimal(reader["Area"]);
                        info.UoMID = reader["UoMID"].ToString();
                        info.UoMDescription = reader["UoMDescription"].ToString();
                        info.strPrefix = reader["Prefix"].ToString();
                        info.strCurrentNumber = reader["CurrentNumber"].ToString();
                        info.ID = Convert.ToInt32(reader["ID"]);

                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public List<clsSizeCodes> GetAllSizeCodeInfoByProject(string strProject)
        {
            List<clsSizeCodes> lst = new List<clsSizeCodes>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetSizeCodeByProject"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@ProjectID", strProject);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsSizeCodes();
                        info.strProject = reader["Project"].ToString();
                        info.strUnitSizeCode = reader["UnitSizeCode"].ToString();
                        info.strUnitSizeDescription = reader["UnitSizeDescription"].ToString();
                        info.decArea = Convert.ToDecimal(reader["Area"]);
                        info.UoMID = reader["UoMID"].ToString();
                        info.UoMDescription = reader["UoMDescription"].ToString();
                        info.strPrefix = reader["Prefix"].ToString();
                        info.strCurrentNumber = reader["CurrentNumber"].ToString();
                        info.ID = Convert.ToInt32(reader["ID"]);

                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public bool AddUnit(clsUnit info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddUnit"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@UnitID", info.strUnitID);
                            cmd.Parameters.AddWithValue("@Prefix", info.strPrefix);
                            cmd.Parameters.AddWithValue("@Number", info.strNumber);
                            cmd.Parameters.AddWithValue("@ProjectID", info.strProjectID);
                            cmd.Parameters.AddWithValue("@BlockNo", info.strBlockNo);
                            cmd.Parameters.AddWithValue("@StreetNo", info.strStreetNo);
                            cmd.Parameters.AddWithValue("@PlotNo", info.strPlotNo);
                            cmd.Parameters.AddWithValue("@SizeCode", info.strSizeCode);
                            cmd.Parameters.AddWithValue("@UnitCategoryID", info.strUnitCategoryID);
                            cmd.Parameters.AddWithValue("@UnitTypeID", info.strUnitTypeID);
                            cmd.Parameters.AddWithValue("@Status", info.strStatus);

                            cmd.Parameters.AddWithValue("@Area", info.decArea);
                            cmd.Parameters.AddWithValue("@UOMID", info.strUOMID);
                            cmd.Parameters.AddWithValue("@Width", info.decWidth);
                            cmd.Parameters.AddWithValue("@Length", info.decLength);
                            cmd.Parameters.AddWithValue("@RegistrationNo", info.strRegistrationNo);
                            cmd.Parameters.AddWithValue("@Price", info.decPrice);
                            cmd.Parameters.AddWithValue("@Statuscode", (int)info.statuscode);
                            cmd.Parameters.AddWithValue("@ID", info.ID);
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
        public List<clsUnit> GetAllUnits()
        {
            List<clsUnit> lst = new List<clsUnit>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetAllUnits"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsUnit();

                        info.strUnitID = reader["UnitID"].ToString();
                        info.strProjectID = reader["ProjectID"].ToString();
                        info.strBlockNo = reader["BlockNo"].ToString();
                        info.strStreetNo = reader["StreetNo"].ToString();
                        info.strPlotNo = reader["PlotNo"].ToString();
                        info.strSizeCode = reader["SizeCode"].ToString();
                        info.strUnitCategoryID = reader["UnitCategoryID"].ToString();
                        info.strUnitTypeID = reader["UnitTypeID"].ToString();
                        info.strStatus = reader["Status"].ToString();

                        info.decArea = Convert.ToDecimal(reader["Area"]);
                        info.strUOMID = reader["UOMID"].ToString();
                        info.decWidth = Convert.ToDecimal(reader["Width"]);
                        info.decLength = Convert.ToDecimal(reader["Length"]);
                        info.decPrice = Convert.ToDecimal(reader["Price"]);
                        info.strRegistrationNo = reader["RegistrationNo"].ToString();
                        info.ID = Convert.ToInt32(reader["ID"]);

                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public List<clsUnit> GetAllUnitsByProjectID(string strProject)
        {
            List<clsUnit> lst = new List<clsUnit>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetAllUnitsByProject"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@Project", strProject);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsUnit();

                        info.strUnitID = reader["UnitID"].ToString();
                        info.strProjectID = reader["ProjectID"].ToString();
                        info.strBlockNo = reader["BlockNo"].ToString();
                        info.strStreetNo = reader["StreetNo"].ToString();
                        info.strPlotNo = reader["PlotNo"].ToString();
                        info.strSizeCode = reader["SizeCode"].ToString();
                        info.strUnitCategoryID = reader["UnitCategoryID"].ToString();
                        info.strUnitTypeID = reader["UnitTypeID"].ToString();
                        info.strStatus = reader["Status"].ToString();

                        info.decArea = Convert.ToDecimal(reader["Area"]);
                        info.strUOMID = reader["UOMID"].ToString();
                        info.decWidth = Convert.ToDecimal(reader["Width"]);
                        info.decLength = Convert.ToDecimal(reader["Length"]);
                        info.decPrice = Convert.ToDecimal(reader["Price"]);
                        info.strRegistrationNo = reader["RegistrationNo"].ToString();
                        info.ID = Convert.ToInt32(reader["ID"]);

                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public bool GetUnitIDAvailability(string strUnitID)
        {
            bool isAvailable = false;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_CheckUnitIDAvailable"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@UnitID", strUnitID);

                    var result = cmd.ExecuteScalar();
                    if (Convert.ToInt32(result) > 0)
                        isAvailable = false;
                    else
                        isAvailable = true;
                    conn.Close();
                }
            }
            return isAvailable;
        }
        public clsSizeCodes GetSizeCodeInfoByProjectandSizeCode(string Project, string SizeCode)
        {
            clsSizeCodes info = new clsSizeCodes();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_UnitIDByProjectandSizeCode"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@ProjectID", Project);
                    cmd.Parameters.AddWithValue("@SizeCodeID", SizeCode);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        info.strUnitSizeCode = reader["Project"].ToString();
                        info.strUnitSizeCode = reader["UnitSizeCode"].ToString();
                        info.strUnitSizeDescription = reader["UnitSizeDescription"].ToString();
                        info.decArea = Convert.ToDecimal(reader["Area"]);
                        info.UoMID = reader["UoMID"].ToString();
                        info.UoMDescription = reader["UoMDescription"].ToString();
                        info.strPrefix = reader["Prefix"].ToString();
                        info.strCurrentNumber = reader["CurrentNumber"].ToString();
                        info.ID = Convert.ToInt32(reader["ID"]);
                    }
                    conn.Close();
                }
            }
            return info;
        }
        public List<clsSizeCodes> GetAllSizeCodes()
        {
            List<clsSizeCodes> lst = new List<clsSizeCodes>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetSizeCode"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@id", 0);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        clsSizeCodes info = new clsSizeCodes();
                        info.strUnitSizeCode = reader["UnitSizeCode"].ToString();
                        info.strUnitSizeDescription = reader["UnitSizeDescription"].ToString();
                        info.decArea = Convert.ToDecimal(reader["Area"]);
                        info.UoMID = reader["UoMID"].ToString();
                        info.UoMDescription = reader["UoMDescription"].ToString();
                        info.strPrefix = reader["Prefix"].ToString();
                        info.strCurrentNumber = reader["CurrentNumber"].ToString();
                        info.ID = Convert.ToInt32(reader["ID"]);

                        lst.Add(info);
                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public List<clsMemberRegistration> GetMemberRegistration(clsMemberShipFilter filter)
        {
            List<clsMemberRegistration> lst = new List<clsMemberRegistration>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("TMR_USP_GetMembership"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        //conn.Open();


                        cmd.Parameters.AddWithValue("@ProjectID", filter.strProjectID);
                        cmd.Parameters.AddWithValue("@Block", filter.strBlockNo);
                        cmd.Parameters.AddWithValue("@RegistrationNo", filter.strMemberShipID);
                        cmd.Parameters.AddWithValue("@MobileNumber", filter.strMobileNumber);
                        cmd.Parameters.AddWithValue("@Name", filter.strName);
                        cmd.Parameters.AddWithValue("@ClientID", filter.strClientID);
                        cmd.Parameters.AddWithValue("@StatusCode", (int)filter.membershipStatus);
                        cmd.Parameters.AddWithValue("@FilterAllocated", filter.bFilterAllocated);
                        cmd.Parameters.AddWithValue("@Allocated", filter.bAllocated);
                        cmd.Parameters.AddWithValue("@ForProcess", filter.bForProcess);

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
                            info.strStatus = reader["Status"].ToString();
                            info.bitAllocated = Convert.ToBoolean(reader["Allocated"]);
                            info.bTransferPending = Convert.ToBoolean(reader["TransferPending"]);
                            info.bSendToGP = Convert.ToBoolean(reader["SendToGP"]);

                            lst.Add(info);

                        }
                        conn.Close();

                    }
                }
                catch(Exception exc) { }
                finally { }
            }
            return lst;
        }

        /// <summary>
        /// //////Available Units
        /// </summary>
        /// <param name="strProject"></param>
        /// <param name="strBlock"></param>
        /// <returns></returns>
        public List<clsUnit> GetAvailableUnits(string strProject, string strBlock)
        {
            List<clsUnit> lst = new List<clsUnit>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetAvailableUnits"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@ProjectId", strProject);
                    cmd.Parameters.AddWithValue("@BlockNo", strBlock);
                    //cmd.Parameters.AddWithValue("@SizeCode", strSizeCode);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsUnit();

                        info.strUnitID = reader["UnitID"].ToString();
                        info.strProjectID = reader["ProjectID"].ToString();
                        info.strBlockNo = reader["BlockNo"].ToString();
                        info.strStreetNo = reader["StreetNo"].ToString();
                        info.strPlotNo = reader["PlotNo"].ToString();
                        info.strSizeCode = reader["SizeCode"].ToString();
                        info.strUnitCategoryID = reader["UnitCategoryID"].ToString();
                        info.strUnitTypeID = reader["UnitTypeID"].ToString();
                        info.strStatus = reader["Status"].ToString();

                        info.decArea = Convert.ToDecimal(reader["Area"]);
                        info.strUOMID = reader["UOMID"].ToString();
                        info.decWidth = Convert.ToDecimal(reader["Width"]);
                        info.decLength = Convert.ToDecimal(reader["Length"]);
                        info.decPrice = Convert.ToDecimal(reader["Price"]);
                        info.strRegistrationNo = reader["RegistrationNo"].ToString();
                        info.ID = Convert.ToInt32(reader["ID"]);

                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }
        /// <summary>
        /// Get Units having status AVailable
        /// </summary>
        /// <param name="strProject"></param>
        /// <param name="strBlock"></param>
        /// <param name="strSizeCode"></param>
        /// <returns></returns>
        public List<clsUnit> GetAvailableUnitsByProjectBlockSizeCode(string strProject, string strBlock, string strSizeCode)
        {
            List<clsUnit> lst = new List<clsUnit>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetAvailableUnitsBySizeCode"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@ProjectId", strProject);
                    cmd.Parameters.AddWithValue("@BlockNo", strBlock);
                    cmd.Parameters.AddWithValue("@SizeCode", strSizeCode);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsUnit();

                        info.strUnitID = reader["UnitID"].ToString();
                        info.strProjectID = reader["ProjectID"].ToString();
                        info.strBlockNo = reader["BlockNo"].ToString();
                        info.strStreetNo = reader["StreetNo"].ToString();
                        info.strPlotNo = reader["PlotNo"].ToString();
                        info.strSizeCode = reader["SizeCode"].ToString();
                        info.strUnitCategoryID = reader["UnitCategoryID"].ToString();
                        info.strUnitTypeID = reader["UnitTypeID"].ToString();
                        info.strStatus = reader["Status"].ToString();

                        info.decArea = Convert.ToDecimal(reader["Area"]);
                        info.strUOMID = reader["UOMID"].ToString();
                        info.decWidth = Convert.ToDecimal(reader["Width"]);
                        info.decLength = Convert.ToDecimal(reader["Length"]);
                        info.decPrice = Convert.ToDecimal(reader["Price"]);
                        info.strRegistrationNo = reader["RegistrationNo"].ToString();
                        info.ID = Convert.ToInt32(reader["ID"]);

                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public bool UpdateUnitStatus(string status, string unitid, string RegNo, int statusCode, string DirectorName = "")
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_UpdateUnitStatus"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@UnitID", unitid);
                            cmd.Parameters.AddWithValue("@Status", status);
                            cmd.Parameters.AddWithValue("@StatusCode", statusCode);
                            cmd.Parameters.AddWithValue("@RegistrationNo", RegNo);
                            cmd.Parameters.AddWithValue("@DirectorName", DirectorName);

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
        public bool AddDirector(clsDirector info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddDirector"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@DirectorName", info.strName);
                            cmd.Parameters.AddWithValue("@CNIC", info.strCNIC);

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
        public List<clsDirector> GetAllDirectors()
        {
            List<clsDirector> lst = new List<clsDirector>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetDirectors"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsDirector();

                        info.strName = reader["DirectorName"].ToString();
                        info.strCNIC = reader["Cnic"].ToString();
                        info.id = Convert.ToInt32(reader["ID"]);

                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }
    }
}