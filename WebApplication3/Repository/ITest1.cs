using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3.Repository
{
    public interface ITest1
    {
        List<Table_Test_1> GetAllPerson();
        Table_Test_1 GetPersonById(int personId);
        bool InsertPerson(Table_Test_1 person);
        bool UpdatePerson(Table_Test_1 person);
        bool DeletePerson(Table_Test_1 person);
        bool DeletePerson(int personId);
        void Save();
        List<Table_Test_1> Filter(string name);
    }
}
