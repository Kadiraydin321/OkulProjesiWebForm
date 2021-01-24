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
                DataTable dt = GetData();
                StringBuilder html = new StringBuilder();

                html.Append("<table id='UserTable' class='table table-dark table-hover'>");
                html.Append("<thead>");
                html.Append("<tr role='row'>");
                html.Append("<th>#</th>");
                foreach (DataColumn column in dt.Columns)
                {
                    if (column.ColumnName == "Password")
                    {
                        continue;
                    }
                    html.Append("<th>");
                    html.Append(column.ColumnName);
                    html.Append("</th>");
                }
                html.Append("</tr>");
                html.Append("</thead>");
                html.Append("<tbody>");

                int artis = 1;
                foreach (DataRow row in dt.Rows)
                {
                    html.Append("<tr role='row'>");
                    html.Append("<td>" + artis.ToString() + "</td>");
                    foreach (DataColumn column in dt.Columns)
                    {
                        if (column.ColumnName == "Password")
                        {
                            continue;
                        }
                        html.Append("<td>");
                        html.Append(row[column.ColumnName]);
                        html.Append("</td>");
                    }
                    html.Append("</tr>");
                    artis++;
                }
                html.Append("</tbody>");
                html.Append("</table>");

                placeholder.Controls.Add(new Literal { Text = html.ToString() });
            }
        }
        private DataTable GetData()
        {
            SqlConnect sql = new SqlConnect();
            using (SqlCommand query = new SqlCommand("select * from Users", sql.connection()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            sql.disconnection();
        }
    }
}