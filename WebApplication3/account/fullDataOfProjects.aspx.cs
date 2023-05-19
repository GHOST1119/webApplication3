using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3.account
{
    public partial class fullDataOfProjects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnBuy(object sender, EventArgs e)
        {
            Response.Redirect("cartPage.aspx");
        }
    }
}