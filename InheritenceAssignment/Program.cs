namespace InheritenceAssignment
{

    class furniture
    {
        public int orderid;
        public DateTime orderdate;
        public string furtype;
        public int qty;
        public double amt = 0;
        public string paymode;

        public void get_details()
        {
            Console.WriteLine("enter Order ID");
            orderid = int.Parse(Console.ReadLine());

            orderdate = DateTime.Now;
            Console.WriteLine("Enter furniture type");
            furtype = Console.ReadLine();
            Console.WriteLine("Payment mode");
            paymode = Console.ReadLine();
            if (furtype.Equals("chair", StringComparison.OrdinalIgnoreCase))
            {
                chair ch = new chair();
                ch.chair_type();
                ch.type();
                Console.WriteLine($"Order Id: {orderid}");
                Console.WriteLine($"Ordr date: {orderdate}");

                ch.display();
            }
            if (furtype.Equals("cot", StringComparison.OrdinalIgnoreCase))
            {
                Cot c = new Cot();
                c.cot_type();
                c.type();
                Console.WriteLine($"Order Id: {orderid}");
                Console.WriteLine($"Ordr date: {orderdate}");
                c.display();
            }
        }
    }
    class chair : furniture
    {
        public string chairtype;
        public string purpose;
        public int rate;
        public void chair_type()
        {
            Console.WriteLine("Enter Chair Type");
            chairtype = Console.ReadLine();
            Console.WriteLine("Purpose of product");
            purpose = Console.ReadLine();

        }
        public void type()
        {
            if (chairtype.Equals("Wood", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter wood type 'Teak' or 'Rose' wood");
                chairtype = Console.ReadLine() + chairtype;
                Console.WriteLine("Enter quantity");
                qty = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter rate");
                rate = int.Parse(Console.ReadLine());
                amt += (qty * rate);
            }
            if (chairtype.Equals("steel", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter steel type 'Gray' or 'Green' or 'Brown'");
                chairtype = Console.ReadLine() + chairtype;
                Console.WriteLine("Enter quantity");
                qty = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter rate");
                rate = int.Parse(Console.ReadLine());
                amt += (qty * rate);
            }
            if (chairtype.Equals("plastic", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter plastic color 'red' or 'Green' or 'white' ");
                chairtype = Console.ReadLine() + chairtype;
                Console.WriteLine("Enter quantity");
                qty = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter rate");
                rate = int.Parse(Console.ReadLine());
                amt += (qty * rate);
            }
        }
        public void display()
        {
            Console.WriteLine($"Furniture type: {chairtype} \nAmount: {amt}");
        }

    }
    class Cot : furniture
    {
        public string cottype;
        public string purpose;
        public int rate;
        public void cot_type()
        {
            Console.WriteLine("Enter cot Type");
            cottype = Console.ReadLine();
            Console.WriteLine("Purpose of product");
            purpose = Console.ReadLine();
        }
        public void type()
        {
            if (cottype.Equals("Wood", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter wood type 'Teak' or 'Rose' wood");
                cottype = Console.ReadLine() + cottype;
                Console.WriteLine("Enter quantity");
                qty = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter rate");
                rate = int.Parse(Console.ReadLine());
                amt += (qty * rate);
            }
            if (cottype.Equals("Steel", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter steel type 'Gray' or 'Green' wood");
                cottype = Console.ReadLine() + cottype;
                Console.WriteLine("Enter quantity");
                qty = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter rate");
                rate = int.Parse(Console.ReadLine());
                amt += (qty * rate);
            }
        }
        public void display()
        {
            Console.WriteLine($"Furniture type: {cottype} \nAmount: {amt}");
        }

    }
}