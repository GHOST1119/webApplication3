using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Services;

namespace WebApplication3.account
{
    public partial class fullDataOfProjects : System.Web.UI.Page
    {
        Test1 test1;
        public fullDataOfProjects()
        {
            test1 = new Test1();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                // Adding product to datalist
                if (Request.QueryString["id"] != null)
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    List<Table_Test_1> da = test1.GetPersonByid(id);
                    fullDataDataList.DataSource = da;
                    fullDataDataList.DataBind();
                    lblShowError.Visible = false;
                }
                else
                {
                    btn1.Visible = false;
                    lblShowError.Text = "Your access to this page is unauthorized";
                    Response.Write("<script>alert('Your access to this page is unauthorized')</script>");
                }
            }
            
        }
        protected void fullDataDataList_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Table_Test_1 dataItem = e.Item.DataItem as Table_Test_1;
                Session["ID"] = dataItem.ID;
                // Find the labels inside the DataList item
                Label label1 = e.Item.FindControl("Label1") as Label;
                Label label2 = e.Item.FindControl("Label2") as Label;
                Label label3 = e.Item.FindControl("Label3") as Label;
                // Access the label values or modify their properties
                if (label1 != null)
                {
                    label1.Text = dataItem.Name;
                }
              
                if (label2 != null)
                {
                    label2.Text = dataItem.Age.ToString();
                }
               
                if (label3 != null)
                {
                    label3.Text = dataItem.Gender;
                }
            }
        }
        protected void btnBuy(object sender, EventArgs e)
        {
            string cartPageUrl = "cartPage.aspx?ID=" + Session["ID"];
            btn1.PostBackUrl = cartPageUrl;
        }
    }
}