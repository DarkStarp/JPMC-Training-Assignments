using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionAssignment
{
    class bookstore
    {
        public int bookid;
        public string name;
        public Hashtable hs = new Hashtable();

        public bookstore()
        {
            for(int i = 0; i < 10; i++)
            {
                bookid = int.Parse(Console.ReadLine());
                name = Console.ReadLine();
                hs.Add(bookid, name);
            }
        }
        public void display()
        {
            Console.WriteLine("Book information");
            foreach( var k in hs.Keys)
            {
                Console.WriteLine(k +" " + hs[k]);
            }
        }

    }
    internal class q4
    {
        static void Main(string[] args)
        {
            bookstore bs = new bookstore();
            bs.display();
        }
        
    }
}
