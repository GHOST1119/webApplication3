﻿using System;
using System.Net;
using System.Net.Mail;
using System.Web;
using WebApplication3.Repository;
using WebApplication3.Services;


namespace WebApplication3.account
{
    public partial class Register : System.Web.UI.Page
    {
        AccountRepository accountRepository;
        public Register()
        {
            accountRepository = new AccountRepository();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void btnRegister_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("UserInfo");
            bool isValiEmail = accountRepository.EmailIsValid(txtEmail.Value);
            if (isValiEmail == true)
            {
                bool check = accountRepository.Check(txtEmail.Value);
                if (check == false)
                {
                    cookie["userName"] = txtUserName.Value;
                    cookie["email"] = txtEmail.Value;
                    cookie["password"] = txtPassword.Value;
                    Response.Cookies.Add(cookie);

                    HttpCookie cookie2 = new HttpCookie("generateCode");
                    string code = accountRepository.Code_6_digit();
                    cookie2["code"] = code;
                    Response.Cookies.Add(cookie2);

                    // for test
                    accountRepository.Insert(cookie["userName"], cookie["email"], cookie["password"]);
                    Response.Write("<script>alert('Your account has been Successfully Verify.');</script>");
                    Response.Redirect("Login.aspx");
                    // end for test

                    //RemotePost remotePost = new RemotePost();
                    //remotePost.Url = "https://raygansms.com/AutoSendCode.ashx";
                    //remotePost.Add("Username", "test123");
                    //remotePost.Add("Password", "123456");
                    //remotePost.Add("Mobile", "09116665601");
                    //remotePost.Add("Footer", "RayganSMS");
                    //remotePost.Post();
                    //SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    //smtp.EnableSsl = true;
                    //smtp.UseDefaultCredentials = false;
                    //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    //smtp.Credentials = new NetworkCredential("filmmovie741@gmail.com", "f1234554321f");
                    //MailMessage mm = new MailMessage("filmmovie741@gmail.com", txtEmail.Value);
                    //mm.IsBodyHtml = true;
                    //mm.Subject = "Please verify your account";
                    //mm.Body = string.Format("<h2>Hello: {0}!</h2> <h3>A sign in attempt requires further verification because we did not recognize your account.To complete the sign in, enter the verification code on the unrecognized account.</h3> <h3>Verification code: {1}</h3>", txtUserName.Value, code);
                    //smtp.Send(mm);

                    //Response.Redirect("Verify.aspx");
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