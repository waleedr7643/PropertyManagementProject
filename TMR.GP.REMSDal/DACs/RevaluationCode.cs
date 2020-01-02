using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TMR.GP.REMSDal
{
    public partial class DataAccess
    {
        public bool AddUnitRevaluation(clsUnitRevaluation info, ref int id)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddUnitRevaluation"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@ProjectID", info.strProject);
                            cmd.Parameters.AddWithValue("@BlockID", info.strBlock);
                            cmd.Parameters.AddWithValue("@RevalueDate", info.dateRevaluationDate);
                            cmd.Parameters.AddWithValue("@Revaluationid", info.id);
                            cmd.Parameters.AddWithValue("@ApprovalStatusCode", info.ApprovalStatusCode);
                            cmd.Parameters.AddWithValue("@ApprovalActionUser", info.ApprovalActionUser);
                            cmd.Parameters.AddWithValue("@ApprovalActionDate", info.ApprovalActionDate);
                            cmd.Parameters.AddWithValue("@CreatedBy", info.CreatedBy);
                            cmd.Parameters.AddWithValue("@CreationDate", info.CreationDate);
                            cmd.Parameters.AddWithValue("@LastUpdateUser", info.LastUpdateUser);
                            cmd.Parameters.AddWithValue("@LastUpdateDate", info.LastUpdateDate);
                            SqlParameter parm = new SqlParameter();
                            parm.ParameterName = "@Outid";
                            parm.SqlDbType = SqlDbType.Int;
                            parm.Direction = ParameterDirection.Output;
                            //parm.Value = info.id;

                            cmd.Parameters.Add(parm);

                            st = cmd.ExecuteNonQuery();

                            id = (int)parm.Value;
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
        public bool AddUnitRevaluationItem(clsUnitRevaluationListItem info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddUnitRevaluationList"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;                            
                            cmd.Parameters.AddWithValue("@id", info.id);
                            cmd.Parameters.AddWithValue("@SizeCode", info.SizeCode);
                            cmd.Parameters.AddWithValue("@BlockID", info.BlockID);
                            cmd.Parameters.AddWithValue("@NewPrice", info.NewPrice);
                            cmd.Parameters.AddWithValue("@OldPrice", info.OldPrice);
                            cmd.Parameters.AddWithValue("@Revaluationid", info.Revaluationid);
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
        public clsUnitRevaluation GetUnitRevaluationById(int id)
        {
            clsUnitRevaluation info = new clsUnitRevaluation();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetUnitRevaluationByID"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {

                        info.strProject = reader["ProjectID"].ToString();
                        info.strBlock = reader["BlockID"].ToString();
                        info.dateRevaluationDate = Convert.ToDateTime(reader["RevalueDate"]);
                        info.ApprovalStatusCode = Convert.ToInt32(reader["ApprovalStatusCode"].ToString());
                        info.ApprovalStatusDescription = reader["ApprovalStatusDescription"].ToString();
                        info.ApprovalActionUser = reader["ApprovalActionUser"].ToString();
                        info.ApprovalActionDate = Convert.ToDateTime(reader["ApprovalActionDate"].ToString());
                        info.CreatedBy = reader["CreatedBy"].ToString();
                        info.CreationDate = Convert.ToDateTime(reader["CreationDate"].ToString());
                        info.LastUpdateUser = reader["LastUpdateUser"].ToString();
                        info.LastUpdateDate = Convert.ToDateTime(reader["LastUpdateDate"].ToString());

                        info.id = Convert.ToInt32(reader["id"]);

                    }
                    conn.Close();
                }
            }
            return info;
        }
        public List<clsUnitRevaluationListItem> GetUnitRevaluationListItemsById(int id)
        {
            List<clsUnitRevaluationListItem> lst = new List<clsUnitRevaluationListItem>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetUnitRevaluationListByRevalutionID"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@Revaluationid", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        lst.Add(
                            new clsUnitRevaluationListItem()
                            {
                                SizeCode = reader["SizeCode"].ToString(),
                                BlockID = reader["BlockID"].ToString(),
                                NewPrice = Convert.ToDecimal(reader["NewPrice"]),
                                OldPrice = Convert.ToDecimal(reader["OldPrice"]),
                                id = Convert.ToInt32(reader["id"])
                            });


                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public List<clsUnitRevaluation> GetRevaluationList()
        {
            List<clsUnitRevaluation> lst = new List<clsUnitRevaluation>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetReavluationList"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var info = new clsUnitRevaluation();

                        info.strProject = reader["ProjectID"].ToString();
                        info.strBlock = reader["BlockID"].ToString();
                        info.dateRevaluationDate = Convert.ToDateTime(reader["RevalueDate"]);
                        info.ApprovalStatusDescription = reader["ApprovalStatusDescription"].ToString();
                        info.id = Convert.ToInt32(reader["id"].ToString());

                        lst.Add(info);

                    }
                    conn.Close();
                }
            }
            return lst;
        }
        public bool AddSizeCodePriceList(clsSizeCodePriceList info)
        {
            int st = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    {
                        using (SqlCommand cmd = new SqlCommand("TMR_USP_AddSizeCodePriceList"))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@ProjectID", info.strProjectID);
                            cmd.Parameters.AddWithValue("@BlockID", info.strBlockID);
                            cmd.Parameters.AddWithValue("@SizeCode", info.strSizeCode);
                            cmd.Parameters.AddWithValue("@Price", info.dPrice);
                            cmd.Parameters.AddWithValue("@Fk_RevaluationID", info.Fk_RevaluationID);
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
        public clsSizeCodePriceList GetSizeCodePriceList(clsSizeCodePriceList Sinfo)
        {
            
            clsSizeCodePriceList lst = new clsSizeCodePriceList();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_GetSizeCodePriceList"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@ProjectID", Sinfo.strProjectID);
                    cmd.Parameters.AddWithValue("@BlockID", Sinfo.strBlockID);
                    cmd.Parameters.AddWithValue("@SizeCode", Sinfo.strSizeCode);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        
                        if (lst.dPrice != null)
                        {
                            lst.dPrice = Convert.ToDecimal(reader["Price"].ToString());
                        }
                        else if (lst.dPrice == null || lst.dPrice == 0)
                        {
                            lst.dPrice = Convert.ToDecimal("0.00");
                        }
                        

                    }
                    conn.Close();
                }
            }
            return lst;

        }
        public clsSizeCodePriceList GetPriceBySizeCode(string sizecode)
        {
            clsSizeCodePriceList info = new clsSizeCodePriceList();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("TMR_USP_PriceBySizeCode"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@SizeCode", sizecode);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {

                        info.dPrice = Convert.ToDecimal(reader["Price"]);
                        

                    }
                    conn.Close();
                }
            }
            return info;
        }
        //public bool UpdateUnitPriceonRevaluation(clsUnitRevaluation info)
        //{
        //    int st = 0;
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(strConn))
        //        {
        //            conn.Open();

        //            {
        //                using (SqlCommand cmd = new SqlCommand("TMR_USP_UpdateUnitPrice"))
        //                {

        //                    cmd.CommandType = CommandType.StoredProcedure;
        //                    cmd.Connection = conn;
        //                    cmd.Parameters.AddWithValue("@ProjectID", info.strProject);
        //                    cmd.Parameters.AddWithValue("@BlockID", info.strBlock);
        //                    cmd.Parameters.AddWithValue("@SizeCode", info.strSizeCode);
        //                    cmd.Parameters.AddWithValue("@UnitType", info.strUnitType);
        //                    cmd.Parameters.AddWithValue("@Price", info.decPrice);

        //                    st = cmd.ExecuteNonQuery();
        //                }
        //            }
        //            conn.Close();
        //        }
        //    }
        //    catch (Exception ex) { }
        //    if (st > 0)
        //        return true;
        //    else
        //        return false;
        //}



        //TMR_USP_GetReavluationList
    }

}