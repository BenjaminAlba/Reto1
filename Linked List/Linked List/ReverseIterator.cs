using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    public class ReverseIterator
    {
        private Node currentNode;

        public ReverseIterator(Node currentNode)
        {
            this.currentNode = currentNode;
        }

        public ReverseIterator(ReverseIterator ReverseIterator)
        {
            currentNode = ReverseIterator.currentNode;
        }

        public bool hasNext()
        {
            return currentNode != null;
        }

        public int next()
        {
            int data = currentNode.getData();

            currentNode = currentNode.getPrevious();

            return data;
        }

        Node getCurrentNode()
        {
            return currentNode;
        }
    }
}
