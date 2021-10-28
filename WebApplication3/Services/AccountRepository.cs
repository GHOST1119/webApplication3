using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Repository;

namespace WebApplication3.Services
{
    public class AccountRepository : IAccountRepository
    {
        public bool Insert(string userName, string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}