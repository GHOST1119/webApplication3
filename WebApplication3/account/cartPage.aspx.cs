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
    public partial class cartPage : System.Web.UI.Page
    {
        Test1 test1;
        public cartPage()
        {
            test1 = new Test1();
        }
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
                        int id = Convert.ToInt32(Request.QueryString["id"]);
                        Product da = test1.GetPersonById(id);                        
                        dr["ID"] = da.id;
                        dr["Name"] = da.Name;
                        dr["Age"] = da.Age;
                        dr["Gender"] = da.Gender;
                        
                        dt.Rows.Add(dr);
                        Gridview1.DataSource = dt;
                        Gridview1.DataBind();
                        Session["buyitems"] = dt;
                        Button1.Enabled=true;

                        Response.Redirect("cartPage.aspx");
                    }
                    else
                    {
                        dt = (DataTable)Session["buyitems"];
                        int sr;
                        sr = dt.Rows.Count;

                        dr = dt.NewRow();
                        int id = Convert.ToInt32(Request.QueryString["id"]);
                        Product da = test1.GetPersonById(id);
                        dr["ID"] = da.id;
                        dr["Name"] = da.Name;
                        dr["Age"] = da.Age;
                        dr["Gender"] = da.Gender;

                        dt.Rows.Add(dr);
                        Gridview1.DataSource = dt;
                        Gridview1.DataBind();
                        Session["buyitems"] = dt;
                        Button1.Enabled = true;

                        Response.Redirect("cartPage.aspx");
                    }
                }
                else
                {
                    dt = (DataTable)Session["buyItems"];
                    Gridview1.DataSource = dt;
                    Gridview1.DataBind();
                }
            }
            string OrderDate = DateTime.Now.ToString();
            Session["Orderdate"] = OrderDate;
        }
        // Calculating Final Price
        public int GrandTotal()
        {
            DataTable dt = new DataTable();
            dt = (DataTable)Session["buyitems"];
            int nrow = dt.Rows.Count;
            int i = 0;
            int totalprice = 0;
            while (i < nrow)
            {
                totalprice = totalprice + Convert.ToInt32(dt.Rows[i]["pprice"].ToString());
                i++;
            }
            return totalprice;
        }
        // Generating Unque Order Id
        public void OrderId()
        {
            string alpha = "abcdefghijklmnopqrstuvwxyz123456789";
            Random r = new Random();
            char[] myArray = new char[5];
            for(int i = 0; i < 5; i++)
            {
                myArray[i] = alpha[(int)(35 * r.NextDouble())];
            }
            string orderid;
            orderid = "Order_Id" + DateTime.Now.Hour.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Day.ToString()
                + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + new string(myArray) + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            Session["Orderid"] = orderid;
        }

        protected void Gridview1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)Session["buyitems"];

            for( int i = 0; i <= dt.Rows.Count - 1; i++ )
            {
                int sr;
                int sr1;
                string qdata;
                string dtdata;
                sr = Convert.ToInt32(dt.Rows[i]["sno"].ToString());
                TableCell cell = Gridview1.Rows[e.RowIndex].Cells[0];
                qdata = cell.Text;
                dtdata = sr.ToString();
                sr1 = Convert.ToInt32(qdata);

                if(sr == sr1)
                {
                    dt.Rows[i].Delete();
                    dt.AcceptChanges();
                    //Item has been deleted from cart
                    break;
                }
            }

            // setting SNo after deleting Row item from cart
            for( int i = 1; i <= dt.Rows.Count; i++ )
            {
                dt.Rows[i - 1]["sno"] = i;
                dt.AcceptChanges();
            }
            Session["buyitems"] = dt;
            Response.Redirect("cartPage.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt;
            dt = (DataTable)Session["buyitems"];
            for(int i = 0; i <= dt.Rows.Count - 1; i++ )
            {
                string setorderid = Convert.ToString(Session["Orderid"]);
                string setsno = Convert.ToString(dt.Rows[i]["sno"]);
                string setname = Convert.ToString(dt.Rows[i]["Name"]);
                string setage = Convert.ToString(dt.Rows[i]["Age"]);
                string setgender = Convert.ToString(dt.Rows[i]["Gender"]);
                string setorderdate = Convert.ToString(Session["Orderdate"]);
                test1.InsertProduct(setorderid, Convert.ToInt32(setsno), setname, setage, setgender, setorderdate);
            }
            // if session is Null redirecting to login else placing the order
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                if(Gridview1.Rows.Count.ToString() == "0")
                {
                    Response.Write("<script>alert('Your cart is Emty!!!You cannot place an order.');</script>");
                }
                else
                {
                    Response.Redirect("PlaceOrder.aspx");
                }
            }
        }
    }
}