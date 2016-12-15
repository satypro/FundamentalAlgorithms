using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    public class Trie
    {
        public static int char_to_index(char c)
        {
            return ((int)c - (int)'a');
        }

        public static void Insert(Node root, string word)
        {
            if (String.IsNullOrWhiteSpace(word))
                return;

            int index;
            var crawler = root;

            for (int level = 0; level < word.Length; level++)
            {
                index = char_to_index(word[level]);
                if (crawler.CharList[index] == null)
                    crawler.CharList[index] = new Node();

                crawler = crawler.CharList[index];
            }
            crawler.IsLeaf = true;
        }

        public static bool Search(Node root, string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return false;

            int index;
            var crawler = root;

            for (int i = 0; i < word.Length; i++)
            {
                index = char_to_index(word[i]);
                if (crawler.CharList[index] == null)
                    return false;
                crawler = crawler.CharList[index];
            }

            return (crawler != null && crawler.IsLeaf);
        }
    }
}
