using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using WebApplication3.Repository;
using WebApplication3.Services;

namespace WebApplication3.account
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        IAccountRepository accountRepository;
        public ForgotPassword()
        {
            accountRepository = new AccountRepository();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRecovery_Click(object sender, EventArgs e)
        {
            bool check = accountRepository.EmailIsValid(txtEmail.Value);
            if (check == true)
            {
                bool check2 = accountRepository.Check(txtEmail.Value);
                if (check2 == true)
                {
                    //Person person = new Person();
                    //person = accountRepository.SendPassword(txtEmail.Value);
                    //string address = person.Email;
                    //string password = person.Password;
                    //SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    //client.UseDefaultCredentials = false;
                    //client.Credentials = new System.Net.NetworkCredential("filmmovie741@gmail.com", "f1234554321f");
                    //client.EnableSsl = true;
                    //client.DeliveryMethod = SmtpDeliveryMethod.Network;

                    //MailMessage mailMessage = new MailMessage();
                    //mailMessage.From = new MailAddress(address);
                    //mailMessage.To.Add("filmmovie741@gmail.com");
                    //mailMessage.Body = "test";
                    //mailMessage.Subject = "subject";
                    //client.Send(mailMessage);
                    Person person = new Person();
                    person = accountRepository.SendPassword(txtEmail.Value);
                    string email = person.Email;
                    string pass = person.Password;
                    MailMessage mm = new MailMessage("filmmovie741@gmail.com", txtEmail.Value);
                    mm.Subject = "Your Password !";
                    mm.Body = string.Format("Hello: < h1 >{0}</ h1 > < br /> your password is : < h1 >{1}</ h1 >", person.UserName, person.Password);
                    mm.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient("smtp.@gmail.com", 587);
                    //smtp.Host = "filmmovie741@gmail.com";
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    NetworkCredential nc = new NetworkCredential();
                    nc.UserName = "filmmovie741@gmail.com";
                    nc.Password = "f1234554321f";
                    smtp.Credentials = nc;
                    smtp.Send(mm);
                    //smtp.Port = 587;
                    Response.Write("<script>alert('اطلاعات با موفقیت ارسال شد.');</script>");
                    ////Response.Redirect("../html%20view/forgotPassword.html");
                }
                else
                {
                    Response.Write("<script>alert('An account has not been created with this email!!!');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Email is not valid!!!');</script>");
            }
        }
    }
}