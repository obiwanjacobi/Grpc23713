using Grpc.Net.Client;
using GrpcService1;
using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                              new HelloRequest { Name = "GreeterClient" });

            Console.WriteLine(reply.Message);
        }
    }
}
