using System.Linq;
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