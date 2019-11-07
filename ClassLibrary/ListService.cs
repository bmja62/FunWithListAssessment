﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary
{
    public interface IListService
    {
        List<int> AccumulateNeighbours(List<int> numbers);
        int Average(List<int> numbers);
        int BigInt(List<int> numbers);
        int Count(List<int> numbers);
        List<int> Difference(List<int> numbers, List<int> subSet);
        int GetPosition(List<int> numbers, int value);
        List<int> NextIsEven(List<int> numbers);
        List<int> RemoveLargerThan(List<int> numbers, int minValue);
        List<int> Reverse(List<int> numbers);
        int Sum(List<int> numbers);
        int ValueAt(List<int> numbers, int pos);
    }

    public class ListService : IListService
    {
        public int Count(List<int> numbers)
        {
            return numbers.Count();
        }

        public int Sum(List<int> numbers)
        {
            return numbers.Sum();
        }

        public int Average(List<int> numbers)
        {
            return Convert.ToInt32(numbers.Average());
        }

        public int ValueAt(List<int> numbers, int pos)
        {
            return numbers[pos];
        }

        public int GetPosition(List<int> numbers, int value)
        {
            return numbers.IndexOf(value);
        }

        public List<int> RemoveLargerThan(List<int> numbers, int minValue)
        {
            var result = new List<int>();

            foreach (var item in numbers)
            {
                if (item <= minValue)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public int BigInt(List<int> numbers)
        {
            return Convert.ToInt32(string.Join("", numbers));
        }

        public List<int> NextIsEven(List<int> numbers)
        {
            List<int> result = new List<int>();
            return result;
        }

        public List<int> AccumulateNeighbours(List<int> numbers)
        {
            List<int> result = new List<int>();
            return result;
        }

        public List<int> Reverse(List<int> numbers)
        {
            numbers.Reverse();
            return numbers;
        }

        public List<int> Difference(List<int> numbers, List<int> subSet)
        {
            return numbers.Except(subSet).ToList();
        }
    }
}
