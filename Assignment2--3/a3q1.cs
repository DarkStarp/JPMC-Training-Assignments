namespace Assignment2__3
{
    internal class a3q1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter monthly payment");
            int N = int.Parse(Console.ReadLine());
            double M = 1000;
            int i = 1;
            while (M >= 0)
            {
                M = M + (M * 0.015);
                M = M - N;
                Console.WriteLine("Month {0} balance: {1} total payment: {2}",i,M,N*i);
                i++;
            }
        }
    }
}