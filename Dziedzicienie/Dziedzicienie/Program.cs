using Dziedzicienie;

internal class Program
{
    private static void Main(string[] args)
    {
        Ksiazka ksiazka= new Ksiazka("tadek",2,20);
        Elektronika elektronika = new Elektronika("PC",2,20);
        Odziez odziez = new Odziez("Spodnica",2,20);
        Klient klient = new Klient("Jan","Kowal");
        klient.CenaKoszyka();
        klient.dodawanieKsiazki(ksiazka, ksiazka);
        klient.dodawanieELektroniki(elektronika, elektronika);
        klient.dodawanieOdziez(odziez, odziez);
        klient.Cenaksiazka(ksiazka);
        klient.CenaOdziez(odziez);
        klient.CenaElektronika(elektronika); 
        

    }
}