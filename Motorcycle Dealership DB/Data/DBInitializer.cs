namespace Motorcycle_Dealership_DB.Data
{
    public class DBInitializer
    {
        internal static void Initialize(Motorcycle_Dealership_DBContext context)
        {
            context.Database.EnsureCreated();

            //finding customers
            if (context.Customer)
        }
    }
}
