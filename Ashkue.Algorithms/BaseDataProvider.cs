using System;
using System.Collections.Generic;
using System.Linq;

namespace Ashkue.Algorithms
{
    public static class BaseDataProvider
    {
        public static IEnumerable<object[]> FibonacciTestData
        {
            get
            {
                yield return new object[2] { -100, "N/A" };
                yield return new object[2] { 1, "1" };
                yield return new object[2] { 2, "0 1" };
                yield return new object[2] { 3, "0 1 1" };
                yield return new object[2] { 5, "0 1 1 2 3" };
                yield return new object[2] { 8, "0 1 1 2 3 5 8 13" };
                yield return new object[2] { 10, "0 1 1 2 3 5 8 13 21 34" };
                yield return new object[2] { 25, "0 1 1 2 3 5 8 13 21 34 55 89 144 233 377 610 987 1597 2584 4181 6765 10946 17711 28657 46368" };
                yield return new object[2] { 1001, "N/A" };
            }
        }

        public static IEnumerable<object[]> SortArrayTestData
        {
            get
            {
                yield return new object[2] { new[] { 5, 30 }, new[] { 5, 30 } };
                yield return new object[2] { new[] { -5, -30, -7 }, new[] { -30, -7, -5 } };
                yield return new object[2] { new[] { 5, 30, 7, 0, -10 }, new[] { -10, 0, 5, 7, 30 } };
                yield return new object[2] { new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 } };
                yield return new object[2] { new[] { 5, 4, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5 } };
                yield return new object[2] { new[] { 5, 30, 7, 0, -10, 100, 1, -5 }, new[] { -10, -5, 0, 1, 5, 7, 30, 100 } };
                yield return new object[2] { new[] { 5, 30, 7, 0, -10, 100, 1, -5, -4, -3 }, new[] { -10, -5, -4, -3, 0, 1, 5, 7, 30, 100 } };
                yield return new object[2] { new[] { 5, 10, 10, 5, 5, 10, 1, 1, 1 }, new[] { 1, 1, 1, 5, 5, 5, 10, 10, 10 } };
                yield return new object[2] { new[] { 5 }, new[] { 5 } };
                yield return new object[2] { new int[0], new int[0] };

                // generate very long array
                var longArraySorted = Enumerable.Range(-5000, 10000).ToArray();
                var longArrayMixed = longArraySorted.OrderBy(c => Guid.NewGuid()).ToArray();
                yield return new object[2] { longArrayMixed, longArraySorted };
            }
        }

        public static IEnumerable<object[]> ReverseArrayTestData
        {
            get
            {
                yield return new object[2] { null, null };
                yield return new object[2] { new int[0], new int[0] };
                yield return new object[2] { new[] { 1 }, new[] { 1 } };
                yield return new object[2] { new[] { 1, 2 }, new[] { 2, 1 } };
                yield return new object[2] { new[] { 1, 2, 3 }, new[] { 3, 2, 1 } };
                yield return new object[2] { new[] { -3, -2, -1, 0, 1, 2, 3 }, new[] { 3, 2, 1, 0, -1, -2, -3 } };

                // generate very long array
                var longArrayOriginal = Enumerable.Range(-10000, 10000).ToArray();
                var longArrayReversed = longArrayOriginal.Reverse().ToArray();
                yield return new object[2] { longArrayOriginal, longArrayReversed };
            }
        }
    }
}
