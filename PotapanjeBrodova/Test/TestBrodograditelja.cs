using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
namespace Test
{

    [TestClass]
    public class TestBrodograditelja
    {
       

        [TestMethod]
        public void Brodograditelj_SloziFlotuVracaFlotuBrodovimaZadaneDuljine()
        {
            Brodograditelj b = new Brodograditelj();
            Mreža mreza = new Mreža(10, 10);
            IEnumerable<int> duljineBrodova = new int[] { 5, 4, 4, 3, 3, 3, 2, 2, 2, 2 };
            Flota f = b.SložiFlotu(mreza, duljineBrodova);
            Assert.AreEqual(duljineBrodova.Count(), f.BrojBrodova);
            //IEnumerable<int> duljineBrodova2 = new int[] {};
            //foreach (Brod brod in f.DajListuBrodova()) {
            //    duljineBrodova2.
            //        (brod.Polja.Count());
            //}
            //todo provjerit ako ima samo jedan duljine 5 2 dljine 4 ...
        }
    }
}
