using System.Collections;
namespace CollectionAssignment
{
    internal class q1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                al.Add(int.Parse(Console.ReadLine()));
            }
            al.Sort();
            for(int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
        }
    }
}