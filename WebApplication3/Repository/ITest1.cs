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
        List<Product> GetAllPerson();
        Product GetPersonById(int personId);
        List<Product> GetPersonByid(int personId);
        bool InsertPerson(Product person);
        bool UpdatePerson(Product person);
        bool DeletePerson(Product person);
        bool DeletePerson(int personId);
        void Save();
        List<Product> Filter(string name, string age, string gender);
        void InsertProduct(string orderid,int sno,string name,string age,string gender,string orderdate);
        void UpdatePersonById(int id,string img);
    }
}
