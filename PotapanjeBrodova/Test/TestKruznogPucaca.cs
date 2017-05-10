using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class TestKruznogPucaca
    {
        [TestMethod]
        public void KruzniPucac_GadajDajeJednoOdOkolnihPolja()
        {
            Mreža mreza = new Mreža(5, 5);
            KružniPucač puc = new KružniPucač(mreza, new Polje(2, 2), 3);
            Polje gadano = puc.Gađaj();
            List<Polje> kandidati = new List<Polje> { new Polje(1, 2), new Polje(2, 1), new Polje(2, 3), new Polje(3, 2) };
            Assert.IsTrue(kandidati.Contains(gadano));
        }
        [TestMethod]
        public void KruzniPucac_GadajDajeJednoOdOkolnihPoljaDesnoIliLjevo()
        {
            Mreža mreza = new Mreža(1, 5);
            KružniPucač puc = new KružniPucač(mreza, new Polje(0, 2), 3);
            Polje gadano = puc.Gađaj();
            List<Polje> kandidati = new List<Polje> { new Polje(0, 1), new Polje(0, 3) };
            Assert.IsTrue(kandidati.Contains(gadano));
        }
        [TestMethod]
        public void KruzniPucac_GadajDajeJednoOdOkolnihPoljaKojaNisuEliminirana()
        {
            Mreža mreza = new Mreža(5, 5);
            KružniPucač puc = new KružniPucač(mreza, new Polje(2, 2), 3);
            mreza.UkloniPolje(1, 2);
            mreza.UkloniPolje(3, 2);
            Polje gadano = puc.Gađaj();
            List<Polje> kandidati = new List<Polje> { new Polje(2, 1), new Polje(2, 3) };
            Assert.IsTrue(kandidati.Contains(gadano));
        }
        [TestMethod]
        public void KruzniPucac_GadajDajeJednoOkolnoPoljeKojeNijeEliminirana()
        {
            Mreža mreza = new Mreža(5, 5);
            KružniPucač puc = new KružniPucač(mreza, new Polje(2, 2), 3);
            mreza.UkloniPolje(1, 2);
            mreza.UkloniPolje(3, 2);
            mreza.UkloniPolje(2, 1);
            Polje gadano = puc.Gađaj();
            Assert.AreEqual(new Polje(2,3),gadano);
        }
        [TestMethod]
        public void KruzniPucac_GadajDajePoljaDesnoIIspodZaPogodenoPoljeUGornjemLjevomKutu()
        {
            Mreža mreza = new Mreža(5, 5);
            KružniPucač puc = new KružniPucač(mreza, new Polje(0, 0), 3);
            List<Polje> kandidati = new List<Polje> { new Polje(0, 1), new Polje(1, 0)};
            Polje gadano = puc.Gađaj();
            Assert.IsTrue(kandidati.Contains(gadano));
        }
        [TestMethod]
        public void KruzniPucac_GadajDajePoljaLevoIiznadZaPogodenoPoljeUDoljnjemDesnomKutu()
        {
            Mreža mreza = new Mreža(5, 5);
            KružniPucač puc = new KružniPucač(mreza, new Polje(4, 4), 3);
            List<Polje> kandidati = new List<Polje> { new Polje(3, 4), new Polje(4, 3) };
            Polje gadano = puc.Gađaj();
            Assert.IsTrue(kandidati.Contains(gadano));
        }
    }
}
