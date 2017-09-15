using System;
using System.Threading.Tasks;
using Orleans;
using Interface;

namespace GrainEx
{
    public class PlayerGrain :Grain,IPlayerGrain
    {
        public Task SayHello(string content)
        {
            Console.WriteLine($"Say {content} to {this.GetPrimaryKeyLong()}");
            return Task.CompletedTask;
        }
    }
}
