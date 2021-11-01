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
    public partial class WebForm2 : System.Web.UI.Page
    {
        IAccountRepository accountRepositiry;
        public WebForm2()
        {
            accountRepositiry = new AccountRepository();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool check = accountRepositiry.EmailIsValid(txtEmail.Value);
            if(check==true)
            {
                bool find = accountRepositiry.Find(txtEmail.Value, txtPassword.Value);
                if (find == true)
                {
                    Response.Redirect("");
                }
                else
                {
                    Response.Write("<script>alert('Username or email is incorrect!!!');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Email is not valid!!!');</script>");
            }
        }
    }
}