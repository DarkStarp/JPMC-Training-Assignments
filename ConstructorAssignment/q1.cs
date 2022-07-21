namespace ConstructorAssignment
{
    internal class q1
    {
        
    }
    class Person
    {
        public string Firstn;
        public string Lastn;
        public string Email;
        public DateTime dob;

        public Person(string a,string b,string c,DateTime d)
        {
            Firstn = a;
            Lastn = b;
            Email = c;
            dob = d;
        }
        public static Person accept()
        {
            Console.WriteLine("Enter First name");
            string a = Console.ReadLine();
            Console.WriteLine("Enter Last name");
            string b = Console.ReadLine();
            Console.WriteLine("Enter email");
            string c = Console.ReadLine();
            Console.WriteLine("Enter Dob");
            DateTime d = DateTime.Parse(Console.ReadLine());
            return new Person(a,b,c,d);


        }
        public void showdetails()
        {
            Console.WriteLine($"Name: {Firstn} {Lastn} \nEmail Adresses: {Email} \nDate of birth: {dob}");

        }

    }
}