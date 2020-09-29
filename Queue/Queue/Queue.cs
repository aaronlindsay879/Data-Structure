namespace Queue.Queue
{
    /// <summary>
    /// A simple queue class
    /// </summary>
    /// <typeparam name="T">Type to use for the queue</typeparam>
    class Queue<T> : IQueue<T>
    {
        protected int _length;
        protected int _frontPtr;
        protected int _rearPtr;

        protected T[] _values;

        /// <summary>
        /// Initiliases the queue with the given length value
        /// </summary>
        /// <param name="length">Length of queue</param>
        public Queue(int length)
        {
            _length = length;

            _values = new T[length];
        }

        /// <summary>
        /// Method to check if the queue is full, by checking rear pointer
        /// </summary>
        /// <returns>Boolean indicating if queue is full</returns>
        public bool IsFull() => _rearPtr == _length - 1;

        /// <summary>
        /// Method to check if queue is empty, by comparing rear and front pointers
        /// </summary>
        /// <returns>Boolean indicating if queue is empty</returns>
        public bool IsEmpty() => _rearPtr == _frontPtr;

        /// <summary>
        /// Method to add item to queue
        /// </summary>
        /// <param name="item">Item to add</param>
        public virtual void EnQueue(T item)
        {
            if (!IsFull())
                _values[_rearPtr++] = item;
        }

        /// <summary>
        /// Method to remove first item from queue
        /// </summary>
        /// <returns>Item from queue</returns>
        public virtual T DeQueue()
        {
            if (!IsEmpty())
                return _values[_frontPtr++];

            //if queue is empty, return default value for type
            return default;
        }
    }
}
