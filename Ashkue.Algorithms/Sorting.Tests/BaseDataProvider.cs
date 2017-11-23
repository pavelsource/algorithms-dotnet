using System;
using System.Collections.Generic;
using System.Linq;

namespace Ashkue.Algorithms.Sorting.Tests
{
    public static class BaseDataProvider
    {
        public static IEnumerable<object[]> TestData
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
    }
}
