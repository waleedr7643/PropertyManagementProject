using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TMR.GP.GrandCityAddon
{
    public partial class DataAccess
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
        public bool ProjectsDeletion(string projectid)
        {
            bool allowDelete = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "TMR_USP_CheckProjectForDelete";
                        cmd.Parameters.AddWithValue("@ProjectID", projectid);
                        cmd.Connection = conn;
                        adapter.SelectCommand = cmd;

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count == 0)
                            return false;
                        foreach (DataRow dr in dt.Rows)
                        {
                            allowDelete = Convert.ToBoolean(dr["Allowdelete"]);
                        }
                    }
                    return allowDelete;
                }
            }
            catch (Exception)
            {
                return allowDelete;
            }
        }
        public bool BlocksDeletion(string blockid)
        {
            bool allowDelete = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "TMR_USP_CheckProjectForDelete";
                        cmd.Parameters.AddWithValue("@BlockID", blockid);
                        cmd.Connection = conn;
                        adapter.SelectCommand = cmd;

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count == 0)
                            return false;
                        foreach (DataRow dr in dt.Rows)
                        {
                            allowDelete = Convert.ToBoolean(dr["Allowdelete"]);
                        }
                    }
                    return allowDelete;
                }
            }
            catch (Exception)
            {
                return allowDelete;
            }
        }
        public bool UnitsDeletion(string unitid)
        {
            bool allowDelete = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "TMR_USP_CheckProjectForDelete";
                        cmd.Parameters.AddWithValue("@UnitID", unitid);
                        cmd.Connection = conn;
                        adapter.SelectCommand = cmd;

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count == 0)
                            return false;
                        foreach (DataRow dr in dt.Rows)
                        {
                            allowDelete = Convert.ToBoolean(dr["Allowdelete"]);
                        }
                    }
                    return allowDelete;
                }
            }
            catch (Exception)
            {
                return allowDelete;
            }
        }
        public bool SizeCodesDeletion(string SizeCode)
        {
            bool allowDelete = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "TMR_USP_CheckSizecodesForDelete";
                        cmd.Parameters.AddWithValue("@SizeCode", SizeCode);
                        cmd.Connection = conn;
                        adapter.SelectCommand = cmd;

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count == 0)
                            return false;
                        foreach (DataRow dr in dt.Rows)
                        {
                            allowDelete = Convert.ToBoolean(dr["Allowdelete"]);
                        }
                    }
                    return allowDelete;
                }
            }
            catch (Exception)
            {
                return allowDelete;
            }
        }
        public bool UnitTypesDeletion(string UnitTypeID)
        {
            bool allowDelete = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "TMR_USP_CheckUnitTypeForDelete";
                        cmd.Parameters.AddWithValue("@UnitTypeID", UnitTypeID);
                        cmd.Connection = conn;
                        adapter.SelectCommand = cmd;

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count == 0)
                            return false;
                        foreach (DataRow dr in dt.Rows)
                        {
                            allowDelete = Convert.ToBoolean(dr["Allowdelete"]);
                        }
                    }
                    return allowDelete;
                }
            }
            catch (Exception)
            {
                return allowDelete;
            }
        }
        public bool UnitofMeasuresDeletion(string UnitofMID)
        {
            bool allowDelete = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "TMR_USP_CheckUnitOfMeasuresForDelete";
                        cmd.Parameters.AddWithValue("@UnitofMID", UnitofMID);
                        cmd.Connection = conn;
                        adapter.SelectCommand = cmd;

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count == 0)
                            return false;
                        foreach (DataRow dr in dt.Rows)
                        {
                            allowDelete = Convert.ToBoolean(dr["Allowdelete"]);
                        }
                    }
                    return allowDelete;
                }
            }
            catch (Exception)
            {
                return allowDelete;
            }
        }
        public bool UnitCategoriesDeletion(string UnitCategoryID)
        {
            bool allowDelete = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "TMR_USP_CheckUnitCategoryForDelete";
                        cmd.Parameters.AddWithValue("@UnitCategoryID", UnitCategoryID);
                        cmd.Connection = conn;
                        adapter.SelectCommand = cmd;

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count == 0)
                            return false;
                        foreach (DataRow dr in dt.Rows)
                        {
                            allowDelete = Convert.ToBoolean(dr["Allowdelete"]);
                        }
                    }
                    return allowDelete;
                }
            }
            catch (Exception)
            {
                return allowDelete;
            }
        }
    }
}