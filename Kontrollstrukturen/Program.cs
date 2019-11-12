using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            int b = 30;

            if (a < b)
            {
                Console.WriteLine("A ist kleiner als B");
            }
            else if (a > b)
            {
                Console.WriteLine("A ist größer B");
            }
            else
            {
                Console.WriteLine("A und B sind gleich");
            }

            while (a < b)
            {
                Console.WriteLine($"{a} ist kleiner als {b}");
                a++;

                if (a == 29) break;
                if (a == 29) continue;
            }


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i ist gerade {i}.");
            }

            for (int i = 1; i <= 1000; i *= 2)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            int[] zahlenarray = { 2, 4, 56, 78, 96, 12, 12 };

            Console.WriteLine(zahlenarray[4]);
            zahlenarray[4] = 123;
            Console.WriteLine(zahlenarray[4]);

            for (int i = 0; i < zahlenarray.Length; i++)
            {
                Console.WriteLine(zahlenarray[i]);
            }

            foreach (var item in zahlenarray)
            {
                Console.WriteLine(item);
            }

            int[,] zweiDimArray = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    zweiDimArray[i, j] = i * j;
                }
            }

            Console.WriteLine(zweiDimArray[5, 8]);

            string beispiel = "Hallo";
            Console.WriteLine(beispiel[2]);

            Console.WriteLine(beispiel.Contains('a'));

            Console.ReadKey();
        }
    }
}
