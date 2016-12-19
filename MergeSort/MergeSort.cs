using System.Collections.Generic;

namespace MergeSort
{
    public class MergeSort
    {
        List<int> _list;
        
        public  MergeSort(IList<int> list)
        {
            Sort(list, 0, list.Count - 1);        
        }

        private void Sort(IList<int> list, int left , int right)
        {
            if (left < right)
            {
                int m = (left + right) / 2;

                Sort(list, left, m);
                Sort(list, m + 1, right);
            }
        }

        private void Merge(IList<int> list, int left, int middle, int right)
        {
            var tempLeft = new List<int>();
            var tempRight = new List<int>();

            for (int i = left; i <= middle; i++)
                tempLeft.Add(list[i]);

            for (int i = middle + 1; i < right; i++)
                tempRight.Add(list[i]);

        }
    }
}
