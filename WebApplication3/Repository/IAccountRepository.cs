using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3.Repository
{
    interface IAccountRepository
    {
        bool Insert(string userName,string email,string password);
    }
}
