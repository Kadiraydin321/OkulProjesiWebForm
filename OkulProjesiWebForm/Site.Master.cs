using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace OkulProjesiWebForm
{
    public partial class SiteMaster : MasterPage
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            GirisCikis.Text = "Giriş yap";
            if (Session["UID"] != null) 
            { 
                UserNameLabel.Text = Session["UserName"].ToString().ToUpper();
                GirisCikis.Text = "Çıkış yap";
            }
            
        }
        protected void GirisCikis_Click(object sender, EventArgs e)
        {
            if (Session["UID"] == null && Session["UserName"] == null)
            {
                giris();
            }
            else
            {
                cikis();
            }
            
        }

        private void giris()
        {
            Response.Redirect("~/Pages/Account/Login.aspx");
        }

        private void cikis()
        {
            Session["UID"] = null;
            Session["UserName"] = null;
            Response.Redirect("~/Pages/Account/Login.aspx");
        }
    }
}