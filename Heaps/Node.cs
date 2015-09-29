using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    public class Node<T>
    {
        T data;
        Node<T> leftChild;
        Node<T> rightChild;

        public Node<T> LeftChild
        {
            get { return leftChild; }
            set { leftChild = value; }
        }
        
        public Node<T> RightChild
        {
            get { return rightChild; }
            set { rightChild = value; }
        }


        public void AddRightChild(Node<T> node)
        {
            this.rightChild = node;
        }

        public void AddLeftChild(Node<T> node)
        {
            this.leftChild = node;
        }

        public Node<T> GetRightChild()
        {
            return this.rightChild;
        }

        public Node<T> GetLeftChild()
        {
            return this.leftChild;
        }


        public List<Node<T>> AllGetSiblings()
        {
            return null;
        }

    }
}
