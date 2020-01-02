using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TMR.GP.GrandCityAddon
{
    public partial class DataAccess
    {
        public List<clsUser> GetAllUsers()
        {
            List<clsUser> lst = new List<clsUser>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetAllUsers"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsUser();

                        info.UserID = reader["UserID"].ToString();
                        info.UserName = reader["UserName"].ToString();
                        info.PassWord = reader["PassWord"].ToString();
                        info.UserTypeID = Convert.ToInt32(reader["UserTypeID"]);
                        info.UserTypeName = reader["UserTypeName"].ToString();
                        info.inactive = Convert.ToBoolean(reader["Inactive"]);
                        info.id = Convert.ToInt32(reader["id"]);

                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public clsUser GetUserByUserID(string userid)
        {
            clsUser user = new clsUser();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetUserByUserID"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@UserID", userid);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        user = new clsUser();

                        user.UserID = reader["UserID"].ToString();
                        user.UserName = reader["UserName"].ToString();
                        user.PassWord = reader["PassWord"].ToString();
                        user.UserTypeID = Convert.ToInt32(reader["UserTypeID"]);
                        user.UserTypeName = reader["UserTypeName"].ToString();
                        user.inactive = Convert.ToBoolean(reader["Inactive"]);
                        user.id = Convert.ToInt32(reader["id"]);
                    }
                    conn.Close();
                }
            }
            return user;
        }
        public clsUserRights GetUserRightsByUserID(string userid, string strFormID)
        {
            clsUserRights rights = new clsUserRights();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_UserRights"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@UserID", userid);
                    cmd.Parameters.AddWithValue("@FormID", strFormID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        rights = new clsUserRights();

                        rights.UserID = reader["UserID"].ToString();
                        rights.FormID = reader["FormID"].ToString();
                        rights.AllowOpen = Convert.ToBoolean(reader["AllowOpen"]);
                        rights.AllowPost = Convert.ToBoolean(reader["AllowPost"]);
                        rights.AllowSave = Convert.ToBoolean(reader["AllowSave"]);
                        rights.id = Convert.ToInt32(reader["id"]);
                    }
                    conn.Close();
                }
            }
            return rights;

        }
    
    }
}