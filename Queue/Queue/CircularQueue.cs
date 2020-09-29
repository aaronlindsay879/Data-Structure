using System;
using System.Collections.Generic;
using System.Text;

namespace Queue.Queue
{
    /// <summary>
    /// A circular queue class
    /// </summary>
    /// <typeparam name="T">Type to use for data</typeparam>
    class CircularQueue<T> : Queue<T>
    {
        /// <summary>
        /// Instantiates the class, delegating to base class
        /// </summary>
        /// <param name="length"></param>
        public CircularQueue(int length) : base(length) { }

        /// <summary>
        /// Increments a given pointer, perfoming a mod when neeed
        /// </summary>
        /// <param name="ptr">Pointer to increment</param>
        public void IncrementPtr(ref int ptr)
        {
            ptr = (ptr + 1) % _length;
        }

        /// <summary>
        /// Method to add item to queue
        /// </summary>
        /// <param name="item">Item to add</param>
        public override void EnQueue(T item)
        {
            if (!IsFull())
            {
                _values[_rearPtr] = item;
                IncrementPtr(ref _rearPtr);
            }
        }

        /// <summary>
        /// Method to remove first item from queue
        /// </summary>
        /// <returns>Item from queue</returns>
        public override T DeQueue()
        {
            if (!IsEmpty())
            {
                int temp = _frontPtr;
                IncrementPtr(ref _frontPtr);

                return _values[temp];
            }

            //if queue is empty, return default value for type
            return default;
        }
    }
}
