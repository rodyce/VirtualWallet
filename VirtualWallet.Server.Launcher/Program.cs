using System;
using Grpc.Core;
using VirtualWallet.Proto.Grpc;
using VirtualWallet.Server.Grpc;

namespace VirtualWallet.Server.Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Port = 50052;

            Console.WriteLine("Starting VirtualWallet server!");

            var server = new global::Grpc.Core.Server
            {
                // TODO: Bind all service implementations here.
                Services = {LegalPersonService.BindService(new LegalPersonServiceImpl())},
                Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure )}
            };
            server.Start();

            Console.WriteLine("VirtualWallet Server listening at port " + Port);
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }
}
