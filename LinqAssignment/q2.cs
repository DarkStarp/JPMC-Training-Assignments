using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    internal class q2
    {
        static void Main(string[]args)
        {
            List<Player> ply = new List<Player>()
            {
                new Player(){ name ="Dev",country="India" },
                new Player(){ name ="harshit",country="Pakistan" },
                new Player(){ name ="Gourav",country="Nepal" }
            };
            List<Player> ply2 = new List<Player>()
            {
                
                new Player(){ name ="rajat",country="India" },
                new Player(){ name ="Karan",country="Nepal" },
                new Player(){ name ="Hritik",country="Bhutan" }
            };
            var result = from p in ply
                         from pp in ply2
                         where p.country != pp.country
                         select (p.name, pp.name);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
    class Player
    {
        public string name { get; set; }
        public string country { get; set; }
    }
}
