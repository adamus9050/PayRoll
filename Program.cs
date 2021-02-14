using Payroll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Place place = new Place();



            List<Pracownik> pracownicy = new List<Pracownik>();

  

                bool start = true;

                while (start)

                {
                    Console.WriteLine("DZIAŁ KADR I PŁAC\n\n");

                    Console.WriteLine("Lista pracowników firmy:\n");

                    int index = 1;
                    foreach (Pracownik temppracownik in place.Pracownicy)
                    {
                        Console.WriteLine(index++ + "." + temppracownik.PrintName());

                    }

                    Console.WriteLine("\n");

                    Console.WriteLine("Proszę podać numer pracownika:  ");

                    int NumerPracownika = 0;

                    bool PoprawnaWartosc = true;

                    do
                    {
                        PoprawnaWartosc = true;


                        NumerPracownika = Convert.ToInt32(Console.ReadLine()); ;
                        if (NumerPracownika <= 0 || NumerPracownika > 20)
                        {
                            Console.WriteLine("Liczba musi byc z zakresu 1-20. Spróbuj ponownie: ");
                            PoprawnaWartosc = false;
                        }

                    } while (!PoprawnaWartosc);

                    Pracownik pracownik = pracownicy.ElementAt(NumerPracownika - 1);
                    Console.WriteLine("\n" + pracownik.printOthers());

                }



            
        }
    }

}
