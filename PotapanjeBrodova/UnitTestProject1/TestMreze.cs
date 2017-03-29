﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
using System.Linq;
namespace UnitTestProject1
{
    [TestClass]
    public class TestMreze
    {
        [TestMethod]
        public void mreža_DajSlobodnaPoljaVracaSvaPoljaZaPočetnuMrežu()
        {
            Mreza m1 = new Mreza(5, 5);
            Assert.AreEqual(25, m1.DajSlobodnaPolja().Count());

        }
        [TestMethod]
        public void mreža_DajSlobodnaPoljaVraca24PoljaZaMrežu5x5NakonJednogUklonjenogPoljaZadanogRetkomIstupcem()
        {
            Mreza m1 = new Mreza(5, 5);
            m1.UkloniPolje(new Polje(1, 1));
            Assert.AreEqual(24, m1.DajSlobodnaPolja().Count());
            Assert.IsFalse(m1.DajSlobodnaPolja().Contains(new Polje(1, 1)));
        }
        [TestMethod]
        public void mreža_DajSlobodnaPoljaVraca24PoljaZaMrežu5x5NakonJednogUklonjenogPolja()
        {
            Mreza m1 = new Mreza(5, 5);
            m1.UkloniPolje(1,1);
            Assert.AreEqual(24, m1.DajSlobodnaPolja().Count());
            Assert.IsFalse(m1.DajSlobodnaPolja().Contains(new Polje(1,1)));
        }
        [TestMethod]
        public void mreža_DajSlobodnaPoljaVraca23PoljaZaMrežu5x5NakondvaUklonjenogPolja()
        {
            Mreza m1 = new Mreza(5, 5);
            m1.UkloniPolje(1, 1);
            m1.UkloniPolje(4, 4);
            Assert.AreEqual(23, m1.DajSlobodnaPolja().Count());
            Assert.IsFalse(m1.DajSlobodnaPolja().Contains(new Polje(1, 1)));
            Assert.IsFalse(m1.DajSlobodnaPolja().Contains(new Polje(4, 4)));
        }
        [TestMethod]
        public void mreža_UkloniPoljeBacaIznimkuZaNepostojeciRedak()
        {
            try
            {
                Mreza m1 = new Mreza(5, 5);

                m1.UkloniPolje(6, 1);
                Assert.Fail();
            }
            catch (IndexOutOfRangeException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception) {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void mreža_UkloniPoljeBacaIznimkuZaNepostojeciStupac()
        {
            try
            {
                Mreza m1 = new Mreza(5, 5);

                m1.UkloniPolje(1, 6);
                Assert.Fail();
            }
            catch (IndexOutOfRangeException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
        public void mreza_dakMOzpvePolavraca3uhorizontalnomretkuduljine5()
        {
            Mreza m = new Mreza(1, 5);
            Assert.AreEqual(3,m.DajNizoveSlobodnihPolja(3).Count());
        }
        public void mreza_dakMOzpvePolavracaprazanuhorizontalnomretkuduljine5uhorizontalnom()
        {
            Mreza m = new Mreza(1, 3);
            Assert.AreEqual(0, m.DajNizoveSlobodnihPolja(5).Count());
        }
        public void mreza_dakMOzpvePolavraca3uvertikalnomomretkuduljine5()
        {
            Mreza m = new Mreza(5, 1);
            Assert.AreEqual(3, m.DajNizoveSlobodnihPolja(3).Count());
        }
        public void mreza_dakMOzpvePolavracaprazanuvertikalnomretkuduljine5uhorizontalnom()
        {
            Mreza m = new Mreza(4, 1);
            Assert.AreEqual(0, m.DajNizoveSlobodnihPolja(5).Count());
        }
    }
}
