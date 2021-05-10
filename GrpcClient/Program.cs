using Grpc.Net.Client;
using GrpcServer;
using GrpcServer.Protos;
using System;
using System.Threading.Tasks;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //var input = new HelloRequest { Name="Kadir"};
            //var channel = GrpcChannel.ForAddress("https://localhost:5001");
            //var client = new Greeter.GreeterClient(channel);

            //var reply = await client.SayHelloAsync(input);

            //Console.WriteLine(reply.Message);

            //Console.ReadLine();

            Console.ReadLine();

            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var customerClient = new Customer.CustomerClient(channel);

            var clientRequested = new CustomerLookupModel {UserId = 2};
            var customer = await customerClient.GetCustomerInfoAsync(clientRequested);

            Console.WriteLine($"{clientRequested.UserId}'idli arama sonucu dönen müşteri: {customer.FirstName} {customer.LastName}");

            Console.ReadLine();
        }
    }
}
