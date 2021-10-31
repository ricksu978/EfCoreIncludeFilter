using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EfCoreIncludeFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new MyDbContextFactory().CreateDbContext(args);

            try
            {
                dbContext.Database.Migrate();
            }
            catch(SqlException)
            {
                Console.WriteLine("Error: Please setup proper Connection String in appsettings.json");
                Console.ReadLine();
                return;
            }

            var query = dbContext.Categories
                // Key Point: Include with Filtering
                .Include(c => c.Records.OrderByDescending(r => r.LastUpdate).Take(1))
                .Where(c => c.Id == 1 || c.Id == 2 || c.Id == 3)
                ;

            foreach(var category in query)
            {
                var record = category.Records.FirstOrDefault();

                Console.WriteLine($"Category #{category.Id}:\n\tRecord #{record.Id}, Last Update = {record.LastUpdate.ToString("yyyy/MM/dd")}");
            }

            Console.WriteLine();

            Console.WriteLine(query.ToQueryString());

            Console.ReadLine();
        }
    }
}
