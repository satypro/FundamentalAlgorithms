using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    public class Node
    {
        public Node[] CharList = new Node[26];
        public bool IsLeaf = false;
    }
}
