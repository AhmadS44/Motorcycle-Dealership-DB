namespace Motorcycle_Dealership_DB.Models
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public string Model { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }





        public Motorcycle motorcycle { get; set; }
        public Supplier supplier { get; set; }


    }
}
