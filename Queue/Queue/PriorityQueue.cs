using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queue.Queue
{
    /// <summary>
    /// A class representing an item, and it's associated priority
    /// </summary>
    /// <typeparam name="T">Type to store</typeparam>
    class Item<T>
    {
        public T item;
        public int priority;

        /// <summary>
        /// Sets the item and priority
        /// </summary>
        /// <param name="Item">Item to store</param>
        /// <param name="Priority">Priority associated with data</param>
        public Item(T Item, int Priority)
        {
            item = Item;
            priority = Priority;
        }
    }

    /// <summary>
    /// A class representing a priority queue
    /// </summary>
    /// <typeparam name="T">Type of data to store</typeparam>
    class PriorityQueue<T>
    {
        protected int _length;

        protected List<Item<T>> _values;

        /// <summary>
        /// Initialises the list
        /// </summary>
        public PriorityQueue()
        {
            _values = new List<Item<T>>();
        }

        /// <summary>
        /// Checks if the priority queue is empty
        /// </summary>
        /// <returns>Bool indicating if queue is empty</returns>
        public bool IsEmpty() => _values.Count == 0;

        /// <summary>
        /// Adds an item to a queue
        /// </summary>
        /// <param name="item">Item to add</param>
        /// <param name="priority">Priority of item</param>
        public void EnQueue(T item, int priority)
        {
            if (!_values.Any(x => x.priority > priority))
            {
                //if no item in the list has a lower priority, just add to end
                _values.Add(new Item<T>(item, priority));
            }
            else
            {
                //otherwise, find index and add item there
                var index = _values.FindLastIndex(x => x.priority > priority) - 1;

                _values.Insert(index, new Item<T>(item, priority));
            }

        }

        /// <summary>
        /// Returns the first item from the queue
        /// </summary>
        /// <returns>Item</returns>
        public T DeQueue()
        {
            var temp = _values.First();

            _values.Remove(temp);

            return temp.item;
        }
    }
}
