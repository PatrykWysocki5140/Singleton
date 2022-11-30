using Singleton.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] a)
        {         
            var server = LoadServer.GetLoadServer();
            

            Console.WriteLine("All servers\n\n\n" );
            var servList = server.AllServers.ToList();
            foreach(var obj in servList)
            {
                Console.WriteLine($"Server: {obj.Name}");
                Console.WriteLine($"                       IP: {obj.IP}");
                Console.WriteLine("----------------------------------------");
            }


            Console.WriteLine("\n\n\n##############################################\n\n\n" );


            Console.WriteLine("Random servers\n\n\n" );
            for (int i = 0; i < 15; i++)
            {
                Server serv = server.RandomServer;

                Console.WriteLine($"Server: {serv.Name}" );
                Console.WriteLine($"                       IP: {serv.IP}" );
                Console.WriteLine("----------------------------------------" );
            }
            
            Console.WriteLine("\n\n\n##############################################\n\n\n" );
            Console.ReadKey();
        }
    }
}
