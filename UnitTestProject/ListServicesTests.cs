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
        private readonly List<long> numbers;

        public ListServicesTests()
        {
            _listService = DependencyInjection.Setup().GetService<IListService>();
            numbers = new List<long> { 1, 2, 4, 5, 6, 7 };
        }

        [TestMethod]
        public void Test11_WhatIsTheDiffBetweenIntsAndSubSet_AllValuesInIntsThatAreNotInSubSet()
        {
            var subSet = new List<long> { 1, 5 };
            var remains = _listService.Difference(numbers, subSet);
            
            Assert.IsTrue(remains.SequenceEqual(new List<long> { 2, 4, 6, 7 }));
        }

        [TestMethod]
        public void Test10_ReverseOrderOfElements()
        {
            var revs = _listService.Reverse(numbers);
            
            Assert.IsTrue(revs.SequenceEqual(new List<long> { 7, 6, 5, 4, 2, 1 }));
        }

        [TestMethod]
        public void Test9_ReplaceEachIntWithSumOfPreviousAndNextValueIfAny()
        {
            var sums = _listService.AccumulateNeighbours(numbers);
            
            Assert.IsTrue(sums.SequenceEqual(new List<long> { 3, 5, 7, 10, 12, 13 }));
        }

        [TestMethod]
        public void Test8_IntsWhereNextIntIsEven()
        {
            var nexts = _listService.NextIsEven(numbers);
            
            Assert.IsTrue(nexts.SequenceEqual(new List<long> { 1, 2, 5 }));
        }

        [TestMethod]
        public void Test7_MakeOneBigIntOutOfAllTheInts()
        {
            var bigint = _listService.BigInt(numbers);
            
            Assert.AreEqual(bigint, 124567);
        }

        [TestMethod]
        public void Test6_ExcludeAllIntsLargerThan()
        {
            var smalls = _listService.RemoveLargerThan(numbers, 3);
            
            Assert.IsTrue(smalls.SequenceEqual(new List<long> { 1, 2 }));
        }

        [TestMethod]
        public void Test5_WhatIsTheValueForSpesificPosition_TheReverseOfValue()
        {
            var pos = _listService.GetPosition(numbers, 4);
            
            Assert.AreEqual(pos, 2);
        }

        [TestMethod]
        public void Test4_WhatIsTheNumberAtSpesificPosition_ListsBeginAtNumberZiro()
        {
            var value = _listService.ValueAt(numbers, 2);
            
            Assert.AreEqual(value, 4);
        }

        [TestMethod]
        public void Test3_AverageOfAllInts()
        {
            var average = _listService.Average(numbers);
            
            Assert.AreEqual(average, 4);
        }

        [TestMethod]
        public void Test2_SumOfAllInts()
        {
            var sum = _listService.Sum(numbers);
            
            Assert.AreEqual(sum, 25);
        }

        [TestMethod]
        public void Test1_HowManyIntsAreThere()
        {
            var count = _listService.Count(numbers);
            
            Assert.AreEqual(count, 6);
        }
    }
}
