﻿using System;
using System.Threading.Tasks;
using CreditRatingService;

using Grpc.Net.Client;

namespace CreditRatingClient
{
    class Program
    {
       static async Task Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client =  new CreditRatingCheck.CreditRatingCheckClient(channel);
            var creditRequest = new CreditRequest { CustomerId = "id0201", Credit = 17000};
            var reply = await client.CheckCreditRequestAsync(creditRequest);

            Console.WriteLine($"Credit for customer {creditRequest.CustomerId} {(reply.IsAccepted ? "approved" : "rejected")}!");

            var client2 = new CreditRatingService.Greeter.GreeterClient(channel);
            var helloRequest = new HelloRequest { Name = "Jhon" };
            var replyHello = await client2.SayHelloAsync(helloRequest);

             Console.WriteLine($"GRPC Hello  {replyHello.Message}!");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
