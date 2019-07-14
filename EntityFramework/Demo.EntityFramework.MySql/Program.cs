using Demo.EntityFramework.MySql.Models;
using Demos.SharedCode.ConfigHandling;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.EntityFramework.MySql {
    class Program {
        internal static IConfigService<MySqlCredentials> mysqlConfig;

        static async Task Main(string[] args) {
            mysqlConfig = new MySqlConfigService("connection.suo");
            mysqlConfig.ReadSettingsFile();
            var dbContext = new NorthwindContext();
            var customers = await dbContext.Customers.ToListAsync();
            foreach (var customer in customers) {
                Console.WriteLine($"{customer.FirstName} {customer.LastName}: {customer.Company}");
            }
        }
    }
}
