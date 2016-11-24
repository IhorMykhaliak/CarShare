using System.Collections.Generic;

namespace CarShare.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual IEnumerable<Vehicle> Vehicles { get; set; }
        public virtual Location Location { get; set; }

        //TODO: Role
    }
}
