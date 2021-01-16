using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OkulProjesiWebForm
{
    public partial class NoUser : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GirisCikis.Text = "Giriş Yap";

            if (Session["UID"] != null)
            {
                GirisCikis.Text = "Çıkış Yap";
            }
            string path = HttpContext.Current.Request.Url.AbsolutePath;
            if (path == "/Pages/Account/Login" || path == "/Pages/Account/Register")
            {
                GirisCikis.Visible = false;
            }
        }
        protected void GirisCikis_Click(object sender, EventArgs e)
        {
            if (Session["UID"] == null && Session["UserName"] == null)
            {
                Response.Redirect("~/Pages/Account/Login.aspx");
            }
            else
            {
                Session["UID"] = null;
                Session["UserName"] = null;
                Response.Redirect("~/Pages/Account/Login.aspx");
            }
        }
    }
}