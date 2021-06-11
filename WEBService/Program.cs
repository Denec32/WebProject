using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBService.Models;

namespace WEBService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (WebServiceDBContext db = new WebServiceDBContext())
            {
                Organization org1 = new Organization { Name = "TestName1", Address = "Test Address" };
                Organization org2 = new Organization { Name = "TestName2", Address = "Test Address" };

                db.Organizations.Add(org1);
                db.SaveChanges();
            }

            using (WebServiceDBContext db = new WebServiceDBContext())
            {
                var organizations = db.Organizations.ToList();
                Console.WriteLine("Orgs list");
                Console.WriteLine($"{organizations.Count()}");
                foreach (var item in organizations)
                {
                    Console.WriteLine($"{item.Name}, {item.Address}");
                }
            }

            Console.WriteLine("test");
            //CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
