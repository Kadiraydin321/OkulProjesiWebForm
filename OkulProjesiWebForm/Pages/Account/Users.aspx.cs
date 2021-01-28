using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OkulProjesiWebForm.Pages.Account
{
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UID"] == null || Session["UserName"] == null)
            {
                Response.Redirect("~/Pages/Account/Login.aspx");
            }
            else if (Session["UserName"].ToString()!="admin")
            {
                Response.Redirect("~/Pages/ToDo/Index");
            }

            if (!IsPostBack)
            {
                GetData();
            }
        }
        private void GetData()
        {
            SqlConnect sql = new SqlConnect();
            String sorgu = "select * from Users Order By Name";
            using (SqlCommand komut = new SqlCommand(sorgu, sql.connection()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                UserTable.DataSource = ds;
                UserTable.DataBind();
            }
            sql.disconnection();
        }
        protected void UserTable_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DeleteCommand")
            {
                SqlConnect sql = new SqlConnect();
                String sorgu = "Delete From Users Where UID='" + e.CommandArgument + "'";
                using (SqlCommand komut = new SqlCommand(sorgu, sql.connection()))
                {
                    if (komut.ExecuteNonQuery() > 0)
                    {
                        GetData();
                    }
                    else
                    {
                        Functions.toastrGoster(this.Page, 2, "    Kullanıcı Silinemedi!");
                    }
                    sql.disconnection();
                }
            }
        }
    }
}