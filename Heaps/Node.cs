using System.Collections.Generic;

namespace Heaps
{
    public class Node<T>
    {
        T _data;
        Node<T> _leftChild;
        Node<T> _rightChild;

        public Node<T> LeftChild
        {
            get { return _leftChild; }
            set { _leftChild = value; }
        }
        
        public Node<T> RightChild
        {
            get { return _rightChild; }
            set { _rightChild = value; }
        }


        public void AddRightChild(Node<T> node)
        {
            _rightChild = node;
        }

        public void AddLeftChild(Node<T> node)
        {
            _leftChild = node;
        }

        public Node<T> GetRightChild()
        {
            return _rightChild;
        }

        public Node<T> GetLeftChild()
        {
            return _leftChild;
        }

        public T GetData()
        {
            return _data;
        }

        public void SetData(T data)
        {
            _data = data;
        }

        public List<Node<T>> AllGetSiblings()
        {
            return null;
        }
    }
}
