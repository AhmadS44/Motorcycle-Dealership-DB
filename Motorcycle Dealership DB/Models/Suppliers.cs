 namespace Motorcycle_Dealership_DB.Models
{
    public class Suppliers
    {
        public int SuppliersID { get; set; }
        public int LocationsID { get; set; }
        public int InventoryID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int  Zip { get; set; }


        public Locations Locations { get; set; }

        public Inventory Inventory { get; set; }



    }
}
