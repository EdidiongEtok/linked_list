using System;
using System.Collections.Generic;
using System.Text;

namespace Week2BlessingEtok
{
    class Estack <T>
    {
        private Node <T> edi;
        private int size;

        public Estack()
        {
            this.edi = null;
            this.size = 0;
        }
        // empty
        public bool IsEmpty()
        {
            return this.size == 0;
        }


        // add item
        public void Push(T item)
        {
            Node<T> _item = new Node<T>(item);
            _item.Address = this.edi;
            this.edi = _item;
            this.size++;
        }
       // return size
        public int Size()
        {
            return this.size;
        }
        //peek the end
        public T Peek (T item)
        {
            if (this.size != 0)
            {
                return this.edi.Data;
            }
            else
            {
                throw new Exception("can't peek an empty stack");
            }
        }
        // pop
        public T pop()
        {
            if (this.size != 0)
            {
                Node<T> oldEdi = this.edi;
                this.edi = this.edi.Address;
                this.size--;
                return oldEdi.Data;
            }
            else
            {
                throw new Exception("Cant't pop an empty stack");
            }
        }
        // add display
        public void Display()
        {
            Node<T> counter = this.edi;
            while (counter != null)
            {
                Console.WriteLine(counter.Data);
                counter = counter.Address;
            }
        }
    }
}
