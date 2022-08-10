using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    internal class q3
    {
        static void Main(string[]args)
        {
            List<Order> orders = new List<Order>()
            {
                new Order(){Name="pen",Id=1,date=new DateTime(2022,04,29),quantity=23},
                new Order(){Name="pencit",Id=2,date=new DateTime(2022,04,2),quantity=24},
                new Order(){Name="book",Id=3,date=new DateTime(2022,04,25),quantity=21},
                new Order(){Name="cake",Id=4,date=new DateTime(2022,05,25),quantity=43},
                new Order(){Name="maggi",Id=5,date=new DateTime(2022,06,29),quantity=3},
                new Order(){Name="box",Id=6,date=new DateTime(2022,04,18),quantity=20}
            };
            var result = from o in orders
                         orderby o.date descending
                         orderby o.quantity descending
                         select o;
            foreach(var order in result)
            {
                Console.WriteLine(order.Name+" "+order.date+" "+order.quantity);
            }



        }
    }
    class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime date { get; set; }
        public int quantity { get; set; }
    }
}
