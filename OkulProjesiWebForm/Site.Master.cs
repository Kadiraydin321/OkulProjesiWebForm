﻿using System;
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
            GirisCikis1.Text = "Giriş Yap";
            
            if (Session["UID"] != null) 
            { 
                UserNameLabel.Text = Session["UserName"].ToString().ToUpper();
                GirisCikis1.Text = "Çıkış Yap";
            }
            if (Session["UserName"].ToString() != "admin") 
            {
                AdminPanel.Visible = false;
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