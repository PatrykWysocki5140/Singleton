using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Model
{
        public sealed class LoadServer
    {

        private static readonly LoadServer instance = new LoadServer();
        private readonly List<Server> servers= new List<Server> ();
        private readonly Server defaut = new Server { Name = "example server name", IP = "1.1.1.1" };
        private readonly Random random = new Random();

        public int Count;
        private LoadServer()
        {
            
            for(int i = 0; i < 100; i++)
            {
                if (i==0 ) { servers.Add(defaut); }

                servers.Add(new Server { Name = i.ToString(), IP = $"{random.Next(224)}.{random.Next(224)}.{random.Next(224)}.{random.Next(224)}" });
            }
        }
        public static LoadServer GetLoadServer()
        {
            return instance;
        }

        
        public Server RandomServer
        {
            get
            {
                int r = random.Next(servers.Count);
                if (r==0)
                {
                    return defaut;
                }
                else
                {
                    return servers[r];
                }
            }
        }

        public List<Server> AllServers
        {
            get { return servers; }
        }

    }
}
