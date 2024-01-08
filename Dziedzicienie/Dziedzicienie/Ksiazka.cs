using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedzicienie
{
    public class Ksiazka : IProdukt
    {
        string name = "Pan tadeusz";
        int cena = 2000;
        int ilosc= 2;
        public Ksiazka(string name, int cena, int ilosc)
        {
            this.name = name;
            this.cena = cena;
            this.ilosc = ilosc;
        }

        public int Aktualnacena()
        {
            return cena;
        }

        public int Dostepnailosc()
        {
            return ilosc;
        }

        public string Wyswietlinfo()
        {
            return name;
        }
    }
}
