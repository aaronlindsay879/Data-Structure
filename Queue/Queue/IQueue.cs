using System;
using System.Collections.Generic;
using System.Text;

namespace Queue.Queue
{
    interface IQueue<T>
    {
        bool IsFull();
        bool IsEmpty();
        void EnQueue(T item);
        T DeQueue();
    }
}
