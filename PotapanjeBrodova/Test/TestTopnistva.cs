using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
namespace Test
{
    [TestClass]
    public class TestTopnistva
    {
        [TestMethod]
        public void Topnistvo_NaPocetkuJeTaktikaNasumicna()
        {
            int redaka = 5, stupaca = 5;
            int[] duljineBrodova = new int[] { 3, 2, 1 };
            Topnistvo t = new Topnistvo(redaka,stupaca,duljineBrodova);
            Assert.AreEqual(TaktikaGadanja.Nasumicno, t.TaktikaGadanja);
        }
        [TestMethod]
        public void Topnistvo_NasumicnaTaktikaNakonPotonucaOstajeNasumicna()
        {
            int redaka = 5, stupaca = 5;
            int[] duljineBrodova = new int[] { 3, 2, 1 };
            Topnistvo t = new Topnistvo(redaka, stupaca, duljineBrodova);
            t.ObradiGadanje(RezultatGađanja.Promašaj);
            Assert.AreEqual(TaktikaGadanja.Nasumicno, t.TaktikaGadanja);
        }
        [TestMethod]
        public void Topnistvo_NasumicnaTaktikaNakonPromasajaOstajeNasumicna()
        {
            int redaka = 5, stupaca = 5;
            int[] duljineBrodova = new int[] { 3, 2, 1 };
            Topnistvo t = new Topnistvo(redaka, stupaca, duljineBrodova);
            t.ObradiGadanje(RezultatGađanja.Promašaj);
            Assert.AreEqual(TaktikaGadanja.Nasumicno, t.TaktikaGadanja);
        }
        [TestMethod]
        public void Topnistvo_NakonPrvogPogotkaTaktikaPrelaziUkruzno()
        {
            int redaka = 5, stupaca = 5;
            int[] duljineBrodova = new int[] { 3, 2, 1 };
            Topnistvo t = new Topnistvo(redaka, stupaca, duljineBrodova);
            t.ObradiGadanje(RezultatGađanja.Pogodak);
            Assert.AreEqual(TaktikaGadanja.Kruzno, t.TaktikaGadanja);
        }
        [TestMethod]
        public void Topnistvo_kruznoGadanjeNakonPromasajaOstajeKruzno()
        {
            int redaka = 5, stupaca = 5;
            int[] duljineBrodova = new int[] { 3, 2, 1 };
            Topnistvo t = new Topnistvo(redaka, stupaca, duljineBrodova);
            t.ObradiGadanje(RezultatGađanja.Pogodak);
            t.ObradiGadanje(RezultatGađanja.Promašaj);
            Assert.AreEqual(TaktikaGadanja.Kruzno, t.TaktikaGadanja);
        }
        [TestMethod]
        public void Topnistvo_kruznoGadanjeNakonPogotkaaOstajeLinisko()
        {
            int redaka = 5, stupaca = 5;
            int[] duljineBrodova = new int[] { 3, 2, 1 };
            Topnistvo t = new Topnistvo(redaka, stupaca, duljineBrodova);
            t.ObradiGadanje(RezultatGađanja.Pogodak);
            t.ObradiGadanje(RezultatGađanja.Pogodak);
            Assert.AreEqual(TaktikaGadanja.Linisko, t.TaktikaGadanja);
        }
        [TestMethod]
        public void Topnistvo_kruznoGadanjeNakonPotopljenjaPrelaziUNasumicno()
        {
            int redaka = 5, stupaca = 5;
            int[] duljineBrodova = new int[] { 3, 2, 1 };
            Topnistvo t = new Topnistvo(redaka, stupaca, duljineBrodova);
            t.ObradiGadanje(RezultatGađanja.Pogodak);
            t.ObradiGadanje(RezultatGađanja.Potopljen);
            Assert.AreEqual(TaktikaGadanja.Nasumicno, t.TaktikaGadanja);
        }
        [TestMethod]
        public void Topnistvo_LiniskoGadanjeNakonPogotkaOstajeLinisko()
        {
            int redaka = 5, stupaca = 5;
            int[] duljineBrodova = new int[] { 3, 2, 1 };
            Topnistvo t = new Topnistvo(redaka, stupaca, duljineBrodova);
            t.ObradiGadanje(RezultatGađanja.Pogodak);
            t.ObradiGadanje(RezultatGađanja. Pogodak);
            t.ObradiGadanje(RezultatGađanja.Promašaj);
            Assert.AreEqual(TaktikaGadanja.Linisko, t.TaktikaGadanja);
        }
        [TestMethod]
        public void Topnistvo_LiniskoGadanjeNakonPotonucaPrelaziUNasumicno()
        {
            int redaka = 5, stupaca = 5;
            int[] duljineBrodova = new int[] { 3, 2, 1 };
            Topnistvo t = new Topnistvo(redaka, stupaca, duljineBrodova);
            t.ObradiGadanje(RezultatGađanja.Pogodak);
            t.ObradiGadanje(RezultatGađanja.Pogodak);
            t.ObradiGadanje(RezultatGađanja.Pogodak);
            t.ObradiGadanje(RezultatGađanja.Potopljen);
            Assert.AreEqual(TaktikaGadanja.Nasumicno, t.TaktikaGadanja);
        }
    }
}
