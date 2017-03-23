using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueueImplementation;

namespace QueueUnitTestProject
{
    [TestClass]
    public class SimpleArrayTypedQueueUnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(StackOverflowException))]
        public void KuyrukBoyutuDoluOldugundaEklemeYapildigindaHataFirlatiyorMu()
        {
            SimpleArrayTypedQueue sm = new SimpleArrayTypedQueue(1);
            sm.Insert(0);
            sm.Insert(1);
        }

        [TestMethod]
        public void KuyrukBoskenElemanEkleniyorMu()
        {
            SimpleArrayTypedQueue sm = new SimpleArrayTypedQueue(1);
            sm.Insert(1);
            string beklenenIfade = "1 ";
            string gercekIfade = sm.DisplayElements();

            Assert.AreEqual(beklenenIfade, gercekIfade);
            
        }

        [TestMethod]
        public void KuyruktaElemanVarkenElemanEkliyorMu()
        {
            SimpleArrayTypedQueue sm = new SimpleArrayTypedQueue(3);
            sm.Insert(1);
            sm.Insert(2);
            sm.Insert(3);

            string beklenenIfade = "1 2 3 ";
            string gercekIfade = sm.DisplayElements();

            Assert.AreEqual(beklenenIfade, gercekIfade);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void KuyrukBossaHataFirlatiyorMu()
        {
            SimpleArrayTypedQueue sm = new SimpleArrayTypedQueue(2);
            sm.DisplayElements();
        }

        [TestMethod]
        public void KuyruktaElemanVarkenYazdiriyorMu()
        {
            SimpleArrayTypedQueue sm = new SimpleArrayTypedQueue(2);
            sm.Insert(1);
            sm.Insert(2);

            string beklenenIfade = "1 2 ";
            string gercekIfade = sm.DisplayElements();

            Assert.AreEqual(beklenenIfade, gercekIfade);
        }

        [TestMethod]
        public void DisplayElementDizininIlkElemanıBossaDogruOkuyorMu()
        {
            SimpleArrayTypedQueue sm = new SimpleArrayTypedQueue(4);
            sm.Insert(1);
            sm.Insert(2);
            sm.Insert(3);
            sm.Insert(4);
            sm.Remove();

            string beklenenIfade = "2 3 4 ";
            string gercekIfade = sm.DisplayElements();

            Assert.AreEqual(beklenenIfade, gercekIfade);
        }

        [TestMethod]
        public void KuyrukBoskenTrueDegeriDonduruyorMu()
        {
            SimpleArrayTypedQueue sm = new SimpleArrayTypedQueue(2);
            bool beklenenDeger = true;
            bool gercekDeger = sm.IsEmpty();

            Assert.AreEqual(beklenenDeger, gercekDeger);
        }

        [TestMethod]
        public void KuyrukDoluykenFalseDegeriDonuyorMu()
        {
            SimpleArrayTypedQueue sm = new SimpleArrayTypedQueue(2);
            sm.Insert(1);

            bool beklenenDeger = false;
            bool gercekDeger = sm.IsEmpty();

            Assert.AreEqual(beklenenDeger, gercekDeger);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void KuyrukBoskenHataFirlatiyorMu()
        {
            SimpleArrayTypedQueue sm = new SimpleArrayTypedQueue(2);
            sm.Peek();
        }

        [TestMethod]
        public void KuyrukDoluykenDegerDonduruyorMu()
        {
            SimpleArrayTypedQueue sm = new SimpleArrayTypedQueue(3);
            sm.Insert(1);
            sm.Insert(2);
            sm.Insert(3);

            int beklenenDeger = 1;
            int gercekDeger = Convert.ToInt32(sm.Peek());

            Assert.AreEqual(beklenenDeger, gercekDeger);
        }

        [TestMethod]
        public void KuyruktaElemanVarsaSiliyorMu()
        {
            SimpleArrayTypedQueue sm = new SimpleArrayTypedQueue(3);
            sm.Insert(1);
            sm.Insert(2);
            sm.Insert(3);
            sm.Remove();

            string beklenenDeger = "2 3 ";
            string gercekDeger = sm.DisplayElements();

            Assert.AreEqual(beklenenDeger, gercekDeger);
        }

    }
}
