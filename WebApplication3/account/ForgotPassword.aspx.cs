using System;
using System.Net;
using System.Net.Mail;
using WebApplication3.Repository;
using WebApplication3.Services;

namespace WebApplication3.account
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        public System.Security.SecureString SecurePassword { get; set; }
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
                    Person person = new Person();
                    person = accountRepository.SendPassword(txtEmail.Value);
                    string email = person.Email;
                    string pass = person.Password;
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential("filmmovie741@gmail.com","f1234554321f");
                    MailMessage mm = new MailMessage("filmmovie741@gmail.com", txtEmail.Value);
                    mm.IsBodyHtml = true;
                    mm.Subject = "Your Password !";
                    mm.Body = string.Format("<h1>Hello:</h1> <h2>{0}</h2> <br/> <h3>YOUR PASSWORD IS:</h3> {1}", person.UserName, person.Password);                    
                    smtp.Send(mm);
                    Response.Redirect("../html%20view/forgotPassword.html");
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