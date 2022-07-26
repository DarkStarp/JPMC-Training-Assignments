﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    class q7 : Order
    {
        static void Main()
        {
            List<Order> orders = new List<Order>()
            {
                new Order() { Id=1,Name="Tea",date=new DateTime(2012,03,25),quantity=12},
                new Order() { Id=2,Name="Coffee",date=new DateTime(2011,03,25),quantity=13},
                new Order() { Id=3,Name="Milk",date=new DateTime(2032,05,10),quantity=0},
            };
            var lquery = from Order order in orders
                         where (order.quantity <= 0)
                         select order;
            if (lquery.Count() > 0)
            {
                Console.WriteLine("Following items have quantity less than or equal to 0");
                foreach (var k in lquery)
                    Console.WriteLine(k.Id + " " + k.Name + " " + k.quantity);
            }
            else
                Console.WriteLine("All items have quantity greater than 0");
            var lquery1 = from Order order in orders
                          orderby order.quantity descending
                          select order;
            foreach (var k in lquery1)
            {
                Console.WriteLine("Highest order item is " + k.Name + " with quantity " + k.quantity);
                break;
            }
            var lquery3 = from Order order in orders
                          where order.date.Year < 2022
                          select order;
            Console.WriteLine("Following item was ordered before Jan of this year");
            foreach (var k in lquery3)
                Console.WriteLine(k.Id + " " + k.Name + " " + k.date);

        }
    }
}
