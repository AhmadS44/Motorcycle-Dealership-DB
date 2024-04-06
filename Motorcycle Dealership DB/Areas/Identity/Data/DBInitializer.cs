using Motorcycle_Dealership_DB.Models;

namespace Motorcycle_Dealership_DB.Areas.Identity.Data
{
    public class DBInitializer
    {
        internal static void Initialize(Motorcycle_Dealership_DBContext context)
        {
            context.Database.EnsureCreated();

            //look for customers.
                    if (context.Customer.Any())
                    {
                        return;   // DB has been seeded
                    }

                    var customers = new Customer[]
                    {
                        new Customer {FirstName= "Daniel", LastName="Patel", PhoneNumber=0216372182, Address= "122 Mount Street, Auckland", Email="DanielPatel@gmail.com"},
                        new Customer {FirstName= "John", LastName="Doe", PhoneNumber=0246772482, Address= "21 Ford Street, Auckland", Email="Johndoe23@gmail.com"},
                        new Customer {FirstName= "Yousif", LastName="Sediqi", PhoneNumber=0256572682, Address= "9 BlockhouseBay Road, Auckland", Email="yousifsediqi1@gmail.com"},
                    };
                    foreach (Customer c in customers)

                    {
                        context.Customer.Add(c);
                    }
                    context.SaveChanges();



            var Suppliers = new Suppliers[]
            {
                new Suppliers {LocationsID= 1,InventoryID=1, FirstName="Carl", LastName= "Joseph", PhoneNumber=0217283813, Email="carJ1@gmail.com", City="Auckland", Address="172 Blockhousebay Road", Zip=1029},
                        new Suppliers {LocationsID= 2,InventoryID=2, FirstName="Lawindi", LastName= "Patel", PhoneNumber=0218463896,Email="Lawindipatel@gmail.com", City="Auckland", Address="21 Christ Street", Zip=1821},
                        new Suppliers {LocationsID= 3,InventoryID=3, FirstName="John", LastName= "Prasad", PhoneNumber=021783346, Email="johnp21@gmail.com", City="Christchurch", Address="12 Moony Road", Zip=2172},
            };

            foreach (Suppliers s in Suppliers)

            {
                context.Suppliers.Add(s);
            }
            context.SaveChanges();

            var inventory = new Inventory[]
            {
                      
                        new Inventory {MotorcyclesID= 1, Model="Toyota", PhoneNumber=0259175682, Email= "inventorystorage1@gmail.com", Function="Storage"},
                        new Inventory {MotorcyclesID= 2, Model="Honda", PhoneNumber=0249182682, Email= "sellinginventory1@gmail.com", Function="Selling"},
                        new Inventory {MotorcyclesID= 3, Model="Nissan", PhoneNumber=0259172682, Email= "sellinginventory2@gmail.com", Function="Selling"},
            };
            foreach (Inventory i in inventory)

            {
                context.Inventory.Add(i);
            }
            context.SaveChanges();



            var locations = new Locations[]
            {

                        new Locations {Country="New Zealand", City= "Auckland", Address= "92 Woolworth Street", Zip=4212, PhoneNumber=0226378182},
                        new Locations {Country="New Zealand", City= "Auckland", Address= "18 Ash Street", Zip=2142, PhoneNumber=0216318269},
                        new Locations {Country="New Zealand", City= "Wellington", Address= "17 Avondale Road", Zip=1090, PhoneNumber=0216378169},
            };
            foreach (Locations l in locations)

            {
                context.Locations.Add(l);
            }
            context.SaveChanges();


            var motorcycles = new Motorcycles[]
            {

                        new Motorcycles {Model="Toyota", Year= 1999, Weight= "160Kg", Colour="Silver"},
                        new Motorcycles {Model="Honda", Year= 2010, Weight= "180Kg", Colour="Black",},
                        new Motorcycles {Model="Nissan", Year= 2001, Weight= "200Kg", Colour="Black"},
            };
            foreach (Motorcycles m in motorcycles)

            {
                context.Motorcycles.Add(m);
            }
            context.SaveChanges();


            var PurchaseOrder = new PurchaseOrder[]
            {

                        new PurchaseOrder {CustomerID= 1, PurchaseDate=DateTime.Parse("2002-07-02"), Model= "Toyota", Zip= 8182, PhoneNumber=0217283813},
                        new PurchaseOrder {CustomerID= 2, PurchaseDate=DateTime.Parse("2001-10-04"), Model= "Honda", Zip= 1921, PhoneNumber=0218463896,},
                        new PurchaseOrder {CustomerID= 3, PurchaseDate=DateTime.Parse("2003-09-02"), Model= "Nissan", Zip= 7182, PhoneNumber=021783346},
            };
            foreach (PurchaseOrder p in PurchaseOrder)

            {
                context.PurchaseOrder.Add(p);
            }
            context.SaveChanges();


          



        }
    }
}