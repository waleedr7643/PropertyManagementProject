using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TMR.GP.REMSDal
{
    public partial class DataAccess
    {
       
        public List<string> GetCustomerClasses(string DBName)
        {
            List<string> lst = new List<string>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetCustomerClasses"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@DBName", DBName);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var result = reader["CLASSID"].ToString().Trim();
                        lst.Add(result);
                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public List<string> GetSalesPersons(string DBName)
        {
            List<string> lst = new List<string>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetSalesPersons"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@DBName", DBName);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var result = reader["Vendorid"].ToString().Trim();
                        lst.Add(result);
                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public List<string> GetDealers(string DBName)
        {
            List<string> lst = new List<string>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetDealers"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@DBName", DBName);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var result = reader["Vendorid"].ToString().Trim();
                        lst.Add(result);
                    }
                    conn.Close();
                }
            }
            return lst;
        }
    }
}