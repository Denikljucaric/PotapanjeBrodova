using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public enum TaktikaGadanja
    {
        Nasumicno,
        Kruzno,
        Linisko
    }
    public class Topnistvo
    {


        public Topnistvo(int redaka, int stupaca, IEnumerable<int> duljineBrodova)
        {
            mreza = new Mreža(redaka,stupaca);
            this.duljineBrodova = new List<int>(duljineBrodova);
        }

        public void ObradiGadanje(RezultatGađanja rezultat)
        {
            if (rezultat == RezultatGađanja.Promašaj)
                return;
            if (rezultat == RezultatGađanja.Pogodak) {
                switch (TaktikaGadanja) {
                    case TaktikaGadanja.Nasumicno:
                        PromjeniTaktikuUKruzno();
                        return;
                    case TaktikaGadanja.Kruzno:
                        PromjeniTaktikuULinisko();
                        return;
                    case TaktikaGadanja.Linisko:
                        return;
                    default:
                        Debug.Assert(false);
                        break;

                }
                }
                Debug.Assert(rezultat == RezultatGađanja.Potopljen);
                PromjeniTaktikuUNasumicno();
            
        }
        private void PromjeniTaktikuUNasumicno()
        {
            TaktikaGadanja = TaktikaGadanja.Nasumicno;
        }
       private void PromjeniTaktikuUKruzno() {
            TaktikaGadanja = TaktikaGadanja.Kruzno;
        }
        private void PromjeniTaktikuULinisko()
        {
            TaktikaGadanja = TaktikaGadanja.Linisko;
        }

        public TaktikaGadanja TaktikaGadanja { get; private set; }
        private List<int> duljineBrodova;
        private Mreža mreza;
    }
}
