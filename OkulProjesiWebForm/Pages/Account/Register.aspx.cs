using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace OkulProjesiWebForm.Pages.Account
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            register();
        }
        private void register()
        {
            String UID = Functions.MD5Sifrele(Functions.uretici()).Substring(0, 15).ToUpper();

            SqlConnect sql = new SqlConnect();
            String query = "insert into Users(UID,UserName,Name,Surname,Email,Password)" +
                "Values(" +
                "'" + UID + "'," +
                "'" + UserNameTextBox.Text + "'," +
                "'" + NameTextBox.Text + "'," +
                "'" + SurnameTextBox.Text + "'," +
                "'" + EmailTextBox.Text + "'," +
                "'" + PasswordTextBox.Text + "')";
             
            using (SqlCommand command = new SqlCommand(query, sql.connection()))
            {
                try 
                { 
                    command.ExecuteNonQuery();
                    UyariMesaji.CssClass = "text-success";
                    UyariMesaji.Text = "Başarılı bir şekilde kayıt edildi.";
                }
                catch (SqlException)
                {
                    UyariMesaji.CssClass = "text-danger";
                    UyariMesaji.Text = "Bu kullanıcı adı veya e posta ile önceden kayıt yapılmış.";
                }
              
            }
            sql.disconnection();
            
        }
    }
}