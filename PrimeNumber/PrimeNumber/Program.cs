using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                int c = 0;
                for(int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        c++;
                }
                if(c==2)
                    Console.WriteLine(i);
            }
        }
    }
}
