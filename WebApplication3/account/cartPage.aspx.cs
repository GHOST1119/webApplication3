using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3.account
{
    public partial class cartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Session["buyItems"] == null)
                {
                    Button1.Enabled = false;
                }
                else
                {
                    Button1.Enabled = true;
                }

                // Adding product to gridview
                Session["addproduct"] = "false";
                DataTable dt = new DataTable();
                DataRow dr;
                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Age");
                dt.Columns.Add("Gender");

                if (Request.QueryString["id"] != null)
                {
                    if (Session["BuyItems"] == null)
                    {
                        dr = dt.NewRow();
                        accountEntities1 db = new accountEntities1();
                        dr["id"] = db.People;
                        dr["Name"] = db;
                        dr["Age"] = db;
                        dr["Gender"] = db;
                        
                        dt.Rows.Add(dr);
                        Gridview1.DataSource = dt;
                        Gridview1.DataBind();
                        Session["buyitem"] = dt;
                        Button1.Enabled=true;

                        Response.Redirect("cartPage.aspx");
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            else
            {

            }
        }
    }
}