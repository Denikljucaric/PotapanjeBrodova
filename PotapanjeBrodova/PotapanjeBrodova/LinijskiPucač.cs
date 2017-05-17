using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class LinijskiPucač : IPucač
    {
        public LinijskiPucač(Mreža mreža, IEnumerable<Polje> pogođena, int duljinaBroda)
        {
            this.mreža = mreža;
            this.pogođenaPolja = new List<Polje>(pogođena);
            this.duljinaBroda = duljinaBroda;
        }

        public Polje Gađaj()
        {
            List<Polje> kandidati = DajKandidate();
            gađanoPolje = kandidati[izbornik.Next(kandidati.Count)];
            return gađanoPolje;
        }

        public void ObradiGađanje(RezultatGađanja rezultat)
        {
            mreža.UkloniPolje(gađanoPolje);
            switch (rezultat)
            {
                case RezultatGađanja.Promašaj:
                    return;
                case RezultatGađanja.Pogodak:
                    pogođenaPolja.Add(gađanoPolje);
                    
                    return;
                case RezultatGađanja.Potopljen:
                    pogođenaPolja.Add(gađanoPolje);
                    TerminatorPolja terminator = new TerminatorPolja(mreža);
                    terminator.UkloniPolja(pogođenaPolja);
                    return;
                default:
                    Debug.Assert(false);
                    break;
            }
        }

        public IEnumerable<Polje> PogođenaPolja
        {
            get
            {
                Debug.Assert(pogođenaPolja.Count >= 2);
                return pogođenaPolja.Sortiraj();
            }
        }
        private List<Polje> DajKandidate()
        {
            Debug.Assert(pogođenaPolja.Count > 1);
            List<Polje> kandidati = new List<Polje>();
            List<Smjer> sm = new List<Smjer>();
            if (pogođenaPolja.First().Redak == pogođenaPolja.Last().Redak) {
                sm.Add(Smjer.Lijevo);
                sm.Add(Smjer.Desno);
            }
            if (pogođenaPolja.First().Stupac == pogođenaPolja.Last().Stupac)
            {
                sm.Add(Smjer.Gore);
                sm.Add(Smjer.Dolje);
            }
           
            var niz = mreža.DajNizSlobodnihPolja(pogođenaPolja.First(), sm.First());
                if (niz.Count() > 0)
                    kandidati.Add(niz.ElementAt(0));
                niz = mreža.DajNizSlobodnihPolja(pogođenaPolja.Last(), sm.Last());
            if (niz.Count() > 0)
                kandidati.Add(niz.ElementAt(0));
            Debug.Assert(kandidati.Count() > 0);
            return kandidati;
        }

        private Polje gađanoPolje;
        private Mreža mreža;
        private List<Polje> pogođenaPolja = new List<Polje>();
        private int duljinaBroda;
        private Random izbornik = new Random();
    }
}
