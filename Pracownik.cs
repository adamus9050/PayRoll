using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class Pracownik
    {
        

        public Pracownik(string imie, string nazwisko, string stanowisko)
        {
          
            Imie = imie;
            Nazwisko = nazwisko;
            Stanowisko = stanowisko;
        }

       
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Stanowisko { get; set; }
        public int IloscDniNaZwolnieniu { get; set; }

        public decimal WynagrodzeniePodstawoweNetto { get; set; }
        public decimal PensjaStala { get; set; }
        public decimal PremiaUznaniowa { get; set; }
        public decimal DodatekSzkodliwy { get; set; }
        public decimal StawkaGodzinowa { get; set; }

        public int IloscDniPrzepracowanych
        {
            get
            {
                if (IloscDniNaZwolnieniu == 0)
                    return 20;
                else
                    return 20 - IloscDniNaZwolnieniu;

            }
        }

      

        public String PrintName()
        {
            return  Imie + " " + Nazwisko + "\n";

        }

        public String printOthers()
        {
            return  Imie + " " + Nazwisko + "\n" +
                "Stanowisko: " + Stanowisko + "\n";
               

          
        }

    }
}
