using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class MeineException : Exception
    {
        public MeineException():base("Dies ist mein Fehler.") { }
    }


    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string eingabe = Console.ReadLine();
                int a = int.Parse(eingabe);

                throw new MeineException();
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Du musst eine Zahl eingeben.\n" + ex.Message);

                throw;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Deine Zahl ist zu groß/klein.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ein unbekannter Fehler ist aufgetreten");
            }
            finally
            {
                Console.WriteLine("Wird immer ausgeführt");
            }

            Console.WriteLine("ENDE TRY BLOCK");




            Console.ReadKey();

        }
    }
}
