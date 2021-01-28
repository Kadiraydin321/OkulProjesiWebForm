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
            if (!IsPostBack)
            {
                GetData();
            }
        }
        
        protected void UserTable_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DeleteCommand")
            {
                deleteItem(e);
            }
            if (e.CommandName == "EditCommand")
            {
                Response.Redirect("~/Pages/ToDo/EditToDo.aspx?ID=" + e.CommandArgument);
            }
            if (e.CommandName == "ViewCommand")
            {
                Response.Redirect("~/Pages/ToDo/ViewToDo.aspx?ID=" + e.CommandArgument);
            }
        }
        private void GetData()
        {
            SqlConnect sql = new SqlConnect();
            String sorgu = "Select * From ToDoList Where UserID='" + Session["UID"].ToString() + "' ORDER BY Date DESC";
            using (SqlCommand komut = new SqlCommand(sorgu, sql.connection()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                UserTable.DataSource = ds;
                UserTable.DataBind();
            }
            sql.disconnection();
        }

        private void deleteItem(GridViewCommandEventArgs e)
        {
            SqlConnect sql = new SqlConnect();
            String sorgu = "Delete From ToDoList Where ID='" + e.CommandArgument + "'";
            using (SqlCommand komut = new SqlCommand(sorgu, sql.connection()))
            {
                if (komut.ExecuteNonQuery() > 0)
                {
                    GetData();
                }
                else
                {
                    Functions.toastrGoster(this.Page, 2, "    To-Do Silinemedi!");
                }
                sql.disconnection();
            }
        }
    }
}