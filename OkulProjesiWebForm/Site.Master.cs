using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace OkulProjesiWebForm
{
    public partial class SiteMaster : MasterPage
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}


/*  Sql Bağlatısı ve Veri çekme örneği
            SqlConnect conn = new SqlConnect();
            using (SqlCommand query = new SqlCommand("select * from test", conn.connection()))
            {
                using (SqlDataReader read = query.ExecuteReader())
                {
                    while (read.Read())
                    {
                        label1.Text += read["soyad"].ToString();
                    }
                    conn.connection().Close();
                }
            }*/