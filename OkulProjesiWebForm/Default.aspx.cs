using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace OkulProjesiWebForm
{
    public partial class _Default : Page
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