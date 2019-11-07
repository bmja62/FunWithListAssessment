using ClassLibrary;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        private static readonly IListService _listService;
        private static readonly List<long> numbers;

        static Program()
        {
            _listService = DependencyInjection.Setup().GetService<IListService>();
            numbers = new List<long> { 1, 2, 4, 5, 6, 7 };
        }

        static void Main()
        {
            Console.WriteLine("The list Contains: {0}", string.Join(" ", numbers));

            Console.WriteLine("\n1.How many ints are there? {0}", _listService.Count(numbers));

            Console.WriteLine("\n2.Sum of all ints? {0}", _listService.Sum(numbers));

            Console.WriteLine("\n3.Average of all ints? {0}", _listService.Average(numbers));

            Console.WriteLine("\n4.What is the number at position 2? {0}", _listService.ValueAt(numbers, 2));

            Console.WriteLine("\n5.What is the position for 4? {0}", _listService.GetPosition(numbers, 4));

            Console.WriteLine("\n6.Exclude all ints larger than 3? {0}", string.Join(" ", _listService.RemoveLargerThan(numbers, 3)));

            Console.WriteLine("\n7.Make one big int out of all the ints? {0}", _listService.BigInt(numbers));

            Console.WriteLine("\n8.Ints where next int is even? {0}", string.Join(" ", _listService.NextIsEven(numbers)));

            Console.WriteLine("\n9.Replace each int with sum of previous and next value? {0}", string.Join(" ", _listService.NextIsEven(numbers)));

            Console.WriteLine("\n10.Reverse order of elements? {0}", string.Join(" ", _listService.Reverse(numbers)));

            Console.WriteLine("\n11.What is the diff between ints and subSet? {0}", string.Join(" ", _listService.Difference(numbers, new List<long> { 1, 5 })));

            Console.ReadKey();
        }
    }
}
