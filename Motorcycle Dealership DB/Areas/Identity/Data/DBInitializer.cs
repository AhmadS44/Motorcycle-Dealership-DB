using Motorcycle_Dealership_DB.Models;

namespace Motorcycle_Dealership_DB.Areas.Identity.Data
{
    public class DBInitializer
    {
        internal static void Initialize(Motorcycle_Dealership_DBContext context)
        {
            context.Database.EnsureCreated();

            //look for customers.
            //        if (context.Customer.Any())
            //        {
            //            return;   // DB has been seeded
            //        }

            //        var customers = new Customer[]
            //        {
            //            new Customer {FirstName= "Daniel", LastName="Patel", PhoneNumber=0216372182, Address= "122 Mount Street, Auckland", Email="DanielPatel@gmail.com"},
            //            new Customer {FirstName= "John", LastName="Doe", PhoneNumber=0246772482, Address= "21 Ford Street, Auckland", Email="Johndoe23@gmail.com"},
            //            new Customer {FirstName= "Yousif", LastName="Sediqi", PhoneNumber=0256572682, Address= "9 BlockhouseBay Road, Auckland", Email="yousifsediqi1@gmail.com"},
            //        };
            //        foreach (Customer c in customers)

            //        {
            //           // context.Customer.Add(c);
            //        }
            //        context.SaveChanges();
            //    }
            //}
        }
    }
}