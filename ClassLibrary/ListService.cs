using System.Collections.Generic;

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
            var result = 0;
            return result;
        }

        public int Sum(List<int> numbers)
        {
            int result = 0;
            return result;
        }

        public int Average(List<int> numbers)
        {
            int result = 0;
            return result;
        }

        public int ValueAt(List<int> numbers, int pos)
        {
            int result = 0;
            return result;
        }

        public int GetPosition(List<int> numbers, int value)
        {
            int result = 0;
            return result;
        }

        public List<int> RemoveLargerThan(List<int> numbers, int minValue)
        {
            List<int> result = new List<int>();
            return result;
        }

        public int BigInt(List<int> numbers)
        {
            int result = 0;
            return result;
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
            List<int> result = new List<int>();
            return result;
        }

        public List<int> Difference(List<int> numbers, List<int> subSet)
        {
            List<int> result = new List<int>();
            return result;
        }
    }
}
