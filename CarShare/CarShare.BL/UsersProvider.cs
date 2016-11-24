using CarShare.DAL;
using CarShare.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CarShare.BL
{
    public class UsersProvider
    {
        public List<User> GetAllUsers()
        {
            using (var db = new CarShareDBContext())
            {
                return db.Users.ToList();
            }
        }

        public void AddUser(User user)
        {
            using (var db = new CarShareDBContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
        public void AddDefaultUser()
        {
            using (var db = new CarShareDBContext())
            {
                var us = new User();
                us.FirstName = "Vasia";
                us.LastName = "Surname";
                
                db.Users.Add(us);
                db.SaveChanges();
            }
        }


        public string Gesdfsd()
        {
            using (var db = new CarShareDBContext())
            {
                return "some return value";
            }
        }


    }
}
