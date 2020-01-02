using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TMR.GP.GrandCityAddon
{
    public partial class DataAccess
    {
        public bool CreateGPCustomer(clsMemberRegistration info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = this.GetDBConection(ConnectionType.Company,info.strProjectid))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_CreateCustomer"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
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
                            cmd.Parameters.AddWithValue("@custclas", "USA-ILMO-T1");
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
            int st = 0;
            try
            {
                using (SqlConnection conn = this.GetDBConection(ConnectionType.Company, info.strProjectid))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_UpdateCustomer"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
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
      
    }
}