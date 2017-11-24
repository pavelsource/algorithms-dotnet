using Xunit;

namespace Ashkue.Algorithms.Common.Tests
{
    public class FibonacciRecursiveTests
    {
        [Theory]
        [MemberData(nameof(BaseDataProvider.FibonacciTestData), MemberType = typeof(BaseDataProvider))]
        public void FibonacciProvider_DisplayNumbersMethod_ArraysSorted(int n, string expected)
        {
            // setup
            var provider = new FibonacciRecursive();

            // act
            var actual = provider.DisplayNumbers(n);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
