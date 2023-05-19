using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using WebApplication3.Repository;

namespace WebApplication3.Services
{
    public class Test1 : ITest1
    {
        test1Entities1 db = new test1Entities1();
        public List<Table_Test_1> GetAllPerson()
        {
            return db.Table_Test_1.ToList();
        }

        public Table_Test_1 GetPersonById(int personId)
        {
            return db.Table_Test_1.Find(personId);
        }

        public bool InsertPerson(Table_Test_1 person)
        {
            try
            {
                db.Table_Test_1.Add(person);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool UpdatePerson(Table_Test_1 person)
        {
            try
            {
                db.Entry(person).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeletePerson(Table_Test_1 person)
        {
            try
            {
                db.Entry(person).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeletePerson(int personId)
        {
            try
            {
                var person = GetPersonById(personId);
                DeletePerson(person);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public List<Table_Test_1> Filter(string name)
        {
            string aa = "";
            List<Table_Test_1> filterperson = db.Table_Test_1.Where(p => (string.IsNullOrEmpty(name) || p.Name == name) && (string.IsNullOrEmpty(aa) || p.Age == aa)).ToList();
            return filterperson;
            
        }
    }
}