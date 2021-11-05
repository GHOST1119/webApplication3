using System;
using System.Net;
using System.Net.Mail;
using System.Web;
using WebApplication3.Services;

namespace WebApplication3.account
{
    public partial class Verify : System.Web.UI.Page
    {
        AccountRepository accountRepository;
        public Verify()
        {
            accountRepository = new AccountRepository();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void LinkButton1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];
            HttpCookie cookie2 = new HttpCookie("generateCode2");
            string code = accountRepository.Code_6_digit();
            cookie2["code"] = code;
            Response.Cookies.Add(cookie2);
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential("filmmovie741@gmail.com", "f1234554321f");
            MailMessage mm = new MailMessage("filmmovie741@gmail.com", cookie["email"]);
            mm.IsBodyHtml = true;
            mm.Subject = "Please verify your account";
            mm.Body = string.Format("<h2>Hello: {0}!</h2> <h3>A sign in attempt requires further verification because we did not recognize your account.To complete the sign in, enter the verification code on the unrecognized account.</h3> <h3>Verification code: {1}</h3>", cookie["userName"], code);
            smtp.Send(mm);
        }
        public void btnVerify_Click(object sender, EventArgs e)
        {
            HttpCookie cookieGetCode = Request.Cookies["generateCode"];
            HttpCookie cookieGetCode2 = Request.Cookies["generateCode2"];
            if (cookieGetCode["code"] == txtCode.Value || cookieGetCode2["code"] ==txtCode.Value)
            {
                HttpCookie cookie = Request.Cookies["UserInfo"];
                accountRepository.Insert(cookie["userName"], cookie["email"], cookie["password"]);
                Response.Redirect("../html%20view/accountVerify.html");
            }
            else
            {
                Response.Write("<script>alert('Code is invalid!!!');</script>");
            }
        }
    }
}