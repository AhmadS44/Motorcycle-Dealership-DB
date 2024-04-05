﻿namespace Motorcycle_Dealership_DB.Models
{
    public class Locations
    {
        public int LocationsID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int Zip { get; set; }
        public int ContactNumber { get; set; }


        public ICollection<Suppliers> Suppliers { get; set; }

    }
}
