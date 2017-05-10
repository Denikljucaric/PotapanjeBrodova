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
            if(p!=null)
                UkloniPolje(p.Redak, p.Stupac);
        }
        public Polje DajZadnjePolje() {
            return new Polje(redaka, stupaca);
        }
        IEnumerable<int> DajNizBrojeva(int maxVrijednost) {
            for (int i = 0; i < maxVrijednost; ++i)yield return i;
        }
        private IEnumerable<IEnumerable<Polje>> DajNizoveSlobodnihPolja(int duljinaNiza, IEnumerable<int> vanjskiIndex, IEnumerable<int> nutarnjiIndex, Func<int, int, Polje> dohvatPolja) {
            List<IEnumerable<Polje>> nizovi = new List<IEnumerable<Polje>>();
            foreach (int i in vanjskiIndex)
            {
                List<Polje> tmp = new List<Polje>();
                foreach (int j in nutarnjiIndex)
                {
                    Polje polje = dohvatPolja(i,j) ;
                    if (polje != null) tmp.Add(polje);
                    else tmp.Clear();
                    if (tmp.Count == duljinaNiza)
                    {
                        nizovi.Add(new List<Polje>(tmp));
                        tmp.RemoveAt(0);
                    }
                }
            }
            return nizovi;

        }
        public IEnumerable<IEnumerable<Polje>> DajNizoveSlobodnihPoljaUVertikalnomSmjeru(int duljinaNiza) {

            return DajNizoveSlobodnihPolja(duljinaNiza, DajNizBrojeva(stupaca), DajNizBrojeva(redaka),(i, j) => polja[j, i]);
        }
        public IEnumerable<IEnumerable<Polje>> DajNizoveSlobodnihPoljaUHorizontalnomSmjeru(int duljinaNiza)
        {
            return DajNizoveSlobodnihPolja(duljinaNiza, DajNizBrojeva(redaka), DajNizBrojeva(stupaca),(i,j) => polja[i,j]);
        }

        public IEnumerable<IEnumerable<Polje>> DajNizoveSlobodnihPolja(int duljinaNiza)
        {
            List<IEnumerable<Polje>> nizovi = new List<IEnumerable<Polje>>();
            nizovi.AddRange(DajNizoveSlobodnihPoljaUHorizontalnomSmjeru(duljinaNiza));
            nizovi.AddRange(DajNizoveSlobodnihPoljaUVertikalnomSmjeru(duljinaNiza));


            return nizovi;
        }

        private Polje[,] polja;
        private int redaka;
        private int stupaca;
    }
}
