using System;
using System.Collections.Generic;
using System.Text;

namespace Week2BlessingEtok
{
    public class Node <T>
    {
        private T data;
        private Node <T> address;

        public Node(T d)
        {
            this.data = d;
            this.address = null;
        }

        public T Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public Node<T> Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
         
    }
}
