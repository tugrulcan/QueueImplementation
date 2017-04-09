using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
    public class CircularArrayTypedQueue : IQueue
    {
        int front = -1;
        int rear = -1;
        int size = 0;
        public int count = 0;

        private object[] items_array;

        public CircularArrayTypedQueue(int size)
        {
            this.size = size;
            this.items_array = new object[size];
        }

        public void Insert(object item)
        {
            if (count == 0)
            {
                front = rear = 0;
                this.items_array[rear] = item;
                this.count++;
            }
            else if (count == size)
            {
                throw new OverflowException();
            }
            else
            {
                rear = (rear + 1) % size;
                this.items_array[rear] = item;
                this.count++;
            }
        }

        public bool IsEmpty()
        {
            return this.count == 0 ? true : false;
        }

        public object Peek()
        {
            return this.items_array[front];
        }

        public object Remove()
        {
            object removed_item = null;
            if (count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                this.count--;
                removed_item = this.items_array[front];
                front = (front + 1) % size;
            }

            return removed_item;
        }

        public string DisplayElements()
        {
            string msg = "";

            if (this.count == 0)
            {
                msg = "";
            }
            else
            {

                for (int i = front; ; i = (i + 1) % size)
                {
                    msg += this.items_array[i].ToString() + " ";
                    if (i == rear)
                        break;
                }

            }

            return msg;
        }
    }
}
