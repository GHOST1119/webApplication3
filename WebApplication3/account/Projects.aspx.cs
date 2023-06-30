using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Repository;
using WebApplication3.Services;
using System.IO;

namespace WebApplication3.account
{
    public partial class Projects : System.Web.UI.Page
    {
        ITest1 test_Rep;
        public Projects()
        {
            test_Rep = new Test1();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["addproduct"] = "false";

            if (!IsPostBack)
            {
                List<Table_Test_1> dt = test_Rep.GetAllPerson();
                repeaterNames.DataSource = dt;
                repeaterNames.DataBind();
            }
        }

        protected void Lbtn_Click1(object sender, EventArgs e)
        {
            Response.Redirect("PlaceOrder.aspx");
        }
    }
}
