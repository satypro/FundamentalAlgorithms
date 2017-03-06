using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm.Sort;
using System.Collections.Generic;

namespace AlgorithmTestProject
{
    [TestClass]
    public class AlgorithmTests
    {
        [TestMethod]
        public void MergeSort_Sort_List_OK()
        {
            var list = new List<int>() { 1, 10, 34, 2, 5, 7, 90, 15 };
            var result = new MergeSort(list);

            Assert.IsTrue(list[0] == 2);
            Assert.IsTrue(list[1] == 2);
            Assert.IsTrue(list[2] == 5);
            Assert.IsTrue(list[3] == 7);
            Assert.IsTrue(list[4] == 10);
            Assert.IsTrue(list[5] == 15);
            Assert.IsTrue(list[6] == 34);
            Assert.IsTrue(list[7] == 90);
        }
    }
}
