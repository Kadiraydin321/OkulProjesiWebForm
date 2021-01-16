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
            if (Session["UID"] == null)
            {
                Response.Redirect("~/Pages/Account/Login.aspx");
            }
            profilCek();
        }
        protected void ProfileUpdateButton_Click(object sender, EventArgs e)
        {
            profilGuncelle();
        }
        private void profilCek()
        {
            SqlConnect sql = new SqlConnect();
            using (SqlCommand query = new SqlCommand("Select * from Users where UID='"+Session["UID"]+"'", sql.connection()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    UserNameTextBox.Text = dt.Rows[0][1].ToString();
                    NameTextBox.Text = dt.Rows[0][2].ToString();
                    SurnameTextBox.Text = dt.Rows[0][3].ToString();
                    EmailTextBox.Text = dt.Rows[0][4].ToString();
                }
                else
                {
                    Response.Redirect("~/Pages/Account/Login.aspx");
                }
            }
            sql.disconnection();
        }

        private void profilGuncelle()
        {
            SqlConnect sql = new SqlConnect();
            String query = "UPDATE Users SET " +
                "UserName='" + UserNameTextBox.Text + "'," +
                "Name='" + NameTextBox.Text + "'," +
                "Surname='" + SurnameTextBox.Text + "'," +
                "Email='" + EmailTextBox.Text + "'" +
                " WHERE UID='" + Session["UID"].ToString() + "'";


            //AND Password='"+ PasswordTextBox.Text + "'
            // update Users set UserName='deneme' where UID='"+Session["UID"].ToString()+ "' and Password='" + PasswordTextBox.Text + "'

            using (SqlCommand command = new SqlCommand(query, sql.connection()))
            {
                command.ExecuteNonQuery();
            }
            sql.disconnection();
        }

        
    }
}