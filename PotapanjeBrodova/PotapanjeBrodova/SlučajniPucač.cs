using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class SlučajniPucač : IPucač
    {
        public SlučajniPucač(Mreža mreza, int DuljinaBroda) {
            //TODO napravi pucaca
            this.mreza = mreza;
            this.DuljinaBroda = DuljinaBroda;
        }
        public Polje Gađaj()
        {
            //List<Polje> polje = new mreza.DajNizoveSlobodnihPolja(DuljinaBroda);
            throw new NotImplementedException();
        }

        public void ObradiGađanje(RezultatGađanja rezultat)
        {
            throw new NotImplementedException();
        }
        private Mreža mreza;
        private int DuljinaBroda;

        public IEnumerable<Polje> PogodenaPolja
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
