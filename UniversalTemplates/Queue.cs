using System;

namespace UniversalTemplates
{   
    public class Queue<T>
    {
        private int Head = -1;
        private int Rear = -1;
        private int Count = 0;
        private readonly int Size;
        private readonly T[] Array;
        public Queue(int Size)
        {
            this.Size = Size;
            this.Array = new T[Size];
        }
        public bool IsFull()
        {
            return this.Rear == this.Size - 1;
        }
        public bool IsEmpty()
        {
            return this.Count == 0;
        }
        public void Add(T Item)
        {
            if (this.IsFull())
                throw new Exception("Очередь полностью заполнена.");
            this.Array[++this.Rear] = Item;
            this.Count++;
        }
        public T Get()
        {
            if (this.IsEmpty())
                throw new Exception("Очередь не заполнена.");
            T value = this.Array[++this.Head];
            this.Count--;
            if (this.Head == this.Rear)
            {
                this.Head = -1;
                this.Rear = -1;
            }
            return value;
        }
    }
}
