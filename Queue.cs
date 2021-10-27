using System;
using System.Collections.Generic;
using System.Text;

namespace Week2BlessingEtok
{
   public class Equeue<T>
    {
        private Node<T> edi;
        private int size;

        public Equeue()
        {
            this.edi = null;
            this.size = 0;
        }


        public bool IsEmpty()
        {
            return this.size == 0;
        }
        //Enqueue
        public void Enqueue(T e)
        {
            Node<T> store = new Node<T>(e);
            if (this.size == 0)
            {
                this.edi = store;
            }
            else
            {
                Node<T> nowNode = this.edi;
                for (int i = 0; i < this.size; i++)
                {
                    if (nowNode.Address == null)
                    {
                        nowNode.Address = store;

                    }
                    else
                    {
                        nowNode = nowNode.Address;

                    }
                }
            }
            this.size++;
            
        }

        //Dequeue

        public T Dequeue()
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

        //size
        public int Size()
        {
            return this.size;
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
