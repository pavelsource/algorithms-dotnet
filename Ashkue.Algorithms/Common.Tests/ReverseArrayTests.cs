using Xunit;

namespace Ashkue.Algorithms.Common.Tests
{
    public class ReverseArrayTests
    {
        [Theory]
        [MemberData(nameof(BaseDataProvider.ReverseArrayTestData), MemberType = typeof(BaseDataProvider))]
        public void ReverseArrayProvider_ExecuteMethod_ArraysReversed(int[] actual, int[] expected)
        {
            // setup
            var provider = new ReverseArray();

            // act
            provider.Execute(actual);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
