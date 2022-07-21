using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2__3
{
    internal class a3q2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string  str = Console.ReadLine();
            string[] word = str.Split(" ");
            int [] obj = new int[word.Length];
            for(int j=0;j<word.Length;j++)
            {
                if (word[j] == ".")
                    continue;
                int k = 1;
                
                for(int i = j+1; i < word.Length; i++)
                {
                    
                    if (word[j].Equals(word[i],StringComparison.OrdinalIgnoreCase))
                    {
                        k++;
                        word[i] = ".";
                    }
                }
                obj[j] = k;
            }
            for(int i =0;i<obj.Length;i++)
            {
                if (word[i] == ".")
                    continue;
                else
                {
                    Console.WriteLine(word[i] + " : " + obj[i]);

                }
            }

        }
    }
}
