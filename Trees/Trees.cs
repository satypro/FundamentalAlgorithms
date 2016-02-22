using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    /*Abstract Data Types for Tree*/
    public class Trees<T>
    {
        private Node<T> root;

        public Node<T> Root
        {
            get { return root; }
        }

        public void createTree() { 
        
                            
        }

        public Node<T> AddNode<T>(T data)
        {
            var node = new Node<T>();
            node.Value = data;
            node.LeftNode = null;
            node.RightNode = null;
            return node;
        }

        
    }
}
