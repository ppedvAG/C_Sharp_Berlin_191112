using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StruckVSClass
{
    class PersonC
    {
        public string name;
        public int alter;

        public PersonC(string name, int alter)
        {
            this.name = name;
            this.alter = alter;
        }

    }

    struct PersonS
    {
        public string name;
        public int alter;

        public PersonS(string name, int alter)
        {
            this.name = name;
            this.alter = alter;
        }
    }


    class Program
    {
        public static void Altern (PersonC cPerson)
        {
            cPerson.alter++;
        }

        public static void Altern(PersonS sPerson)
        {
            sPerson.alter++;
        }

        public static void Altern(ref PersonS sPerson)
        {
            sPerson.alter++;
        }

        static void Main(string[] args)
        {
            PersonC cPerson = new PersonC("Heiko", 35);
            PersonS sPerson = new PersonS("Anna", 35);

            Console.WriteLine($"{cPerson.name}: {cPerson.alter}");
            Console.WriteLine($"{sPerson.name}: {sPerson.alter}");

            Altern(cPerson);
            Altern(sPerson);

            Console.WriteLine($"{cPerson.name}: {cPerson.alter}");
            Console.WriteLine($"{sPerson.name}: {sPerson.alter}");

            Altern(ref sPerson);
            Console.WriteLine($"{sPerson.name}: {sPerson.alter}");

            Console.ReadKey();
        }
    }
}
