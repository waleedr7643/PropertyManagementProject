using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TMR.GP.REMSDal
{
    public partial class DataAccess
    {
        public bool AddProjectInfo(clsProjects info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddProject"))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@ProjectID", info.strProjectid);
                            cmd.Parameters.AddWithValue("@Prefix", info.strPrefix);
                            cmd.Parameters.AddWithValue("@Number", info.strNumber);
                            cmd.Parameters.AddWithValue("@ProjectName", info.strProjectName);
                            cmd.Parameters.AddWithValue("@ID", info.id);
                            cmd.Parameters.AddWithValue("@SubProject", info.bSubProject);
                            cmd.Parameters.AddWithValue("@Location", info.strLocation);
                            cmd.Parameters.AddWithValue("@MainProjectID", info.strMainProjecID);


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
        public List<clsProjects> GetAllProjectsInfo()
        {
            List<clsProjects> lst = new List<clsProjects>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetAllProjects"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsProjects();

                        info.strProjectid = reader["ProjectID"].ToString();
                        info.strPrefix = reader["Prefix"].ToString();
                        info.strNumber = reader["Number"].ToString();
                        info.strProjectName = reader["ProjectName"].ToString();
                        info.id = Convert.ToInt32(reader["ID"]);
                        info.bSubProject = Convert.ToBoolean(reader["SubProject"]);
                        info.strLocation = reader["Location"].ToString();
                        info.strMainProjecID = reader["MainProjectID"].ToString();

                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public List<clsProjects> GetMainProjects(bool subproject)
        {
            List<clsProjects> lst = new List<clsProjects>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand("[TMR_USP_GetMainProjects]"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@SubProject", subproject);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            var info = new clsProjects();

                            info.strProjectid = reader["ProjectID"].ToString();
                            info.strPrefix = reader["Prefix"].ToString();
                            info.strNumber = reader["Number"].ToString();
                            info.strProjectName = reader["ProjectName"].ToString();
                            info.id = Convert.ToInt32(reader["ID"]);
                            info.bSubProject = Convert.ToBoolean(reader["SubProject"].ToString());
                            info.strLocation = reader["Location"].ToString();
                            info.strMainProjecID = reader["MainProjectID"].ToString();
                            lst.Add(info);

                        }
                        conn.Close();
                    }


                }

                catch (Exception ex) { }

            }

            return lst;
        }
        public string GetProjectDBName(string strProject)
        {
            string DBName = "";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetProjectDBName"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@Project",strProject);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        DBName = reader["DBName"].ToString();
                    }
                    conn.Close();
                }
            }
            return DBName;
        }
    }
}