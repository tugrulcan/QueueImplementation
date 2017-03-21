using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
    public interface IQueue
    {

        void Insert(object item);
        object Remove();
        object Peek();
        bool IsEmpty();
    }
}
