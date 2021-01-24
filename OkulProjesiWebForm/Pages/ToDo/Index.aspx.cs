using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OkulProjesiWebForm.Pages.ToDo
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UID"] == null || Session["UserName"] == null)
            {
                Response.Redirect("~/Pages/Account/Login.aspx");
            }
            ViewTable();
        }

        private void ViewTable()
        {
            if (!IsPostBack)
            {
                DataTable dt = GetData();
                StringBuilder html = new StringBuilder();

                html.Append("<table id='UserTable' class='table table-dark table-hover'>");
                html.Append("<thead>");
                html.Append("<tr role='row'>");
                html.Append("<th>#</th>");
                html.Append("<th>Konu Başlığı</th>");
                html.Append("<th>Konu Metni</th>");
                html.Append("<th>Tarih</th>");
                html.Append("<th>Durum</th>");
                html.Append("<th></th>");
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
                        if (column.ColumnName == "ID" || column.ColumnName == "UserID")
                        {
                            continue;
                        }
                        else if (column.ColumnName == "Date")
                        {
                            html.Append("<td>");
                            html.Append(row[column.ColumnName].ToString().Substring(0, 10));
                            html.Append("</td>");
                        }
                        else if (column.ColumnName == "SubjectTitle")
                        {
                            html.Append("<td>");
                            if (row[column.ColumnName].ToString().Length < 40)
                            {
                                html.Append(row[column.ColumnName]);
                            }
                            else
                            {
                                html.Append(row[column.ColumnName].ToString().Substring(0, 37) + "...");
                            }
                            html.Append("</td>");
                        }
                        else if (column.ColumnName == "SubjectText")
                        {
                            html.Append("<td>");
                            if (row[column.ColumnName].ToString().Length < 50)
                            {
                                html.Append(row[column.ColumnName]);
                            }
                            else
                            {
                                html.Append(row[column.ColumnName].ToString().Substring(0, 47) + "...");
                            }
                            html.Append("</td>");
                        }
                        else
                        {
                            html.Append("<td>");
                            html.Append(row[column.ColumnName]);
                            html.Append("</td>");
                        }
                    }
                    html.Append("<td></td>");
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
            using (SqlCommand query = new SqlCommand("Select * From ToDoList Where UserID='"+Session["UID"].ToString()+"' ORDER BY Date ASC", sql.connection()))
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