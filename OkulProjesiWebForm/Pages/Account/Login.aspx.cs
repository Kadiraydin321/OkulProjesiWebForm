using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OkulProjesiWebForm.Pages.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["UserName"] != null && Request.Cookies["Password"] != null)
                {
                    UserNameTextBox.Text = Request.Cookies["UserName"].Value;
                    PasswordTextBox.Attributes["value"] = Request.Cookies["Password"].Value;
                    BeniHatirlaCheck.Checked = true;
                }
            }
          
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            login();
        }
        private void login()
        {
            SqlConnect sql = new SqlConnect();
            using (SqlCommand query = new SqlCommand("select * from Users where UserName='" + UserNameTextBox.Text + "' and Password='" + PasswordTextBox.Text + "'", sql.connection()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    cerezKaydet();
                    Session["UID"] = dt.Rows[0][0].ToString();
                    Session["UserName"] = dt.Rows[0][1].ToString();
                    Response.Redirect("../ToDo/Index.aspx");
                }
                else
                {
                    UyariMesaji.Text = "Kullanıcı adı veya şifre yanlış.";
                }
            }
            sql.disconnection();
        }
        
        private void cerezKaydet()
        {
            if (BeniHatirlaCheck.Checked)
            {
                Response.Cookies["UserName"].Value = UserNameTextBox.Text;
                Response.Cookies["Password"].Value = PasswordTextBox.Text;

                Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(30);
                Response.Cookies["Password"].Expires = DateTime.Now.AddDays(30);
            }
            else
            {
                Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["Password"].Expires = DateTime.Now.AddDays(-1);
            }
        }
    }
}