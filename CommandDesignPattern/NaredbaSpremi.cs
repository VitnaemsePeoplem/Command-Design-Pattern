using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    //Treća konkretna metoda
    class NaredbaSpremi : ICommand
    {
        //Referenca recivera
        private Dokument dokument;

        public NaredbaSpremi(Dokument dok)
        {
            dokument = dok;
        }

        public void execute()
        {
            dokument.Spremi();
        }
    }
}
