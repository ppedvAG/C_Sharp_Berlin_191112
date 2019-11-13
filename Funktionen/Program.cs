using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktionen
{
    class Program
    {
        public static int Addiere(int a, int b, int c = 0, int d = 0)
        {
            return a + b + c + d;
        }
        public static int Addiere(params int[] summanden)
        {
            int summe = 0;
            foreach (var item in summanden)
            {
                summe += item;
            }
            return summe;
        }
        public static double Addiere(double a, double b)
        {
            return a + b;
        }

        public static int AddiereUndSubtrahiere(int a, int b, out int differenz)
        {
            differenz = a - b;
            return a + b;
        }

        static void Main(string[] args)
        {
            int summe = Addiere(5, 10, 45);
            Console.WriteLine(summe);

            double summe2 = Addiere(4.6, 3.8);

            summe = Addiere(23, 78, -45, 9, 23, 74, 4411);
            
            summe = AddiereUndSubtrahiere(4, 3, out int diff);
            Console.WriteLine($"Summe: {summe}\nDifferenz: {diff}");

            string eingabe = "798";
            if(int.TryParse(eingabe, out int umgewandelterString))
            {
                Console.WriteLine(umgewandelterString*2);
            }

            Environment.Exit(0);

            Console.ReadKey();
        }
    }
}
