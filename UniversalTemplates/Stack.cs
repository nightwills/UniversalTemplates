using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversalTemplates
{
    public class Stack<T>
    {
        private List<T> _Items = new List<T>();
        public int Count => _Items.Count;
        public void Push(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            this._Items.Add(item);
        }
        public T Pop()
        {
            var item = this._Items.LastOrDefault();
            if (item == null)
            {
                throw new NullReferenceException("Стек пуст. Нет элементов для получения.");
            }
            this._Items.RemoveAt(this._Items.Count - 1);
            return item;
        }
        public T Peek()
        {
            var item = this._Items.LastOrDefault();
            if (item == null)
            {
                throw new NullReferenceException("Стек пуст. Нет элементов для получения.");
            }
            return item;
        }
    }
}
