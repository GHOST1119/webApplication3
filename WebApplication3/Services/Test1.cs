using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using WebApplication3.Repository;
using System.Data;

namespace WebApplication3.Services
{
    public class Test1 : ITest1
    {
        webapp3M1Entities1 db = new webapp3M1Entities1();
        public List<Product> GetAllPerson()
        {
            return db.Products.ToList();
        }

        public Product GetPersonById(int personId)
        {
            return db.Products.Find(personId);
        }
        public List<Product> GetPersonByid(int personId)
        {
            return db.Products.Where(p => p.id == personId).ToList();
        }

        public bool InsertPerson(Product person)
        {
            try
            {
                db.Products.Add(person);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool UpdatePerson(Product person)
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

        public bool DeletePerson(Product person)
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

        public List<Product> Filter(string name,string age,string gender)
        {
            List<Product> filterperson = db.Products.Where(p => (string.IsNullOrEmpty(name) || p.Name == name) && (string.IsNullOrEmpty(age) || p.Age == age) && (string.IsNullOrEmpty(gender) || p.Gender == gender)).ToList();
            return filterperson;
            
        }

        public void InsertProduct(string orderid, int sno, string name, string age, string gender, string orderdate)
        {
            OrderDetail product = new OrderDetail()
            {
                OrderId = orderid,
                Sno = sno,
                Name = name,
                Age = age,
                Gender = gender,
                OrderDate = orderdate
            };
            db.OrderDetails.Add(product);
            db.SaveChanges();
            db.Dispose();
        }

        public void UpdatePersonById(int id, string img)
        {
            Product person = db.Products.FirstOrDefault(p => p.id == id);
            if (person != null)
            {
                person.Img = img;
                db.SaveChanges();
            }
        }

        public void InsertNewWallet(string username)
        {
            Person person = GetPersonByUserName(username);
            Wallet wallet = new Wallet()
            {
                PersonId = person.id,
                UserName = person.UserName,
                Email = person.Email,
                PersonMoney = 0
            };
            db.Wallets.Add(wallet);
            db.SaveChanges();
        }

        public Person GetPersonByUserName(string username)
        {
            return db.People.Find(username);
        }
    }
}