using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OkulProjesiWebForm.Pages.Account
{
    public partial class NewPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UID"] == null || Session["UserName"] == null)
            {
                Response.Redirect("~/Pages/Account/Login.aspx");
            }
        }

        protected void NewPasswordButton_Click(object sender, EventArgs e)
        {
            if (Session["Password"].ToString() == Functions.MD5Sifrele(OldPasswordTextBox.Text))
            {
                if (NewPasswordTextBox.Text == ReNewPasswordTextBox.Text)
                {
                    if (Session["Password"].ToString() != Functions.MD5Sifrele(ReNewPasswordTextBox.Text))
                    {
                        sifreGuncelle();
                    }
                    else
                    {
                        Functions.toastrGoster(this.Page, 1, "   Yeni şifreniz, eski şifrenizle aynı olamaz.");
                    }
                }
                else
                {
                    Functions.toastrGoster(this.Page, 1, "   Yeni şifreniz birbiriyle uyuşmuyor.");
                }
            }
            else
            { 
                Functions.toastrGoster(this.Page, 2, "   Eski şifrenizi yanlış girdiniz.");
            }
        }
        
        private void sifreGuncelle()
        {
            SqlConnect sql = new SqlConnect();
            String query = "UPDATE Users SET Password='" + Functions.MD5Sifrele(ReNewPasswordTextBox.Text) + "' WHERE UID='" + Session["UID"].ToString() + "'";

            using (SqlCommand command = new SqlCommand(query, sql.connection()))
            {
                command.ExecuteNonQuery();
                sql.disconnection();
                Session["Password"] = Functions.MD5Sifrele(ReNewPasswordTextBox.Text);
                if (!IsPostBack)
                {
                    if (Request.Cookies["Password"] != null)
                    {
                        Response.Cookies["Password"].Value = ReNewPasswordTextBox.Text;
                    }
                }
            }
            Response.Redirect("~/Pages/Account/Profile");
        }
    }
}