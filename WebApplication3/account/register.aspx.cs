using System;
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
            bool isValiEmail = accountRepositiry.EmailIsValid(txtEmail.Value);
            if (isValiEmail == true)
            {
                bool check = accountRepositiry.Check(txtEmail.Value);
                if (check == false)
                {
                    AccountRepository Repository_Insert = new AccountRepository();
                    Repository_Insert.InsertToVerifyTable(txtUserName.Value, txtEmail.Value, txtPassword.Value);
                    
                    Response.Redirect("Verify.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Duplicate email!!!');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Email is not valid!!!');</script>");
            }
        }
    }
}