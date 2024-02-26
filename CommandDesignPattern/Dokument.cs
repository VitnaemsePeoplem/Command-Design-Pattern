using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    //Reciver
    //On posjeduje informacije kako obaviti određene operacije
    public class Dokument
    {
        public void Otvori()
        {
            Console.WriteLine("Dokument otvoren");
        }

        public void Zatvori()
        {
            Console.WriteLine("Dokument zatvoren");
        }

        public void Spremi()
        {
            Console.WriteLine("Dokument spremljen");
        }
    }
}
