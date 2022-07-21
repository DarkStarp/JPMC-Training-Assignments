namespace Assignment_4
{
    internal class q1
    {
        public string name = "The quick brown fox jumps over the lazy dog";

        public void print12()
        {
            Console.WriteLine("the 12th index's character is " + name[12]);
        }
        public void checkis()
        {
            string[] a = name.Split(" ");
            int b = 1;
            foreach (string s in a)
            {
                if (s == "is")
                    b = 1;
                else
                    b = 0;
            }
            if (b == 1)
            {
                Console.WriteLine("String contains the words is");
            }
            else
                Console.WriteLine("String doesn't contains the words is");

        }
        public void addstring()
        {
            name = string.Concat(name, " and killed it.");
            Console.WriteLine(name);
        }

        public void endwith()
        {
            if (name.EndsWith("dogs"))
            {
                Console.WriteLine("yes its and with it");
            }
            else
                Console.WriteLine("No its not");
        }
        public void equalon()
        {
            string str1 = "The quick brown Fox jumps over the lazy dog";
            if (str1 == name)
            {
                Console.WriteLine("strings are equal");
            }
            else
                Console.WriteLine("strings are not equal");
        }
        public void findl()
        {
            Console.WriteLine("length of string is " + name.Length);
        }
        public void checks()
        {
            string str2 = "The quick brown fox jumps over the lazy dog";
            if (String.Compare(name, str2) == 0)
                Console.WriteLine("yes equal");
            else
                Console.WriteLine("No not equal");
        }
        public void replace()
        {
            name = name.Replace("The", "A");
            Console.WriteLine(name);
        }
        public void splitanimal()
        {
            string[] sa = name.Split("over");
            Console.WriteLine("the two strings are ");
            foreach (string s in sa)
            {
                Console.WriteLine(s);
            }

        }
        public void aniname()
        {
            string[] a = name.Split(" ");
            foreach (string s in a)
            {
                if (s == "dog" || s == "fox")
                    Console.WriteLine(s);
            }
        }
        public void lowerc()
        {
            Console.WriteLine(name.ToLower());
        }
        public void upperc()
        {
            Console.WriteLine(name.ToUpper());
        }
        public void finda()
        {
            Console.WriteLine(name.IndexOf('a'));
        }
        public void finde()
        {
            Console.WriteLine(name.LastIndexOf('e'));
        }
        public void tomcat()
        {
            Console.WriteLine("Enter server");
            string s = Console.ReadLine();
            s = string.Concat(s, @"Webpages/Myapps/Images");
            Console.WriteLine(s);
        }
        public void poem()
        {
            Console.WriteLine("I Wandered lonely as cloud \n Roses are red \n sky is black ");
        }



    }

}