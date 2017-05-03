using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class Brodograditelj
    {
        public Flota SložiFlotu(Mreža mreža, IEnumerable<int> duljineBrodova)
        {
            
            TerminatorPolja terminator = new TerminatorPolja(mreža);
            int count=3;
            while (--count!=0)
            {
                Flota flota = new Flota();
                try
                {
                    foreach (int i in duljineBrodova)
                    {
                        var nizovi = mreža.DajNizoveSlobodnihPolja(i);
                        int indeks = slučajni.Next(nizovi.Count());
                        var niz = nizovi.ElementAt(indeks);
                        flota.DodajBrod(niz);
                        terminator.UkloniPolja(niz);

                    }
                    return flota;
                }
                catch (Exception) {
                    continue;
                }
            }
            return null;
        }

        // TODO: obratiti pažnju na slučaj da se ne mogu svi brodovi složiti

        private Random slučajni = new Random();
    }
}
