using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algorithm.Sort;

namespace AlgorithmTests
{
    [TestClass]
    public class AlgorithmTests
    {
        [TestMethod]
        public void MergeSort_Ok()
        {
            var list = new List<int>(){30, 10 , 45 , 6 , 13 , 90, 12, 2};
            var mergeSort = new MergeSort(list);
        }
    }
}
