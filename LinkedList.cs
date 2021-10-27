using System;
using System.Collections.Generic;
using System.Text;

namespace Week2BlessingEtok
{
    class LinkedList <T>

    {
        private Node <T> edi;
        private int size;
//this is a constructor, it usually carries the same name as the class
        public LinkedList()
        {
// no data is stored in edi yet and also there is no size

            this.edi = null;
            this.size = 0;
        }

        public int AddItem(T e)
        {
            Node <T>store = new Node<T>(e);
            if (this.size ==0)
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
            return this.size;
        }

        public bool Delete(T e)
        {
            Node<T> counter = this.edi; 
            if (counter.Data.ToString() == e.ToString())
            {
                this.edi = counter.Address;
                this.size--;
                return true;
            }
            else
            {
                for (int i = 0; i < this.size; i++)
                {
                    if (counter.Address.Data.ToString() == e.ToString())
                    {
                        counter.Address = counter.Address.Address;
                        this.size--;
                        return true;
                    }
                    else
                    {
                        counter = counter.Address;
                    }
                }
            }
            this.size--;
            return false;
        }
          //checks for a specific item in the list and return a bool
          public bool Check (T item)
        {
            Node<T> _item = this.edi;
            for(int i = 0; i<this.size; i++)
            {
                if (_item.Data.Equals(item))
                {
                    return true;
                }
                _item = _item.Address;
            }
            return false;
        }

        public int Index (T item)
        {
            Node<T> _item = this.edi;
            for ( int i = 0; i <this.size; i++)
            {
                if (_item.Data.Equals(item))
                {
                    return i;
                }
                _item = _item.Address;
            }
            return -1;
        }
        //display method to check it on the screen
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
