using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class KružniPucač : IPucač
    {


        public KružniPucač(Mreža mreza, Polje pogodeno, int duljinaBroda) {
            this.mreza = mreza;
            this.pogodenoPolje = pogodeno;
            this.duljinaBroda = duljinaBroda;


        }
        public IEnumerable<Polje> PogodenaPolja
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Polje Gađaj()
        {
            throw new NotImplementedException();
        }

        public void ObradiGađanje(RezultatGađanja rezultat)
        {
            throw new NotImplementedException();
        }
        private int duljinaBroda;
        private Mreža mreza;
        private Polje pogodenoPolje;
    }
}
