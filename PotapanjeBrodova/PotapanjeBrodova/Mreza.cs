using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotapanjeBrodova
{
    public class Mreza
    {
        public Mreza(int redaka, int stupaca)
        {
            this.redaka = redaka;
            this.stupaca = stupaca;
            polje = new Polje[redaka, stupaca];
            for (int r = 0; r < redaka; ++r)
            {
                for (int s = 0; s < stupaca; ++s)
                    polje[r, s] = new Polje(r, s);
            }
        }
        public IEnumerable<Polje> DajSlobodnaPolja()
        {
            List<Polje> p = new List<Polje>();
            for (int r = 0; r < redaka; ++r)
            {
                for (int s = 0; s < stupaca; ++s)
                    if (polje[r, s] != null) p.Add(polje[r, s]);
            }
            return p;
        }
        public IEnumerable<IEnumerable<Polje>> DajNizoveSlobodnihPolja(int duljinaNiza)
        {
            List<IEnumerable<Polje>> nizovi = new List<IEnumerable<Polje>> ();
            
                for (int r = 0; r < redaka; ++r)
                {
                    List<Polje> tmp = new List<Polje>();

                   for (int s = 0, i = 0; s < stupaca; ++s)
                        {
                        if (polje[r, s] != null)i++;
                        else i = 0;
                    if (i >= duljinaNiza) {
                        for (int counter = 0; duljinaNiza > counter; counter++) {
                            tmp.Add(polje[r, s-counter]);
                        }
                        nizovi.Add(tmp);
                        tmp.Clear();
                    }
                    }
                }
            for (int s = 0; s < stupaca; ++s)
            {
                List<Polje> tmp = new List<Polje>();

                for (int r = 0, i = 0; r < redaka; ++r)
                {
                    if (polje[r, s] != null) i++;
                    else i = 0;
                    if (i >= duljinaNiza)
                    {
                        for (int counter = 0; duljinaNiza > counter; counter++)
                        {
                            tmp.Add(polje[r-counter, s]);
                        }
                        nizovi.Add(tmp);
                        tmp.Clear();
                    }
                }
            }

            return nizovi;
        }
        public void UkloniPolje(int redak, int stupac) {
            polje[redak, stupac] = null;
        }
        public void UkloniPolje(Polje p)
        {
            polje[p.Redak, p.Stupac] = null;
        }
        
        private Polje[,] polje;
        private int redaka, stupaca;
    }
}
