using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using TMR.GP.REMSDal;
using TMR.GP.REMSDal.EntityClasses;

namespace TMR.GP.REMSDal
{
    public partial class DataAccess
    {
        public List<clsSecurityObject> GetObjectNameandObjectAreaFromObjectSecurity()
        {
            List<clsSecurityObject> lst = new List<clsSecurityObject>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetObjectAreaFromSecurityObject"))
                {   
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsSecurityObject();

                        info.ObjectArea = reader["ObjectArea"].ToString();

                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }

        public List<clsUserSecurity> GetUserIdList()
        {
            
            List<clsUserSecurity> lst = new List<clsUserSecurity>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetUsersList"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsUserSecurity();
                        info.UserId = reader["userid"].ToString();
                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;

        }


        public List<clsSecurityObject> GetObjectNameByObjectArea(string strObjectArea)
        {
            List<clsSecurityObject> lst = new List<clsSecurityObject>();
            clsSecurityObject obj;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_SecurityObjectRights"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@ObjectArea", strObjectArea);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        obj = new clsSecurityObject();

                        obj.ObjectName = reader["ObjectName"].ToString();
                        
                        lst.Add(obj);
                        
                    }
                    conn.Close();
                }
            }
            return lst;

        }

        public List<clsSecurityObject> GetObjectSecurityByObjectNameAndUserID(string strObjectArea,string userid)
        {
            List<clsSecurityObject> lst = new List<clsSecurityObject>();
            clsSecurityObject obj;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetSecurityObjectRightsByUserIdAndObjectArea"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@ObjectArea", strObjectArea);
                    cmd.Parameters.AddWithValue("@UserId", userid);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        obj = new clsSecurityObject();

                        obj.ObjectName = reader["ObjectName"].ToString();
                        obj.AllowOpen = Convert.ToBoolean(reader["AllowOpen"]);
                        obj.AllowSave = Convert.ToBoolean(reader["AllowSave"]);
                        obj.AllowPost = Convert.ToBoolean(reader["AllowPost"]);
                        obj.AllowPrint = Convert.ToBoolean(reader["AllowPrint"]);

                        lst.Add(obj);

                    }
                    conn.Close();
                }
            }
            return lst;

        }
    }
}
