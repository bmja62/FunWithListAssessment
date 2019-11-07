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
        public void TestMethod1()
        {
            // 1. how many ints are there?
            int count = _listService.Count(ints);
            Assert.AreEqual(count , 6);

            // 2. sum of all ints
            int sum = _listService.Sum(ints);
            Assert.AreEqual(sum , 25);

            // 3. average of all ints
            int average = _listService.Average(ints);
            Assert.AreEqual(average , 4);

            // 4. what is the number at position 2 (lists begin at number 0)
            int value = _listService.ValueAt(ints, 2);
            Assert.AreEqual(value , 4);

            // 5. What is the position for 4? (the reverse of ValueAt())
            int pos = _listService.GetPosition(ints, 4);
            Assert.AreEqual(pos , 2);

            // 6. exclude all ints larger than 3
            List<int> smalls = _listService.RemoveLargerThan(ints, 3);
            Assert.IsTrue(smalls.SequenceEqual(new List<int> { 1, 2 })); ;

            // 7. make one big int out of all the ints
            int bigint = _listService.BigInt(ints);
            Assert.AreEqual(bigint , 124567);

            // 8. ints where next int is even
            List<int> nexts = _listService.NextIsEven(ints);
            Assert.IsTrue(nexts.SequenceEqual(new List<int> { 1, 2, 5 }));

            // 9. replace each int with sum of previous and next value (if any)
            List<int> sums = _listService.AccumulateNeighbours(ints);
            Assert.IsTrue(sums.SequenceEqual(new List<int> { 3, 5, 7, 10, 12, 13 }));

            // 10. Reverse order of elements
            List<int> revs = _listService.Reverse(ints);
            Assert.IsTrue(revs.SequenceEqual(new List<int> { 7, 6, 5, 4, 2, 1 }));

            // 11. what is the diff between ints and subSet (all values in ints that are not in subSet)
            List<int> subSet = new List<int> { 1, 5 };
            List<int> remains = _listService.Difference(ints, subSet);
            Assert.IsTrue(remains.SequenceEqual(new List<int> { 2, 4, 6, 7 }));
        }
    }
}
