using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Module4HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("config.json");
            var config = builder.Build();
            var connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder.UseSqlServer(connectionString).Options;
            using (var db = new ApplicationContext(options))
            {
                db.SaveChanges();
            }

            Console.ReadKey();
        }
    }
}
