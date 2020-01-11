using Autofac;
using Autofac.Configuration;
using Autofac.Core;
using Microsoft.Extensions.Configuration;
using SaasProductsImport.Sites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaasProductsImport
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                       .SetBasePath(Settings.ConfigPath)
                       .AddJsonFile("Autofac.json")
                       .AddJsonFile("AppSettings.json")
                       .Build();

            var module = new ConfigurationModule(configuration);
            var builder = new ContainerBuilder();
            builder.RegisterModule(module);
            var container = builder.Build();
            var inputString = Console.ReadLine();


            var companyName = ParseInput(inputString);

            var site = container.ResolveKeyed<ISite>(companyName.ToLower());
          

        }

        private static string ParseInput(string inputString)
        {
            return "capterra";
        }
    }
}
