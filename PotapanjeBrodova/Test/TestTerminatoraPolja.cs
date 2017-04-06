using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    [TestClass]
    public class TestTerminatoraPolja
    {
        private Mreža mreza;
        private TerminatorPolja terminator;
        [TestInitialize]
        public void PripremiMrezuITerminator() {
            mreza = new Mreža(10, 10);
            terminator = new TerminatorPolja(mreza);
        }
        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUSrediniMreze()
        {

            IEnumerable<Polje> polja = new Polje[] { new Polje(3, 3), new Polje(3, 4) };
            terminator.UkloniPolja(polja);
            Assert.AreEqual(88,mreza.DajSlobodnaPolja().Count());
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(3,3)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(3, 4)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(2, 2)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(2, 5)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(4, 2)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(4, 5)));
           
        }
        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUZGornjiRubMreze()
        {
            IEnumerable<Polje> polja = new Polje[] { new Polje(0, 3), new Polje(0, 4) };
            terminator.UkloniPolja(polja);
            Assert.AreEqual(92, mreza.DajSlobodnaPolja().Count());
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(0, 3)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(0, 4)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(0, 2)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(1, 2)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(1, 5)));
        }
        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUGornjiLjeviKutMreze()
        {
            IEnumerable<Polje> polja = new Polje[] { new Polje(0, 0), new Polje(0, 1) };
            terminator.UkloniPolja(polja);
            Assert.AreEqual(94, mreza.DajSlobodnaPolja().Count());
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(0, 0)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(0, 1)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(0, 2)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(1, 1)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(1, 2)));
        }
        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUGornjiDesniKutMreze()
        {
            IEnumerable<Polje> polja = new Polje[] { new Polje(0, 9), new Polje(1, 9) };
            terminator.UkloniPolja(polja);
            Assert.AreEqual(94, mreza.DajSlobodnaPolja().Count());
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(0, 9)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(1, 9)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(2, 9)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(2, 8)));
        }
        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUDoljnjiLjeviKutMreze()
        {
            IEnumerable<Polje> polja = new Polje[] { new Polje(8, 9), new Polje(9, 9) };
            terminator.UkloniPolja(polja);
            Assert.AreEqual(94, mreza.DajSlobodnaPolja().Count());
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(9, 9)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(8, 9)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(7, 8)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(9, 8)));
        }
        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUDoljnjiDesniKutMreze()
        {
            IEnumerable<Polje> polja = new Polje[] { new Polje(9, 0), new Polje(9, 1) };
            terminator.UkloniPolja(polja);
            Assert.AreEqual(94, mreza.DajSlobodnaPolja().Count());
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(9, 0)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(9, 1)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(8, 2)));
            Assert.IsFalse(mreza.DajSlobodnaPolja().Contains(new Polje(8, 0)));
        }
    }
}
