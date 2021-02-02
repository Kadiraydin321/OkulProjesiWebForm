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
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UID"] == null || Session["UserName"] == null)
            {
                Response.Redirect("~/Pages/Account/Login.aspx");
            }
            if (!IsPostBack)
            {
                profilCek();
            }
           
        }
        protected void ProfileUpdateButton_Click(object sender, EventArgs e)
        {
            profilGuncelle();
        }
        private void profilCek()
        {
            UserNameTextBox.Text = Session["UserName"].ToString();
            NameTextBox.Text = Session["Name"].ToString();
            SurnameTextBox.Text = Session["Surname"].ToString();
            EmailTextBox.Text = Session["Email"].ToString();
        }

        private void profilGuncelle()
        {
            try
            {
                SqlConnect sql = new SqlConnect();
                String query = "UPDATE Users SET " +
                    "UserName='" + UserNameTextBox.Text + "'," +
                    "Name='" + NameTextBox.Text + "'," +
                    "Surname='" + SurnameTextBox.Text + "'," +
                    "Email='" + EmailTextBox.Text + "'" +
                    " WHERE UID='" + Session["UID"].ToString() + "' AND Password='" + Functions.MD5Sifrele(PasswordTextBox.Text) + "'";

                if (Session["Password"].ToString() == Functions.MD5Sifrele(PasswordTextBox.Text))
                {
                    using (SqlCommand command = new SqlCommand(query, sql.connection()))
                    {
                        command.ExecuteNonQuery();
                        sql.disconnection();

                        // Bilgiler ile beraber Sessionlar da güncelleniyor.
                        Session["UserName"] = UserNameTextBox.Text;
                        Session["Name"] = NameTextBox.Text;
                        Session["Surname"] = SurnameTextBox.Text;
                        Session["Email"] = EmailTextBox.Text;
                    }
                    Functions.toastrGoster(this.Page, 0, "    Başarılı bir şekilde güncellendi.");
                }
                else
                {
                    Functions.toastrGoster(this.Page, 2, "    Hatalı şifre girdiniz.");
                }
            }
            catch (SqlException)
            {
                Functions.toastrGoster(this.Page, 1, "Bu kullanıcı adı veya e posta ile önceden kayıt yapılmış.");
            }
        }

        protected void SifreDegistir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/Account/NewPassword.aspx");
        }
    }
}