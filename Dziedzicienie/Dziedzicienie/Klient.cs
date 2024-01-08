using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedzicienie
{
    internal class Klient : Osoba
    {
        List<IProdukt> Koszyk = new List<IProdukt>();
        string imie="Jan";
        string nazwisko="Kowal";
        public Klient(List<IProdukt> koszyk, string imie, string nazwisko) :base (imie, nazwisko)
        {
            Koszyk = koszyk;
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public void dodawanie(IProdukt produkt)
        {
            
            if (produkt == null)
            {
                Console.WriteLine("Brak dostepnych produktow");
            }
            else
            {
                Koszyk.Add(produkt);
                produkt.Dostepnailosc();
            }
            Console.WriteLine(produkt.Dostepnailosc());
        }

    }
}
