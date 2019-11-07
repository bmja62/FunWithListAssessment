using ClassLibrary;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        private static readonly IListService _listService;
        private static readonly List<int> ints;

        static Program()
        {
            _listService = DependencyInjection.Setup().GetService<IListService>();
            ints = new List<int> { 1, 2, 4, 5, 6, 7 };
        }

        static void Main()
        {
            Console.WriteLine("1. how many ints are there? {0}", _listService.Count(ints));

            Console.WriteLine("2. sum of all ints? {0}", _listService.Sum(ints));

            Console.WriteLine("3. average of all ints? {0}", _listService.Average(ints));

            Console.WriteLine("4. what is the number at position 2? {0}", _listService.ValueAt(ints, 2));

            Console.WriteLine("5. What is the position for 4? {0}", _listService.GetPosition(ints, 4));

            Console.WriteLine("6. exclude all ints larger than 3? {0}", _listService.RemoveLargerThan(ints, 3));

            Console.WriteLine("7. make one big int out of all the ints? {0}", _listService.BigInt(ints));

            Console.WriteLine("8. ints where next int is even? {0}", _listService.NextIsEven(ints));

            Console.WriteLine("9. replace each int with sum of previous and next value? {0}", _listService.NextIsEven(ints));

            Console.WriteLine("10. Reverse order of elements? {0}", _listService.Reverse(ints));

            Console.WriteLine("11. what is the diff between ints and subSet? {0}", _listService.Difference(ints, new List<int> { 1, 5 }));

            Console.ReadKey();
        }
    }
}
