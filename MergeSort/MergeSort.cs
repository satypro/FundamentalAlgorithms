using System.Collections.Generic;

namespace Algorithm.Sort
{
    public class MergeSort
    {        
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
                Merge(list, left, m, right);
            }
        }

        private void Merge(IList<int> list, int left, int middle, int right)
        {
            var tempLeft = new List<int>();
            var tempRight = new List<int>();

            for (int i_0 = left; i_0 <= middle; i_0++)
                tempLeft.Add(list[i_0]);

            for (int i_1 = middle + 1; i_1 <= right; i_1++)
                tempRight.Add(list[i_1]);

            int leftLimit = middle - left + 1;
            int rightLimit = right - middle;

            int i = 0;
            int j = 0;
            int k = left;

            while (i < leftLimit && j < rightLimit)
            {
                if (tempLeft[i] <= tempRight[j])
                {
                    list[k] = tempLeft[i];
                    i++;
                }
                else
                {
                    list[k] = tempRight[j];
                    j++;
                }
                k++;
            }

            while(i < leftLimit)
            {
                list[k] = tempLeft[i];
                i++;
                k++;
            }

            while (j < rightLimit)
            {
                list[k] = tempRight[j];
                j++;
                k++;
            }
        }
    }
}
