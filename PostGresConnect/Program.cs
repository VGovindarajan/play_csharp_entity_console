using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Linq.Mapping;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PostGresConnect
{
    public partial class db_Entities : DbContext
    {
        public db_Entities() : base(nameOrConnectionString: "MonkeyFist") { }

        public DbSet<customer> customer { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.HasDefaultSchema("public");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new db_Entities())
            {
                var customers = context.customer.ToList();
                Console.WriteLine("Customers Count : {0}", customers.Count );
                foreach (var cust in customers)
                {
                    Console.WriteLine(cust.id + " " + cust.firstname + " " + cust.address);
                }
                Console.ReadKey();

            }
        }
    }
}
