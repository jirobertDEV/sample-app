using System;
using Microsoft.AspNetCore.Hosting;

namespace ServiceB
{
    public class Program
    {
        // moar comments
        public static void Main(string[] args)
        {
            var port = 80;
            new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .UseUrls("http://*:" + port)
                .Build()
                .Run();
        }
    }
}
