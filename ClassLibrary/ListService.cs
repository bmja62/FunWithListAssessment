using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary
{
    public interface IListService
    {
        List<long> AccumulateNeighbours(List<long> numbers);
        long Average(List<long> numbers);
        long BigInt(List<long> numbers);
        long Count(List<long> numbers);
        List<long> Difference(List<long> numbers, List<long> subSet);
        long GetPosition(List<long> numbers, long value);
        List<long> NextIsEven(List<long> numbers);
        List<long> RemoveLargerThan(List<long> numbers, long minValue);
        List<long> Reverse(List<long> numbers);
        long Sum(List<long> numbers);
        long ValueAt(List<long> numbers, int pos);
    }

    public class ListService : IListService
    {
        public long Count(List<long> numbers)
        {
            return numbers.Count();
        }

        public long Sum(List<long> numbers)
        {
            return numbers.Sum();
        }

        public long Average(List<long> numbers)
        {
            return Convert.ToInt32(numbers.Average());
        }

        public long ValueAt(List<long> numbers, int pos)
        {
            return numbers[pos];
        }

        public long GetPosition(List<long> numbers, long value)
        {
            return numbers.IndexOf(value);
        }

        public List<long> RemoveLargerThan(List<long> numbers, long minValue)
        {
            var result = new List<long>();

            foreach (var item in numbers)
            {
                if (item <= minValue)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public long BigInt(List<long> numbers)
        {
            return Convert.ToInt32(string.Join("", numbers));
        }

        public List<long> NextIsEven(List<long> numbers)
        {
            var result = new List<long>();

            for (var index = 0; index < numbers.Count; index++)
            {
                if (index == numbers.Count -1)
                {
                    continue;
                }
                else if (numbers[index + 1] % 2 == 0)
                {
                    result.Add(numbers[index]);
                }
            }

            return result;
        }

        public List<long> AccumulateNeighbours(List<long> numbers)
        {
            var result = new List<long>();

            for (var index = 0; index < numbers.Count; index++)
            {
                if (index == 0)
                {
                    result.Add(numbers[index] + numbers[index + 1]);
                }
                else if (index == numbers.Count - 1)
                {
                    result.Add(numbers[index] + numbers[index - 1]);
                }
                else
                {
                    result.Add(numbers[index - 1] + numbers[index + 1]);
                }
            }

            return result;
        }

        public List<long> Reverse(List<long> numbers)
        {
            numbers.Reverse();
            return numbers;
        }

        public List<long> Difference(List<long> numbers, List<long> subSet)
        {
            return numbers.Except(subSet).ToList();
        }

    }
}
