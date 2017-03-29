using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
namespace Test
{

    [TestClass]
    public class TestredaFiksneDuljine
    {
       

        [TestMethod]
        public void RedFiksneDuljine_DodavanjeJednogClanaPovecavaDuljinuReda()
        {
            RedFiksneDuljine<Polje> r = new RedFiksneDuljine<Polje>(3);
            Assert.AreEqual(0, r.Count);
            r.Enqueue(new Polje(0, 0));
            Assert.AreEqual(1,r.Count);
        }
        [TestMethod]
        public void RedFiksneDuljine_DodavanjeCetvrtogClanaNePovecavaDuljinuReda()
        {
            RedFiksneDuljine<Polje> r = new RedFiksneDuljine<Polje>(3);
            r.Enqueue(new Polje(0, 0));
            r.Enqueue(new Polje(1, 0));
            r.Enqueue(new Polje(2, 0));
            Assert.AreEqual(3, r.Count);
            r.Enqueue(new Polje(3, 0));
            Assert.AreEqual(3, r.Count);

        }
        [TestMethod]
        public void RedFiksneDuljine_DodavanjeCetvrtogClanaIzbacijePrviClanIzRedaDuljine3()
        {
            RedFiksneDuljine<Polje> r = new RedFiksneDuljine<Polje>(3);
            r.Enqueue(new Polje(0, 0));
            r.Enqueue(new Polje(1, 0));
            r.Enqueue(new Polje(2, 0));
            Assert.IsTrue(r.Contains(new Polje(0,0)));
            r.Enqueue(new Polje(3, 0));
            Assert.IsFalse(r.Contains(new Polje(0, 0)));
        }
        [TestMethod]
        public void BrisanjeUklanjaSveClanoveIzReda()
        {
            RedFiksneDuljine<Polje> r = new RedFiksneDuljine<Polje>(3);
            r.Enqueue(new Polje(0, 0));
            r.Enqueue(new Polje(1, 0));
            r.Enqueue(new Polje(2, 0));
            r.Clear();
            Assert.AreEqual(0, r.Count);
        }
    }
}
