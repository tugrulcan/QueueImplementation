using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueueImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUnitTestProject
{
    [TestClass]
    public class PriorityArrayTypedQueueUnitTests
    {
        [TestMethod]
        public void KuyrukBoskenDisplayElementsDuzgunYazdiriyorMu()
        {
            PriorityArrayTypedQueue queue = new PriorityArrayTypedQueue(10);
            string beklenen = "";
            string asil = queue.DisplayElements();
            Assert.AreEqual(beklenen, asil);
        }

        [TestMethod]
        public void KuyruktaElemanVarkenDisplayElementsDuzgunYazdiriyorMu()
        {
            PriorityArrayTypedQueue queue = new PriorityArrayTypedQueue(5);
            queue.Insert(1);
            queue.Insert(2);
            queue.Insert(4);
            queue.Insert(5);
            queue.Insert(3);

            string beklenen = "1 2 3 4 5 ";
            string asil = queue.DisplayElements();
            Assert.AreEqual(beklenen, asil);
        }

        [TestMethod]
        public void KuyrukBoskenInsertKuyrugaElemanEkliyorMu()
        {
            PriorityArrayTypedQueue queue = new PriorityArrayTypedQueue(3);
            queue.Insert(1);

            string beklenen = "1 ";
            string asil = queue.DisplayElements();
            Assert.AreEqual(beklenen, asil);

        }

        [TestMethod]
        public void KuyruktaElemanVarkenInsertKuyrugaElemanEkliyorMu()
        {
            PriorityArrayTypedQueue queue = new PriorityArrayTypedQueue(3);
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
            PriorityArrayTypedQueue queue = new PriorityArrayTypedQueue(2);
            queue.Insert(1);
            queue.Insert(2);
            queue.Insert(3);

        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void KuyrukBoskenremoveExceptionFirlatiyorMu()
        {
            PriorityArrayTypedQueue queue = new PriorityArrayTypedQueue(2);
            queue.Remove();
        }

        [TestMethod]
        public void KuyruktaElemanVarkenRemoveElemaniCikariyorMu()
        {
            PriorityArrayTypedQueue queue = new PriorityArrayTypedQueue(3);
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
            PriorityArrayTypedQueue queue = new PriorityArrayTypedQueue(3);
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
