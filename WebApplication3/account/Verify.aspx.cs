using System;
using System.Net;
using System.Net.Mail;
using WebApplication3.Repository;
using WebApplication3.Services;

namespace WebApplication3.account
{
    public partial class Verify : System.Web.UI.Page
    {
        string Code;
        AccountRepository accountRepository;
        public Verify()
        {
            accountRepository = new AccountRepository();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //var value = accountRepository.ValueOfVerifyTable(Id);
            //string code = accountRepository.Code_6_digit();
            //Code = code;
            //SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            //smtp.EnableSsl = true;
            //smtp.UseDefaultCredentials = false;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtp.Credentials = new NetworkCredential("filmmovie741@gmail.com", "f1234554321f");
            //MailMessage mm = new MailMessage("filmmovie741@gmail.com", "");
            //mm.IsBodyHtml = true;
            //mm.Subject = "Please verify your account";
            //mm.Body = string.Format("<h2>Hello:{0}!</h2> <h3>A sign in attempt requires further verification because we did not recognize your account.To complete the sign in, enter the verification code on the unrecognized account.</h3> <h3>Verification code:</h3> {1}", ""person.UserName,code);
            //smtp.Send(mm);
        }

        public void LinkButton1_Click(object sender, EventArgs e)
        {
            
            var value =accountRepository.ValueOfVerifyTable(Id);
            string code = accountRepository.Code_6_digit();
            Code =code;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential("filmmovie741@gmail.com", "f1234554321f");
            MailMessage mm = new MailMessage("filmmovie741@gmail.com", value.Email);
            mm.IsBodyHtml = true;
            mm.Subject = "Please verify your account";
            mm.Body = string.Format("<h2>Hello:{0}!</h2> <h3>A sign in attempt requires further verification because we did not recognize your account.To complete the sign in, enter the verification code on the unrecognized account.</h3> <h3>Verification code:</h3> {1}",value.UserName,code);
            smtp.Send(mm);
        }
        public void btnVerify_Click(object sender, EventArgs e)
        {
            if(Code==txtCode.Value)
            {

                var value = accountRepository.ValueOfVerifyTable(Id);
                accountRepository.InsertToPeopleTable(value.UserName, value.Email, value.Password);
                Response.Redirect("../html%20view/accountVerify.html");
            }
            else
            {
                Response.Write("<script>alert('Code is invalid!!!');</script>");
            }
        }
    }
}