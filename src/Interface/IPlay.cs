using System;
using System.Threading.Tasks;
using Orleans;

namespace Interface
{
    public interface IPlayerGrain : IGrainWithIntegerKey
    {
        Task SayHello(string content);
    }
}
