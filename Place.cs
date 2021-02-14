using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class Place
    {
        public Place()
        {
            UtworzListePracownikow();
            
        }

        public List<Pracownik> Pracownicy { get; set; }


         void UtworzListePracownikow()
        {
            Pracownicy = new List<Pracownik>();

            
            


                Pracownik pracownik1 = new Pracownik("Adam", "Kowalski", "Pracownik fizyczny");

                Pracownicy.Add(pracownik1);

                Pracownik pracownik2 = new Pracownik("Hanna", "Królikowska", "Pracownik fizyczny");

                Pracownicy.Add(pracownik2);

                Pracownik pracownik3 = new Pracownik("Krzysztof", "Bąk", "Pracownik fizyczny");

                Pracownicy.Add(pracownik3);

                Pracownik pracownik4 = new Pracownik("Róża", "Błaszczyk", "Pracownik fizyczny");

                Pracownicy.Add(pracownik4);

                Pracownik pracownik5 = new Pracownik("Maliwna", "Zając", "Pracownik fizyczny");

                Pracownicy.Add(pracownik5);

                Pracownik pracownik6 = new Pracownik("Roman", "Skierkowski", "Pracownik fizyczny");

                Pracownicy.Add(pracownik6);

                Pracownik pracownik7 = new Pracownik("Patryk", "Seszyn", "Pracownik fizyczny");

                Pracownicy.Add(pracownik7);


                Pracownik pracownik8 = new Pracownik("Bruno", "Wlazeł", "Pracownik fizyczny");

                Pracownicy.Add(pracownik8);

                Pracownik pracownik9 = new Pracownik("Grażyna", "Tomaszczuk", "Pracownik fizyczny");


                Pracownicy.Add(pracownik9);

                Pracownik pracownik10 = new Pracownik("Alina", "Promyk", "Pracownik fizyczny");


                Pracownicy.Add(pracownik10);

                Pracownik pracownik11 = new Pracownik("Stefania", "Małecka", "Pracownik umysłowy");


                Pracownicy.Add(pracownik11);

                Pracownik pracownik12 = new Pracownik("Krystian", "Osełka", "Pracownik umysłowy");


                Pracownicy.Add(pracownik12);

                Pracownik pracownik13 = new Pracownik("Wanda", "Pruszek", "Pracownik umysłowy");


                Pracownicy.Add(pracownik13);

                Pracownik pracownik14 = new Pracownik("Teresa", "Brożek", "Pracownik umysłowy");


                Pracownicy.Add(pracownik14);

                Pracownik pracownik15 = new Pracownik("Anna", "Kruk", "Pracownik umysłowy");


                Pracownicy.Add(pracownik15);

                Pracownik pracownik16 = new Pracownik("Jerzy", "Walas", "Pracownik umysłowy");


                Pracownicy.Add(pracownik16);

                Pracownik pracownik17 = new Pracownik("Ewelina", "Trzymała", "Pracownik umysłowy");


                Pracownicy.Add(pracownik17);

                Pracownik pracownik18 = new Pracownik("Józef", "Podolski", "Pracownik umysłowy");


                Pracownicy.Add(pracownik18);

                Pracownik pracownik19 = new Pracownik("Marianna", "Osiewalska", "Pracownik umysłowy");


                Pracownicy.Add(pracownik19);

                Pracownik pracownik20 = new Pracownik("Lucyna", "Kot", "Pracownik umysłowy");


                Pracownicy.Add(pracownik20);



           
        }
    }
}   