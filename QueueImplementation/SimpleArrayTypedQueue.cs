using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
    public class SimpleArrayTypedQueue : IQueue
    {
        int front = -1;
        int rear = -1;
        int size = 0;
        int count = 0;

        private object[] items_array;

        public SimpleArrayTypedQueue(int size)
        {
            this.size = size;
            items_array = new object[size];
        }

        /*
         * Kuyruğun boyutunun dolu olduğunda ekleme yapıldığında hata fırlatıyor mu
         * Kuyruk boşken eleman eklendiğinde eleman ekleniyor mu
         * Kuyrukta eleman varken eleman eklendiğinde ekleniyor mu
         */
        public void Insert(object item)
        {
            if (count == size || rear == size - 1)
                throw new StackOverflowException();
            else
            {
                if (front == -1)
                    front = 0;
                rear++;
                items_array[rear] = item;
                count++;
            }
        }

        /*
         *Kuyruk boşken true değeri donduruyor mu
         *Kuyruk doluyken false değeri donduruyor mu
         */
        public bool IsEmpty()
        {
            return count == 0 ? true : false;
        }

        /*
         * Kuyruk boşken hata fırlatıyor mu
         * Kuyruk doluyken değer döndürüyor mu
         */
        public object Peek()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException();
            else
                return items_array[front];
            }

        /*
         * Kuyruk boşken hata fırlatıyor mu
         * Kuyruk doluyken değer döndürüyor mu
         */
        public object Remove()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException();
            else
            {
                object old_front = items_array[front];
                items_array[front] = null;
                front++;
                count--;

                return old_front;
            }
        }

        /*
         * Kuyruk boşsa hata fırlatıyor mu
         * Kuyrukta eleman varsa yazdırıyor mu
         */
        public string DisplayElements()
        {
            string Ifade = "";

            if(count == 0)
                throw new IndexOutOfRangeException();
            else
            {
                for(int i=front;i<=rear;i++)
                {
                    Ifade += items_array[i].ToString() + " ";
                }
            }

            return Ifade;
        }
    }
}
