using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebApplication3.Repository
{
    interface IAccountRepository
    {
        void Insert(string userName,string email,string password);
        bool Check(string email);
        Regex CreateValidEmailRegex();
        bool EmailIsValid(string emailAddress);
        bool Find(string email,string password);        
    }
}
