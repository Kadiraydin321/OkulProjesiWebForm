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
        
        protected void ToDoTable_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DeleteCommand")
            {
                deleteItem(e);
            }
            if (e.CommandName == "EditCommand")
            {
                Response.Redirect("~/Pages/ToDo/EditToDo.aspx?ID=" + e.CommandArgument);
            }
        }
        private void GetData()
        {
            SqlConnect sql = new SqlConnect();
            String sorgu = "Select * From ToDoList Where UserID='" + Session["UID"].ToString() + "' ORDER BY Status DESC, Date ASC";
            using (SqlCommand komut = new SqlCommand(sorgu, sql.connection()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                ToDoTable.DataSource = ds;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ToDoTable.DataBind();
                    NullTable.Visible = false;
                }
                else
                {
                    ToDoTable.DataBind();
                    NullTable.Visible = true;
                }
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
                    Functions.toastrGoster(this.Page, 0, "    To-Do Silindi.");
                }
                else
                {
                    Functions.toastrGoster(this.Page, 2, "    To-Do Silinemedi!");
                }
                sql.disconnection();
            }
        }
        protected void SearchButton_Click(object sender, EventArgs e)
        {
            SqlConnect sql = new SqlConnect();

            String sorgu = "Select * From ToDoList Where " +
                "SubjectTitle Like '%"+SearchTextBox.Text+ "%' and UserID='" + Session["UID"].ToString() + "'" +
                "or SubjectText Like '%" + SearchTextBox.Text + "%' and UserID='" + Session["UID"].ToString() + "'" +
                "or Status Like '%" + SearchTextBox.Text + "%' and UserID='" + Session["UID"].ToString() + "'" +
                " ORDER BY Status DESC, Date ASC";

            using (SqlCommand komut = new SqlCommand(sorgu, sql.connection()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                ToDoTable.DataSource = ds;
                if (ds.Tables[0].Rows.Count >0)
                {
                    ToDoTable.DataBind();
                    nullRow.Visible = false;
                }
                else
                {
                    ToDoTable.DataBind();
                    nullRow.Visible=true;
                }
                
            }
            sql.disconnection();
            
        }
    }
}