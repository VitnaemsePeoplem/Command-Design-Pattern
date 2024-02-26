using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    //Invoker
    //Njegova  zadaća jest pozvati execute metodu na objekt recivera
    public class MenuOptions
    {
      //Invoker tu šalje zahjtev naredbenom sučelju
        private ICommand Naredbaotvori;
        private ICommand Naredbazatvori;
        private ICommand Naredbaspremi;

        public MenuOptions (ICommand otvori, ICommand zatvori, ICommand spremi)
        {
            this.Naredbaotvori = otvori;
            this.Naredbaspremi = spremi;
            this.Naredbazatvori = zatvori;
        }

        //Invoker ne može obraditi zahtjev pa poziva execute metodu
        public void ClickOtvori()
        {
            Naredbaotvori.execute();
        }

        public void ClickZatvori()
        {
            Naredbazatvori.execute();
        }

        public void ClickSpremi()
        {
            Naredbaspremi.execute();
        }
    }
}
