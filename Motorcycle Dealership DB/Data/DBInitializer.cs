using Motorcycle_Dealership_DB.Models;

namespace Motorcycle_Dealership_DB.Data
{
    public class DBInitializer
    {
        internal static void Initialize(Motorcycle_Dealership_DBContext context)
        {
            context.Database.EnsureCreated();

            //look for customers.
            if (context.Customers.Any())
            {
                return;   // DB has been seeded
            }

            var Customers = new Customers[]
            {
                new Customers {FirstName= "Daniel", LastName="Patel", PhoneNumber=0216372182, Address= "122 Mount Street, Auckland", Email="DanielPatel@gmail.com"},
                new Customers {FirstName= "John", LastName="Doe", PhoneNumber=0246772482, Address= "21 Ford Street, Auckland", Email="Johndoe23@gmail.com"},
                new Customers {FirstName= "Yousif", LastName="Sediqi", PhoneNumber=0256572682, Address= "9 BlockhouseBay Road, Auckland", Email="yousifsediqi1@gmail.com"},
            };
            foreach (Customers c in Customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();


        }
    }
}
