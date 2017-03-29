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
        public IEnumerable<Polje> DajNizoveSlobodnihPolja(int duljinaNiza)
        {
            List<Polje> nizovi = new List<Polje>();

            for (int r = 0; r < redaka; ++r){
                Queue<Polje> tmp = new Queue<Polje>();
                tmp.Clear();
                for (int s = 0, i = 0; s < stupaca; ++s){
                    if (polje[r, s] != null){
                        i++;
                        tmp.Enqueue(polje[r, s]);
                        if (i >= duljinaNiza) nizovi.Add(tmp.Dequeue());
                    }
                    else{
                        i = 0;
                        tmp.Clear();
                    }
                }
            }
            for (int s = 0; s < stupaca; ++s)
            {
                Queue<Polje> tmp = new Queue<Polje>();
                tmp.Clear();
                for (int r = 0, i = 0; r < redaka; ++r)
                {
                    if (polje[r, s] != null)
                    {
                        i++;
                        tmp.Enqueue(polje[r, s]);
                        if (i >= duljinaNiza) nizovi.Add(tmp.Dequeue());
                    }
                    else
                    {
                        i = 0;
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
