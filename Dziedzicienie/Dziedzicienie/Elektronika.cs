using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedzicienie
{
    internal class Elektronika:IProdukt
    {
        string name = "Pc";
        int cena = 200000;
        int ilosc = 1;
        public Elektronika(string name, int cena, int ilosc)
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
