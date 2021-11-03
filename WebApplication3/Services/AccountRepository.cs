using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebApplication3.Repository;

namespace WebApplication3.Services
{
    public class AccountRepository : IAccountRepository
    {
        public bool Check(string email)
        {
            using (accountEntities1 db = new accountEntities1())
            {
                Person email_check = new Person();
                email_check.Email = email;
                bool check = db.People.Any(p => p.Email == email_check.Email);
                return check;
            }
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
            using (accountEntities1 db = new accountEntities1())
            {
                Person Information_check = new Person();
                Information_check.Email = email;
                Information_check.Password = password;
                bool check = db.People.Any(p => p.Email == Information_check.Email && p.Password == Information_check.Password);
                return check;
            }
        }

        public async Task InsertToPeopleTable(string userName, string email, string password)
        {
            await new Task(() =>
            {
                accountEntities1 db = new accountEntities1();

                Person p1 = new Person()
                {
                    UserName = userName,
                    Email = email,
                    Password = password
                };
                db.People.Add(p1);
                db.SaveChanges();
                db.Dispose();
            });
        }

        public Person SendPassword(string email)
        {
            accountEntities1 db = new accountEntities1();
            Person get = db.People.SingleOrDefault(p => p.Email == email);
            Person get_pass = new Person() { UserName = get.UserName, Email = get.Email, Password = get.Password };
            return get_pass;
        }
        public async Task InsertToVerifyTable(string userName, string email, string password)
        {
            await new Task(() =>
            {
                accountEntities1 db = new accountEntities1();

                Verify p1 = new Verify()
                {
                    UserName = userName,
                    Email = email,
                    Password = password
                };
                db.Verifies.Add(p1);
                db.SaveChanges();
                db.Dispose();
            });
        }
        public int GetIdCode(string email)
        {
            accountEntities1 db = new accountEntities1();
            var Id = db.Verifies.Where(s => s.Email == email).Select(s=>s.id);
            int id = Convert.ToInt32(Id);
            return id;
        }
        public Verify ValueOfVerifyTable(int Id)
        {
            Verify person = new Verify();
            accountEntities1 db = new accountEntities1();
            Verify value = db.Verifies.SingleOrDefault(v => v.id == Id);
            Verify get_value = new Verify() { UserName = value.UserName, Email = value.Email, Password = value.Password };
            return get_value;
        }
    }
}