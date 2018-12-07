using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

/*
 * ==================================================================================================
 * Authors: Jonathan Hao, 
 * Date Modified: Dec. 6, 2018
 * Description: An e-commerce site for musical instruments.
 * Version: 0.0.2 - more folders
 * ==================================================================================================
 */

namespace Troubadour
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
