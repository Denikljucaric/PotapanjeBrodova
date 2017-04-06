using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class TerminatorPolja
    {
        private Mreža mreza;

        public TerminatorPolja(Mreža mreza) {
            this.mreza = mreza;
        }
        public void UkloniPolja(IEnumerable<Polje> polja) {
            int rDesni=int.MinValue, rLjevi= int.MaxValue;
            int sDesni= int.MinValue, sLjevi= int.MaxValue;
            Polje polje = mreza.DajZadnjePolje();
            foreach (Polje p in polja) {
                if (rLjevi >= p.Redak-1)
                    if(p.Redak>0)
                        rLjevi =p.Redak-1;
                    else rLjevi = 0;
                if (sLjevi >= p.Stupac-1)
                    if (p.Stupac > 0)
                        sLjevi = p.Stupac - 1;
                    else sLjevi = 0;
                if (rDesni <= p.Redak)
                    if(p.Redak<polje.Redak-1)
                        rDesni = p.Redak + 1;
                    else rDesni = p.Redak;
                if (sDesni <= p.Stupac)
                     if (p.Stupac <polje.Stupac-1)
                        sDesni = p.Stupac + 1;
                    else sDesni = p.Stupac;
            };
            for (int r = rLjevi; r <= rDesni; ++r) {
                for (int s = sLjevi; s <= sDesni; ++s)
                {
                    mreza.UkloniPolje(r, s);
                }
            }
         }
        }
    }
