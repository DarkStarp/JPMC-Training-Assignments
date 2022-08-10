using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    internal class q5
    {
        static void Main(string[] args)
        {
            List<Orders> orders = new List<Orders>()
            {
                new Orders(){Name="pen",Id=1,date=new DateTime(2022,04,29),quantity=23},
                new Orders(){Name="pencit",Id=2,date=new DateTime(2022,04,2),quantity=24},
                new Orders(){Name="book",Id=3,date=new DateTime(2022,04,25),quantity=21},
                new Orders(){Name="cake",Id=4,date=new DateTime(2022,05,25),quantity=43},
                new Orders(){Name="maggi",Id=5,date=new DateTime(2022,06,29),quantity=3},
                new Orders(){Name="box",Id=6,date=new DateTime(2022,04,18),quantity=20}
            };
            List<Item> items = new List<Item>()
            {
                new Item(){Name="pen",price=100 },
                new Item(){Name="pencit",price=200 },
                new Item(){Name="book",price=300 },
                new Item(){Name="cake",price=250 },
                new Item(){Name="maggi",price=245 },
                new Item(){Name="box",price=120 }
            };
            var result = from o in orders
                         join
                         i in items
                         on o.Name equals i.Name
                         orderby o.date.Month descending
                         select new { o.Id, o.Name, o.quantity, i.price };
            foreach (var up in result)
            {
                Console.WriteLine(up.Id + "----- " + up.Name + "---- " + up.quantity*up.price);
            }



        }
    }
    class Orders
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime date { get; set; }
        public int quantity { get; set; }
    }
    class Item
    {
        public string Name { get; set; }
        public int price { get; set; }
    }
}
