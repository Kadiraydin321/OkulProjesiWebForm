using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace OkulProjesiWebForm
{
    public partial class _Default : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            SqlConnect sql = new SqlConnect();
            using (SqlCommand query = new SqlCommand("select * from Users where UserName='"+UserNameTextBox.Text+"' and Password='"+PasswordTextBox.Text+"'", sql.connection()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count !=0)
                {
                    Session["UserName"] = UserNameTextBox.Text;
                    Response.Redirect("Pages/ToDo/Index.aspx");
                }
                else
                {
                    UyariMesaji.Text = "Kullanıcı adı veya şifre yanlış.";
                }
            }
            sql.disconnection();
        }
    }
}