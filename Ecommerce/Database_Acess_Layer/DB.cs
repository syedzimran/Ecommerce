using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Ecommerce.Database_Acess_Layer
{

    public class DB
    {
        string con = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
        string query = string.Empty;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        // Get MainCategory
        public DataTable GetParentCategory()
        {
            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                da = new SqlDataAdapter("SP_ParentCategory", sqlcon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
