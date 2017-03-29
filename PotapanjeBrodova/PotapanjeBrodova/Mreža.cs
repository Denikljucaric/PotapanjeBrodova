using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class Mreža
    {
        public Mreža(int redaka, int stupaca)
        {
            this.redaka = redaka;
            this.stupaca = stupaca;
            polja = new Polje[redaka, stupaca];
            for (int r = 0; r < redaka; ++r)
            {
                for (int s = 0; s < stupaca; ++s)
                    polja[r, s] = new Polje(r, s);
            }
        }

        public IEnumerable<Polje> DajSlobodnaPolja()
        {
            List<Polje> p = new List<Polje>();
            for (int r = 0; r < redaka; ++r)
            {
                for (int s = 0; s < stupaca; ++s)
                {
                    if (polja[r, s] != null)
                        p.Add(polja[r, s]);
                }
            }
            return p;
        }

        public void UkloniPolje(int redak, int stupac)
        {
            polja[redak, stupac] = null;
        }

        public void UkloniPolje(Polje p)
        {
            polja[p.Redak, p.Stupac] = null;
        }

        public IEnumerable<IEnumerable<Polje>> DajNizoveSlobodnihPolja(int duljinaNiza)
        {
            List<IEnumerable<Polje>> nizovi = new List<IEnumerable<Polje>>();
            for (int r = 0; r < redaka; ++r)
            {
                List<Polje> tmp = new List<Polje>();

                for (int s = 0, i = 0; s < stupaca; ++s)
                {
                    if (polja[r, s] != null) i++;
                    else i = 0;
                    if (i >= duljinaNiza)
                    {
                        for (int counter = 0; duljinaNiza > counter; counter++)
                        {
                            tmp.Add(polja[r, s - counter]);
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
                    if (polja[r, s] != null) i++;
                    else i = 0;
                    if (i >= duljinaNiza)
                    {
                        for (int counter = 0; duljinaNiza > counter; counter++)
                        {
                            tmp.Add(polja[r - counter, s]);
                        }
                        nizovi.Add(tmp);
                        tmp.Clear();
                    }
                }
            }

            return nizovi;
        }

        private Polje[,] polja;
        private int redaka;
        private int stupaca;
    }
}
