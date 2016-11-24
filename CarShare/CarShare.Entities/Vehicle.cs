namespace CarShare.Entities
{
    public enum CarType
    {
        Sedan = 0,
        Estate = 1,
        Coupe = 2,
        Hatchback = 3,
        SUV = 4,
        Van = 5
    }

    public class Vehicle
    {
        public int Id { get; set; }
        
        public string Make { get; set; }

        public string Model { get; set; }
        public int YearOfProduction { get; set; }
        public CarType Type { get; set; }
        public virtual PricePolicy Price { get; set; }
        public virtual User Owner { get; set; } 
        public virtual Location Location { get; set; }
    }
}
