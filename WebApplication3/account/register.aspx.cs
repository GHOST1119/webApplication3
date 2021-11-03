﻿using System;
using WebApplication3.Repository;
using WebApplication3.Services;


namespace WebApplication3.account
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        AccountRepository accountRepositiry;
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
                    accountRepositiry.InsertToVerifyTable(txtUserName.Value, txtEmail.Value, txtPassword.Value);
                    int Id = accountRepositiry.GetIdCode(txtEmail.Value);
                    ViewState["Id"] = Id;
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