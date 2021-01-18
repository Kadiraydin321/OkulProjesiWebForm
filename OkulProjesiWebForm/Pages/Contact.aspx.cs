using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OkulProjesiWebForm.Pages
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Session["UID"] != null)
            {
                this.MasterPageFile = "~/Site.Master";
            }
            else if (Session["UID"] == null)
            {

                this.MasterPageFile = "~/NoUser.Master";
            }
        }
    }
}