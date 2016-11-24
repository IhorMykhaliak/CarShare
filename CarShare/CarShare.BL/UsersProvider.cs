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
    }
}
