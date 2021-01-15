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
                    Response.Redirect("./Login.aspx");
                }
            }
            sql.disconnection();
        }

    }
}