using System;
using System.Web.UI;
using WebApplication3.Repository;
using WebApplication3.Services;

namespace WebApplication3.account
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        IAccountRepository accountRepositiry;
        public WebForm1()
        {
            accountRepositiry = new AccountRepository();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void btnRegister_Click(object sender, EventArgs e)
        {
            bool check = accountRepositiry.Check(txtEmail.Value);
            if (check == false)
            {
                accountRepositiry.Insert(txtUserName.Value, txtEmail.Value, txtPassword.Value);
                Response.Redirect("Login.aspx");
            }
            else
            {
                MessageBox("ایمیل تکراری است");
                return;
            }
        }
        public void MessageBox(string Message)
        {
            Page.ClientScript.RegisterStartupScript(
               Page.GetType(),
               "MessageBox",
               "<script language='javascript'>alert('" + Message + "');</script>"
            );
        }

    }
}