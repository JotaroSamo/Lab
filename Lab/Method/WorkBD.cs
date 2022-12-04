using LAB2.DB;
using LAB2.DB.DBCONTEXT;
using LAB2.Page;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace LAB2.Method
{
    internal class WorkBD
    {
        public string Get()
        {
            using (UserContext db=new UserContext())
            {
                string ret=JsonSerializer.Serialize(db.Users);
                return ret;
            }
        }
        public void GetDelId(Edit edit,int id)
        {
            using (UserContext db = new UserContext())
            {
                User del = db.Users.Where(c => c.Id == id).First();
                db.Users.Remove(del);
                db.SaveChanges();
                edit.Refresh();
           }
        }
        public string ISearch(string item)
        {
            using (UserContext db = new UserContext())
            {
                string ret = JsonSerializer.Serialize(db.Users.Where(c => c.UserName == item));
                return ret;
            }
        }
        public string ISearch(int id)
        {
            using (UserContext db = new UserContext())
            {
                string ret = JsonSerializer.Serialize(db.Users.Where(c => c.Id == id));
                return ret;
            }
        }
        public void Save(User user,bool a)
        {
            using (UserContext db = new UserContext())
            {
                if (a==true)
                {
                    db.Users.Add(user);
                   
                }
                else
                {
                   
                    db.Entry(user).State = EntityState.Modified;
                }
                db.SaveChanges();


            }
        }
       
    }
}
