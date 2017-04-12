using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace DirServeSharp.CommandLine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string staticFileDirectory;
            if (args.Length > 0)
            {
                staticFileDirectory = args[0];
            }
            else
            {
                Console.WriteLine("Enter the directory to serve:");
                staticFileDirectory = Console.ReadLine();
            }
            if (!Directory.Exists(staticFileDirectory))
            {
                Console.WriteLine($"'{staticFileDirectory}' does not exist");
                Environment.Exit(1);
            }
            IWebHost host = new WebHostBuilder()
                .UseUrls("http://*:8080")
                .UseContentRoot(staticFileDirectory)
                .UseWebRoot(staticFileDirectory)
                .Configure(appbuilder => appbuilder.UseFileServer(true).Build())
                .UseKestrel()
                .Build();
            host.Run();
        }
    }
}