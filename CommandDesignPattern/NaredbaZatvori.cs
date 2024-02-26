using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    //Druga konkretna naredba
    class NaredbaZatvori : ICommand
    {
        private Dokument dokument;

        public NaredbaZatvori(Dokument dok)
        {
            dokument = dok;
        }

        public void execute()
        {
            dokument.Zatvori();
        }
    }
}
