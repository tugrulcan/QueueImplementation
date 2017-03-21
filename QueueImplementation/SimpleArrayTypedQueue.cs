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

        public bool IsEmpty()
        {
            return count == 0 ? true : false;
        }

        public object Peek()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException();
            else
                return items_array[front];
            }

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
    }
}
