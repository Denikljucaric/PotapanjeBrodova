﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
namespace UnitTestProject1
{
    [TestClass]
    public class TestPolja
    {
        [TestMethod]
        public void Polje_RedakIStupacJednakiSuArgumentimaKonstruktora()
        {
            Polje p = new Polje(2,3);
            Assert.AreEqual(2, p.Redak);
            Assert.AreEqual(3, p.Stupac);
        }
        [TestMethod]
        public void Polje_ZaDvaPoljaKojaImajuIsteKordinateMetodaEqualsVracaTrue()
        {
            Polje p1 = new Polje(2, 3);
            Polje p2 = new Polje(2, 3);

            Assert.IsTrue(p1.Equals(p2));
        }
        [TestMethod]
        public void Polje_ZaDvaPoljaKojanemajuIsteKordinateMetodaEqualsVracaTrue()
        {
            Polje p1 = new Polje(2, 3);
            Polje p2 = new Polje(3, 3);

            Assert.IsFalse(p1.Equals(p2));
            Polje p3 = new Polje(2, 4);
            Assert.IsFalse(p1.Equals(p3));
        }
    }
}
