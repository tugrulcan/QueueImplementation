using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
    public class PriorityArrayTypedQueue : IQueue
    {
        int front = -1;
        int rear = -1;
        public int count = 0;
        int size = 0;

        object[] items_array;


        public PriorityArrayTypedQueue(int size)
        {
            this.size = size;
            this.items_array = new object[size];
        }

        public void Insert(object item)
        {
            if (count == 0)
            {
                front++;
                rear++;
                this.count++;
                this.items_array[front] = item;
            }
            else if (count == size)
            {
                throw new OverflowException();
            }
            else
            {
                int i;
                for (i = front; i >= 0; i--)
                {
                    if ((int)item > (int)items_array[i])
                        items_array[i + 1] = items_array[i];
                    else
                        break;
                }
                items_array[i + 1] = item;
                count++;
                front++;
            }
        }

        public bool IsEmpty()
        {
            return this.count == 0 ? true : false;
        }

        public object Peek()
        {
            return items_array[front];
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
                removed_item = items_array[front];
                items_array[front] = null;
                front--;
                count--;
            }

            return removed_item;
        }

        public string DisplayElements()
        {
            string msg = null;
            if (count == 0)
                msg = "";
            else
            {
                for (int i = front; i >= 0; i--)
                {
                    msg += items_array[i].ToString() + " ";
                }
            }
            return msg;
        }


    }
}
