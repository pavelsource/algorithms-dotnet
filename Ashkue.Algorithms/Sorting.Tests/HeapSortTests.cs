using Xunit;

namespace Ashkue.Algorithms.Sorting.Tests
{
    public class HeapSortTests
    {
        [Theory]
        [MemberData(nameof(BaseDataProvider.SortArrayTestData), MemberType = typeof(BaseDataProvider))]
        public void SortProvider_SortMethod_ArraysSorted(int[] actual, int[] expected)
        {
            // setup
            var sortProvider = new HeapSort();

            // act
            sortProvider.Sort(actual);

            // assert
            Assert.Equal(actual, expected);
        }
    }
}
