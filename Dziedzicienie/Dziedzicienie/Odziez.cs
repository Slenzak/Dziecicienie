using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedzicienie
{
    internal class Odziez:IProdukt
    {
        public string name = "Skarpety";
        public int cena = 500;
        public int ilosc = 0;
        public Odziez(string name, int cena, int ilosc)
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
