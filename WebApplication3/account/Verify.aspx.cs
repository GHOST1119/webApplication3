using System;
using System.Net;
using System.Net.Mail;
using WebApplication3.Repository;
using WebApplication3.Services;

namespace WebApplication3.account
{
    public partial class Verify : System.Web.UI.Page
    {
        IAccountRepository accountRepository;
        public Verify()
        {
            accountRepository = new AccountRepository();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string code = accountRepository.Code_6_digit();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential("filmmovie741@gmail.com", "f1234554321f");
            MailMessage mm = new MailMessage("filmmovie741@gmail.com", "");
            mm.IsBodyHtml = true;
            mm.Subject = "Please verify your account";
            mm.Body = string.Format("<h2>Hello:{0}!</h2> <h3>A sign in attempt requires further verification because we did not recognize your account.To complete the sign in, enter the verification code on the unrecognized account.</h3> <h3>Verification code:</h3> {1}", ""person.UserName,code);
            smtp.Send(mm);
        }
    }
}