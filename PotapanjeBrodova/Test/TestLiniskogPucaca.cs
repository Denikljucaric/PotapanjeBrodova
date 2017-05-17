using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class TestLiniskogPucaca
    {

                    [TestMethod]
        public void Linijski_GadajVracaJednoOdDvaPoljaLijevoPoljaOdHorizontalnogNiza()
        {
            Mreža mreža = new Mreža(10, 10);
            List<Polje> PogodenaPolja = new List<Polje>() { new Polje(2, 3), new Polje(2, 4) };
            LinijskiPucač puc = new LinijskiPucač(mreža, PogodenaPolja, 3);
            Polje gađano = puc.Gađaj();
            List<Polje> kandidati = new List<Polje> { new Polje(2, 2), new Polje(2, 5) };
            CollectionAssert.Contains(kandidati, gađano);

        }
        [TestMethod]
        public void Linijski_GadajVracaJednoOdDvaPoljagoreIliDolePoljaOdVertikalnogNizaNiza()
        {
            Mreža mreža = new Mreža(10, 10);
            List<Polje> PogodenaPolja = new List<Polje>() { new Polje(2, 3), new Polje(2, 4) };
            mreža.UkloniPolje(2, 5);
            LinijskiPucač puc = new LinijskiPucač(mreža, PogodenaPolja, 3);
            Polje gađano = puc.Gađaj();
            List<Polje> kandidati = new List<Polje> { new Polje(2, 2) };
            CollectionAssert.Contains(kandidati, gađano);
        }
        [TestMethod]
        public void Linijski_GadajVracaJednoOdsamoSlobodnoPoljeLijevoKodHorizontalnogNiza()
        {
            Mreža mreža = new Mreža(10, 10);
            List<Polje> PogodenaPolja = new List<Polje>() { new Polje(2, 3), new Polje(2, 4) };
            mreža.UkloniPolje(2, 2);
            LinijskiPucač puc = new LinijskiPucač(mreža, PogodenaPolja, 3);
            Polje gađano = puc.Gađaj();
            List<Polje> kandidati = new List<Polje> { new Polje(2, 5) };
            CollectionAssert.Contains(kandidati, gađano);

        }
        [TestMethod]
        public void Linijski_GadajVracaJednoOdsamoSlobodnoPoljeDesnoKodHorizontalnogNiza()
        {
            Mreža mreža = new Mreža(10, 10);
            List<Polje> PogodenaPolja = new List<Polje>() { new Polje(2, 3), new Polje(3, 3) };
            LinijskiPucač puc = new LinijskiPucač(mreža, PogodenaPolja, 3);
            Polje gađano = puc.Gađaj();
            List<Polje> kandidati = new List<Polje> { new Polje(1, 3), new Polje(4, 3) };
            CollectionAssert.Contains(kandidati, gađano);

        }
        [TestMethod]
        public void Linijski_GadajVracaJednoOdsamoSlobodnoPoljeGoreKodVertikalnogNiza()
        {

            Mreža mreža = new Mreža(10, 10);
            List<Polje> PogodenaPolja = new List<Polje>() { new Polje(2, 3), new Polje(3, 3) };
            mreža.UkloniPolje(4, 3);
            LinijskiPucač puc = new LinijskiPucač(mreža, PogodenaPolja, 3);
            Polje gađano = puc.Gađaj();
            List<Polje> kandidati = new List<Polje> { new Polje(1, 3), };
            CollectionAssert.Contains(kandidati, gađano);
        }
        [TestMethod]
        public void Linijski_GadajVracaJednoOdsamoSlobodnoPoljeDoljeKodVertikalnogNiza()
        {

            Mreža mreža = new Mreža(10, 10);
            List<Polje> PogodenaPolja = new List<Polje>() { new Polje(2, 3), new Polje(3, 3) };
            mreža.UkloniPolje(1, 3);
            LinijskiPucač puc = new LinijskiPucač(mreža, PogodenaPolja, 3);
            Polje gađano = puc.Gađaj();
            List<Polje> kandidati = new List<Polje> { new Polje(4, 3), };
            CollectionAssert.Contains(kandidati, gađano);
        }
    
}}
