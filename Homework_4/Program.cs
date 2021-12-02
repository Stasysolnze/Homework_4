using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int x = 0;
            Console.Write("Введите N: ");

            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                x = x + (2 * i - 1);
                Console.Write(x);
                Console.Write(" ");

            }
            Console.ReadLine();
        }
    }
}
