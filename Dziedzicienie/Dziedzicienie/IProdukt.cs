using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedzicienie
{
    public interface IProdukt
    {
        public string Wyswietlinfo();

        public int Aktualnacena();
        public int Dostepnailosc();
    }
}
