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
        private TerminatoraPolja terminator;
        [TestInitialize]
        public void PripremiMrezuITerminator() {
            mreza = new Mreža(10, 10);
            terminator = new TerminatorPolja(mreza);
        }
        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUSrediniMreze()
        {

            IEnumerable<Polje> polja = new Polje[] { new Polje(3, 3), new Polje(3, 4) };
            terminator.ukloniPolja(polja);
            Assert.AreEqual(88,mreza.DajSlobodnaPolja().Count());
            //dodaj provjeru da su izbaceni (3,3 i 3,4) i provjerit rubna polja 2,2 i 2,5 i 4,2 i 4,5
        }
        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUZGornjiRubMreze()
        {

        }
        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUGornjiLjeviKutMreze()
        {

        }
        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUGornjiDesniKutMreze()
        {

        }
        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUDoljnjiLjeviKutMreze()
        {

        }
        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUDoljnjiDesniKutMreze()
        {

        }
    }
}
