using System;
using Orleans;
using Orleans.Runtime.Configuration;
using Orleans.Runtime.Host;
using Orleans.Hosting;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = ClusterConfiguration.LocalhostPrimarySilo();
            var siloHost = new SiloHost("Orleans", config);
            siloHost.InitializeOrleansSilo();
            siloHost.StartOrleansSilo(true);
            Console.WriteLine("Press any key to terminate!");
            Console.ReadKey();
        }
    }
}
