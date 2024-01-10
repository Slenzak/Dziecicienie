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
        public int koszyksuma=0;
        public Klient(string imie, string nazwisko) :base (imie, nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public void CenaKoszyka()
        {
            Console.WriteLine(koszyksuma);
        }
        public void dodawanieKsiazki(IProdukt produkt, Ksiazka produc)
        {
            Console.WriteLine(produc.Dostepnailosc());
            if (produkt == null)
            {
                Console.WriteLine("Brak dostepnych produktow");
            }
            else
            {
                Koszyk.Add(produkt);
                produc.ilosc--;
                koszyksuma +=produc.cena;
            }
            Console.WriteLine(produc.Dostepnailosc());
        }
        public void dodawanieELektroniki(IProdukt produkt, Elektronika produc)
        {
            Console.WriteLine(produc.Dostepnailosc());
            if (produkt == null)
            {
                Console.WriteLine("Brak dostepnych produktow");
            }
            else
            {
                Koszyk.Add(produkt);
                produc.ilosc--;
                koszyksuma +=produc.cena;
            }
            Console.WriteLine(produc.Dostepnailosc()); ;
        }
        public void dodawanieOdziez(IProdukt produkt, Odziez produc)
        {
            Console.WriteLine(produc.Dostepnailosc());
            if (produkt == null)
            {
                Console.WriteLine("Brak dostepnych produktow");
            }
            else
            {
                Koszyk.Add(produkt);
                produc.ilosc--;
                koszyksuma += produc.cena;
            }
            Console.WriteLine(produc.Dostepnailosc());
        }
        public void Cenaksiazka(Ksiazka ksiazka)
        {
            Console.WriteLine(ksiazka.cena);
        }
        public void CenaElektronika(Elektronika elektronika)
        {
            Console.WriteLine(elektronika.cena);
        }
        public void CenaOdziez(Odziez odziez)
        {
            Console.WriteLine(odziez.cena);
        }
        

    }
}
