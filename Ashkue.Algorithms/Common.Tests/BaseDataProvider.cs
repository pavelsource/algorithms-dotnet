using System.Collections.Generic;

namespace Ashkue.Algorithms.Common.Tests
{
    public static class BaseDataProvider
    {
        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[2] { -100, "N/A" };
                yield return new object[2] { 1, "0" };
                yield return new object[2] { 2, "0 1" };
                yield return new object[2] { 3, "0 1 1" };
                yield return new object[2] { 5, "0 1 1 2 3" };
                yield return new object[2] { 8, "0 1 1 2 3 5 8 13" };
                yield return new object[2] { 10, "0 1 1 2 3 5 8 13 21 34" };
                yield return new object[2] { 25, "0 1 1 2 3 5 8 13 21 34 55 89 144 233 377 610 987 1597 2584 4181 6765 10946 17711 28657 46368" };
                yield return new object[2] { 1001, "N/A" };
            }
        }
    }
}
