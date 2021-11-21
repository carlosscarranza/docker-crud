
using CrudmySQL;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Net;

namespace BlogDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
    }
}


    //using CrudmySQL;
    //using Microsoft.AspNetCore;
    //using Microsoft.AspNetCore.Hosting;
    //using Microsoft.Extensions.Hosting;
    //using System;
    //using System.Net;

//namespace BlogDemo
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            CreateWebHostBuilder(args).Build().Run();
//        }
//        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
//           WebHost.CreateDefaultBuilder(args)
//               .ConfigureWebHostDefaults(webBuilder =>
//               {
//                   webBuilder.ConfigureKestrel(serverOptions =>
//                   {
//                       serverOptions.Listen(IPAddress.Any, Convert.ToInt32(Environment.GetEnvironmentVariable("PORT")));
//                   }).UseStartup<Startup>();
//               });
//    }
//}