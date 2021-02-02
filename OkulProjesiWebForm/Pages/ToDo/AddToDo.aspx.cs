using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OkulProjesiWebForm.Pages.ToDo
{
    public partial class AddToDo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UID"] == null || Session["UserName"] == null)
            {
                Response.Redirect("~/Pages/Account/Login.aspx");
            }
        }

        protected void AddToDoButton_Click(object sender, EventArgs e)
        {
            ToDoEkleme();
        }

        private void ToDoEkleme(){
            String UID = Functions.MD5Sifrele(Functions.uretici());

            SqlConnect sql = new SqlConnect();
            String query = "insert into ToDoList(UserID,SubjectTitle,SubjectText,Date,Status)" +
                "Values('"+Session["UID"].ToString()+"', '"+SubjectTitleTextBox.Text+ "','" + SubjectTextBox.Text + "','" + DateTextBox.Text + "','YAPILMADI')";

            using (SqlCommand command = new SqlCommand(query, sql.connection()))
            {
               try
               {
                    command.ExecuteNonQuery();
                    Functions.toastrGoster(this.Page, 0, "Başarılı bir şekilde kayıt edildi.");
               }
               catch (SqlException)
               {
                    Functions.toastrGoster(this.Page, 2, "Bir hata oluştu ve kayıt edilemedi.");
               }

            }
            sql.disconnection();
        }
    }
}