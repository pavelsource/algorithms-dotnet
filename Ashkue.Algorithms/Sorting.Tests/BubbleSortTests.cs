using Xunit;

namespace Ashkue.Algorithms.Sorting.Tests
{
    public class BubbleSortTests
    {
        [Theory]
        [MemberData(nameof(BaseDataProvider.TestData), MemberType = typeof(BaseDataProvider))]
        public void SortProvider_SortMethod_ArraysSorted(int[] actual, int[] expected)
        {
            // setup
            var sortProvider = new BubbleSort();

            // act
            sortProvider.Sort(actual);

            // assert
            Assert.Equal(actual, expected);
        }
    }
}
