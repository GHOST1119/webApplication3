using System.Linq;
using System.Text.RegularExpressions;
using WebApplication3.Repository;

namespace WebApplication3.Services
{
    public class AccountRepository : IAccountRepository
    {
        public bool Check(string email)
        {
            using (accountEntities db = new accountEntities())
            {
                Person email_check = new Person();
                email_check.Email = email;
                bool check = db.People.Any(p => p.Email == email_check.Email);
                return check;
            }
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
            using (accountEntities db = new accountEntities())
            {
                Person Information_check = new Person();
                Information_check.Email = email;
                Information_check.Password = password;
                bool check = db.People.Any(p=>p.Email==Information_check.Email && p.Password ==Information_check.Password);
                return check;
            }
        }

        public void Insert(string userName, string email, string password)
        {
            accountEntities db = new accountEntities();

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
    }
}