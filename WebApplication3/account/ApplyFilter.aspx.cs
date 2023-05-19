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
    public partial class ApplyFilter : System.Web.UI.Page
    {
        ITest1 test_Rep;
        public ApplyFilter()
        {
            test_Rep = new Test1();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["addproduct"] = "false";
            List<Table_Test_1> AllProjects = test_Rep.GetAllPerson();
            DataList1.DataSource = AllProjects;
            DataList1.DataBind();

            //using (test1Entities1 context = new test1Entities1())
            //{
            //    var data = from item in context.Table_Test_1
            //               select new
            //               {
            //                   ID = item.ID,
            //                   Name = item.Name,
            //                   Age = item.Age,
            //                   Gender = item.Gender
            //               };
            //    GridView1.DataSource = data.ToList();
            //    GridView1.DataBind();
            //}
        }
        protected void btnFilter(object sender, EventArgs e)
        {
            List<Table_Test_1> filter = test_Rep.Filter(txtUserName.Value);
            //DataList1.DataSource = filter;
            //DataList1.DataBind();
        }

        //protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        //{
        //    Session["addproduct"] = "true";
        //    if (e.CommandName == "AddToCart")
        //    {
        //        DropDownList list = (DropDownList)(e.Item.FindControl("LabelId1"));
        //        Response.Redirect("cartPage.aspx?id=" + e.CommandArgument.ToString());
        //    }
        //    else
        //    {
        //        Response.Write("<script>alert('Duplicate email!!!');</script>");
        //    }
        //}
        //protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        //{
        //    if (e.CommandName == "Edit")
        //    {
        //        // Get the index of the selected row
        //        int index = Convert.ToInt32(e.CommandArgument);

        //        // Get the selected row
        //        GridViewRow row = GridView1.Rows[index];

        //        // Find the ID control in the selected row
        //        Label IDLabel = (Label)row.FindControl("ID");

        //        // Get the value of the ID control
        //        string ID = IDLabel.Text;

        //        // Do something with the ID value (e.g. display it in a label)
        //        //Label1.Text = "The selected ID is: " + ID;
        //    }

        //}

        //protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    GridViewRow row = GridView1.SelectedRow;
        //    Label idLabel = (Label)row.FindControl("ID");
        //    string id = idLabel.Text;
        //    // Do something with the ID value...
        //}
        //protected void lbtnProjects(object sender, EventArgs e)
        //{
        //    HttpCookie cookie = new HttpCookie("ProjectInfo");
        //    //cookie["ProjectName"] = ;
        //    //cookie["ProjectAge"] =;
        //    //cookie["ProjectGender"] =;
        //    Response.Redirect("fullDataOfProjects.aspx");
        //}
    }
}