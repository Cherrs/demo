using System;
using Orleans.Core;
using Interface;
using Orleans;
using Orleans.Runtime.Configuration;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = ClientConfiguration.LocalhostSilo();
            GrainClient.Initialize(config);
            var player = GrainClient.GrainFactory.GetGrain<IPlayerGrain>(1000);
            player.SayHello("Hi!!!");
            Console.WriteLine("Press any key to terminate!");
            Console.ReadKey();
        }
    }
}
