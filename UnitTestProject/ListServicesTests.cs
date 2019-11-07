using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class ListServicesTests
    {
        private readonly IListService _listService;
        private readonly List<int> ints;

        public ListServicesTests()
        {
            _listService = DependencyInjection.Setup().GetService<IListService>();
            ints = new List<int> { 1, 2, 4, 5, 6, 7 };
        }

        [TestMethod]
        public void Test11_WhatIsTheDiffBetweenIntsAndSubSet_AllValuesInIntsThatAreNotInSubSet()
        {
            List<int> subSet = new List<int> { 1, 5 };
            List<int> remains = _listService.Difference(ints, subSet);
            Assert.IsTrue(remains.SequenceEqual(new List<int> { 2, 4, 6, 7 }));
        }

        [TestMethod]
        public void Test10_ReverseOrderOfElements()
        {
            List<int> revs = _listService.Reverse(ints);
            Assert.IsTrue(revs.SequenceEqual(new List<int> { 7, 6, 5, 4, 2, 1 }));
        }

        [TestMethod]
        public void Test9_ReplaceEachIntWithSumOfPreviousAndNextValueIfAny()
        {
            List<int> sums = _listService.AccumulateNeighbours(ints);
            Assert.IsTrue(sums.SequenceEqual(new List<int> { 3, 5, 7, 10, 12, 13 }));
        }

        [TestMethod]
        public void Test8_IntsWhereNextIntIsEven()
        {
            List<int> nexts = _listService.NextIsEven(ints);
            Assert.IsTrue(nexts.SequenceEqual(new List<int> { 1, 2, 5 }));
        }

        [TestMethod]
        public void Test7_MakeOneBigIntOutOfAllTheInts()
        {
            int bigint = _listService.BigInt(ints);
            Assert.AreEqual(bigint, 124567);
        }

        [TestMethod]
        public void Test6_ExcludeAllIntsLargerThan()
        {
            List<int> smalls = _listService.RemoveLargerThan(ints, 3);
            Assert.IsTrue(smalls.SequenceEqual(new List<int> { 1, 2 }));
        }

        [TestMethod]
        public void Test5_WhatIsTheValueForSpesificPosition_TheReverseOfValue()
        {
            int pos = _listService.GetPosition(ints, 4);
            Assert.AreEqual(pos, 2);
        }

        [TestMethod]
        public void Test4_WhatIsTheNumberAtSpesificPosition_ListsBeginAtNumberZiro()
        {
            int value = _listService.ValueAt(ints, 2);
            Assert.AreEqual(value, 4);
        }

        [TestMethod]
        public void Test3_AverageOfAllInts()
        {
            int average = _listService.Average(ints);
            Assert.AreEqual(average, 4);
        }

        [TestMethod]
        public void Test2_SumOfAllInts()
        {
            int sum = _listService.Sum(ints);
            Assert.AreEqual(sum, 25);
        }

        [TestMethod]
        public void Test1_HowManyIntsAreThere()
        {
            int count = _listService.Count(ints);
            Assert.AreEqual(count, 6);
        }
    }
}
