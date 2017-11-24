using Xunit;

namespace Ashkue.Algorithms.Sorting.Tests
{
    public class InsertionSortTests
    {
        [Theory]
        [MemberData(nameof(BaseDataProvider.SortArrayTestData), MemberType = typeof(BaseDataProvider))]
        public void SortProvider_SortMethod_ArraysSorted(int[] actual, int[] expected)
        {
            // setup
            var sortProvider = new InsertionSort();

            // act
            sortProvider.Sort(actual);

            // assert
            Assert.Equal(actual, expected);
        }
    }
}
