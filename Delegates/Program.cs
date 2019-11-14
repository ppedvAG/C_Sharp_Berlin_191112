using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate int MyDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate delegateVariable = new MyDelegate(Addiere);

            int ergebnis = delegateVariable(4, 8);
            Console.WriteLine(ergebnis);

            delegateVariable = Subtrahiere;

            ergebnis = delegateVariable(4, 8);
            Console.WriteLine(ergebnis);

            delegateVariable += Addiere;

            ergebnis = delegateVariable(4, 8);
            Console.WriteLine(ergebnis);

            foreach (var item in delegateVariable.GetInvocationList().ToList())
            {
                Console.WriteLine(item.Method);
            }

            delegateVariable -= Subtrahiere;

            delegateVariable = null;

            Func<int, int, int> meinFunc = Addiere;
            meinFunc += Subtrahiere;

            Console.WriteLine(meinFunc(123,789));

            FuehreAus(Subtrahiere);


            List<string> Staedteliste = new List<string>() { "München", "Berlin", "Frankfurt", "Hamburg" };

            string gefundeneStadt = Staedteliste.Find(SucheStadtMitH);
            Console.WriteLine(gefundeneStadt);

            gefundeneStadt = Staedteliste.Find(
                delegate (string stadt) 
                { 
                    return stadt.StartsWith("H"); 
                });

            gefundeneStadt = Staedteliste.Find((string stadt) => { return stadt.StartsWith("H"); });
            gefundeneStadt = Staedteliste.Find(stadt => stadt.StartsWith("H"));

            Staedteliste = Staedteliste.OrderBy(stadt => stadt[0]).ToList();

            foreach (var item in Staedteliste)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        public static bool SucheStadtMitH(string stadt)
        {
            return stadt.StartsWith("H");
        }

        public static void FuehreAus(Func<int, int, int> auszufuehrendeMethode)
        {
            int erg = auszufuehrendeMethode(45, 78) * 2;
            Console.WriteLine(erg);
        }

        public static int Addiere(int a, int b)
        {
            Console.WriteLine("Addition");
            return a + b;
        }
        public static int Subtrahiere(int a, int b)
        {
            Console.WriteLine("Subtraktion");
            return a - b;
        }
    }

}
