namespace Motorcycle_Dealership_DB.Models
{
    public class Motorcycles
    {
        public int MotorcyclesID { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Weight { get; set; }
        public string Colour { get; set; }


        public ICollection<Inventory> Inventory { get; set; }


    }
}
