using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Repository;
using WebApplication3.Services;

namespace WebApplication3.account
{
    public partial class AllProjects : System.Web.UI.Page
    {
        ITest1 test_Rep;
        public AllProjects()
        {
            test_Rep = new Test1();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Table_Test_1> AllProjects = test_Rep.GetAllPerson();
            DataList2.DataSource = AllProjects;
            DataList2.DataBind();
        }
        protected void DataList2_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Button myButton1 = e.Item.FindControl("myButton1") as Button;
                if (myButton1 != null)
                {
                    string commandArgument = myButton1.CommandArgument;
                    string cartPageUrl = "fullDataOfProjects.aspx?ID=" + commandArgument;
                    myButton1.PostBackUrl = cartPageUrl;
                }
            }
        }
        protected void btnFilter(object sender, EventArgs e)
        {
            List<Table_Test_1> filter = test_Rep.Filter(txtUser.Text,txtAge.Text,txtGender.Text);
            DataList2.DataSource = filter;
            DataList2.DataBind();
        }
    }
}