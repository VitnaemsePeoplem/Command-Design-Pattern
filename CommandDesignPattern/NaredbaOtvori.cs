using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    //Prva konkretna naredba
    class NaredbaOtvori : ICommand //implementira naredbeno sučelje
    {
        //Referenca recivera
        private Dokument dokument;

        //Inicijalizacija recivera pomoću konstruktora
        public NaredbaOtvori(Dokument dok)
        {
            dokument = dok;
        }

        //execute metoda poziva reciverovu metodu otvori
        public void execute()
        {
            dokument.Otvori();
        }
    }
}
