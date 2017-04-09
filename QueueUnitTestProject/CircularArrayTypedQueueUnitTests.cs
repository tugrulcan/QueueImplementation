using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueueImplementation;


namespace QueueUnitTestProject
{
    [TestClass]
    public class CircularArrayTypedQueueUnitTests
    {
        [TestMethod]
        public void KuyrukBoskenDisplayElementsDuzgunYazdiriyorMu()
        {
            CircularArrayTypedQueue queue = new CircularArrayTypedQueue(10);
            string beklenen = "";
            string asil = queue.DisplayElements();
            Assert.AreEqual(beklenen, asil);
        }

        [TestMethod]
        public void KuyruktaElemanVarkenDisplayElementsDuzgunYazdiriyorMu()
        {
            CircularArrayTypedQueue queue = new CircularArrayTypedQueue(3);
            queue.Insert(1);
            queue.Insert(2);
            queue.Insert(3);

            string beklenen = "1 2 3 ";
            string asil = queue.DisplayElements();
            Assert.AreEqual(beklenen, asil);


        }

        [TestMethod]
        public void KuyrukBoskenInsertKuyrugaElemanEkliyorMu()
        {
            CircularArrayTypedQueue queue = new CircularArrayTypedQueue(3);
            queue.Insert(1);

            string beklenen = "1 ";
            string asil = queue.DisplayElements();
            Assert.AreEqual(beklenen, asil);

        }

        [TestMethod]
        public void KuyruktaElemanVarkenInsertKuyrugaElemanEkliyorMu()
        {
            CircularArrayTypedQueue queue = new CircularArrayTypedQueue(3);
            queue.Insert(1);
            queue.Insert(2);
            queue.Insert(3);

            string beklenen = "1 2 3 ";
            string asil = queue.DisplayElements();

            Assert.AreEqual(beklenen, asil);

            int beklenen_eleman_sayisi = 3;
            int asil_eleman_sayisi = queue.count;
            Assert.AreEqual(beklenen_eleman_sayisi, asil_eleman_sayisi);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void KuyrukDoluykenInsertExceptionFirlatiyorMu()
        {
            CircularArrayTypedQueue queue = new CircularArrayTypedQueue(2);
            queue.Insert(1);
            queue.Insert(2);
            queue.Insert(3);

        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void KuyrukBoskenremoveExceptionFirlatiyorMu()
        {
            CircularArrayTypedQueue queue = new CircularArrayTypedQueue(2);
            queue.Remove();
        }

        [TestMethod]
        public void KuyruktaElemanVarkenRemoveElemaniCikariyorMu()
        {
            CircularArrayTypedQueue queue = new CircularArrayTypedQueue(3);
            queue.Insert(1);
            queue.Insert(2);
            queue.Insert(3);
            object removed_item = queue.Remove();
            Assert.AreEqual("1", removed_item.ToString());
            Assert.AreEqual(2, queue.count);

            string beklenen = "2 3 ";
            string asil = queue.DisplayElements();
            Assert.AreEqual(beklenen, asil);

        }

        [TestMethod]
        public void KuyruktaElemanVarkenOndekiElemanlarSilininceSiraBozuluyorMu()
        {
            CircularArrayTypedQueue queue = new CircularArrayTypedQueue(3);
            queue.Insert(1);
            queue.Insert(2);
            queue.Insert(3);
            queue.Remove();
            queue.Remove();
            queue.Insert(4);

            string beklenen = "3 4 ";
            string asil = queue.DisplayElements();
            Assert.AreEqual(beklenen, asil);

            Assert.AreEqual(2, queue.count);

        }

    }
}
