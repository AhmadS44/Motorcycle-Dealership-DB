namespace Motorcycle_Dealership_DB.Models
{
    public class PurchaseOrder
    {
        public int OrderID { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Model { get; set; }
        public int Zip { get; set; }
        public int PhoneNumber { get; set; }

      
        public Customers customers { get; set; }
    }
}
