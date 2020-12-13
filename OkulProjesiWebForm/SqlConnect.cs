using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace OkulProjesiWebForm
{
    public class SqlConnect
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=ToDoList; integrated security=true;");
            connect.Open();
            return connect;
        }
    }
}