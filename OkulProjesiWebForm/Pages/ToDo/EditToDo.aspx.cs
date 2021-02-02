using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OkulProjesiWebForm.Pages.ToDo
{
    public partial class EditToDO : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UID"] == null || Session["UserName"] == null)
            {
                Response.Redirect("~/Pages/Account/Login.aspx");
            }
            if (!IsPostBack)
            {
                getData();
            }
            
        }
        private void getData()
        {
            SqlConnect sql = new SqlConnect();
            using (SqlCommand query = new SqlCommand("select * from ToDoList Where ID = " + Request.QueryString["ID"], sql.connection()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                SubjectTitleTextBox.Text = dt.Rows[0][2].ToString();
                SubjectTextBox.Text = dt.Rows[0][3].ToString();
                DateTextBox.Text = dt.Rows[0][4].ToString();

                Status.SelectedValue = dt.Rows[0][5].ToString();
            }
            sql.disconnection();
        }
        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnect sql = new SqlConnect();
                String query = "UPDATE ToDoList SET " +
                    "SubjectTitle='" + SubjectTitleTextBox.Text + "'," +
                    "SubjectText='" + SubjectTextBox.Text + "'," +
                    "Date='" + DateTextBox.Text + "'," +
                    "Status='" + Status.SelectedValue + "'" +
                    " WHERE  ID=" + Request.QueryString["ID"];
                using (SqlCommand command = new SqlCommand(query, sql.connection()))
                {
                    command.ExecuteNonQuery();
                    sql.disconnection();
                }
                Functions.toastrGoster(this.Page, 0, "    Başarılı bir şekilde güncellendi.");
            }
            catch (SqlException)
            {
                Functions.toastrGoster(this.Page, 2, "    Bir hata oluştu. Güncelleme başarısız.");
            }
        }
    }
}