using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class Brodograditelj
    {
        public Flota SloziFlotu(Mreža mreza, IEnumerable<int> duljineBrodova) {
            Flota flota = new Flota();
            TerminatorPolja tp = new TerminatorPolja(mreza);
            foreach (int i in duljineBrodova) {
                var nizovi = mreza.DajNizoveSlobodnihPolja(i);
                int index = slucajni.Next(nizovi.Count());
                var niz = nizovi.ElementAt(index);
                flota.DodajBrod(niz);
                tp.UkloniPolja(niz);
            }
            return flota;
            //todo popraviti jer moze se desiti da nema vise slobodnih polja

        }
        Random slucajni = new Random();

    }
}
