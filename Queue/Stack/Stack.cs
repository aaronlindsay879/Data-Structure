using System;
using System.Collections.Generic;
using System.Text;

namespace Queue.Stack
{
    /// <summary>
    /// A class representing a stack
    /// </summary>
    /// <typeparam name="T">Type of info to store</typeparam>
    class Stack<T>
    {
        protected int _ptr;
        protected int _length;

        protected T[] _values;

        /// <summary>
        /// Instantiates the class, setting the length and creating the value
        /// </summary>
        /// <param name="length">Length of stack</param>
        public Stack(int length)
        {
            _length = length;

            _values = new T[length];
        }

        /// <summary>
        /// Checks if the stack is full, by comparing pointer to length
        /// </summary>
        /// <returns>Boolean representing if stack is full</returns>
        public bool IsFull() => _ptr == _length - 1;

        /// <summary>
        /// Checks if list is empty, by checking pointer
        /// </summary>
        /// <returns>Boolean representing if stack is empty</returns>
        public bool IsEmpty() => _ptr == 0;

        /// <summary>
        /// Pushes an item onto the queue
        /// </summary>
        /// <param name="value">Item to add</param>
        public void Push(T value)
        {
            if (!IsFull())
                _values[_ptr++] = value;
        }

        /// <summary>
        /// Removes an item from the queue
        /// </summary>
        /// <returns>Removed item</returns>
        public T Pop()
        {
            if (!IsEmpty())
                return _values[--_ptr];

            return default;
        }
    }
}
