using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    class Program
    {
        static void Main(String[] args)
        {
            //Pravljenje instance recivera
            Dokument dokument = new Dokument();

            //pravljenje objekata komande prosljeđivanjem instance recivera
            ICommand Naredbaotvori = new NaredbaOtvori(dokument);
            ICommand Naredbazatvori = new NaredbaZatvori(dokument);
            ICommand Naredbaspremi = new NaredbaSpremi(dokument);

            //pravljenje instance invokera prosljeđivanjem objekata komande
            MenuOptions menu = new MenuOptions(Naredbaspremi, Naredbazatvori, Naredbaotvori);

            //Prosljeđivanje objekata invokeru da ih obavi
            menu.ClickOtvori();
            menu.ClickSpremi();
            menu.ClickZatvori();

            Console.ReadKey();
        }
    }
}

