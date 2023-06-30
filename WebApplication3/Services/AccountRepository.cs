using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebApplication3.Repository;

namespace WebApplication3.Services
{
    public class AccountRepository : IAccountRepository
    {
        webapp3M1Entities db = new webapp3M1Entities();
        public bool Check(string email)
        {
            Person email_check = new Person();
            email_check.Email = email;
            bool check = db.People.Any(p => p.Email == email_check.Email);
            return check;
        }

        public string Code_6_digit()
        {
            string num = "0123456789";
            int len = num.Length;
            string otp = string.Empty;
            int otpdigit = 6;
            string finaldigit;
            int getindex;
            for (int i = 0; i < otpdigit; i++)
            {
                do
                {
                    getindex = new Random().Next(0, len);
                    finaldigit = num.ToCharArray()[getindex].ToString();
                } while (otp.IndexOf(finaldigit) != -1);
                otp += finaldigit;

            }
            return otp;
        }

        public Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        public bool EmailIsValid(string emailAddress)
        {
            Regex ValidEmailRegex = CreateValidEmailRegex();
            bool isValid = ValidEmailRegex.IsMatch(emailAddress);
            return isValid;
        }

        public bool Find(string email, string password)
        {
            Person Information_check = new Person();
            Information_check.Email = email;
            Information_check.Password = password;
            bool check = db.People.Any(p => p.Email == Information_check.Email && p.Password == Information_check.Password);
            return check;
        }

        public void Insert(string userName, string email, string password)
        {
            Person p1 = new Person()
            {
                UserName = userName,
                Email = email,
                Password = password
            };
            db.People.Add(p1);
            db.SaveChanges();
            db.Dispose();
        }

        public Person SendPassword(string email)
        {
            Person get = db.People.SingleOrDefault(p => p.Email == email);
            Person get_pass = new Person() { UserName = get.UserName, Email = get.Email, Password = get.Password };
            return get_pass;
        }
    }
}