using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class Brodograditelj
    {
        public Flota SložiFlotu(int redaka,int stupaca, IEnumerable<int> duljineBrodova)
        {
            Mreža mreža = new Mreža(redaka, stupaca);
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


        private Random slučajni = new Random();
    }
}
