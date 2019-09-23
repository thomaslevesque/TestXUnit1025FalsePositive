using Xunit;

namespace TestXUnit1025FalsePositive
{
    public class UnitTest1
    {
        [Theory]
        // Match
        [InlineData(3, new[] { 1, 2, 3, 3, 2, 3, 1 }, new[] { 2, 3 }, new[] { 1, 2, 3, 3, 1 })]
        [InlineData(3, new[] { 1, 2, 3, 3, 2, 3, 1 }, new[] { 1, 2, 3 }, new[] { 3, 2, 3, 1 })]
        [InlineData(3, new[] { 1, 2, 3, 3, 2, 3, 1 }, new[] { 3 }, new[] { 1, 2, 3, 3, 2, 1 })]
        [InlineData(3, new[] { 1, 2, 3, 3, 2, 3, 1 }, new[] { 3, 3, 2 }, new[] { 1, 2, 3, 1 })]
        [InlineData(3, new[] { 1, 2, 3, 3, 2, 3, 1 }, new[] { 3, 1 }, new[] { 1, 2, 3, 3, 2 })]
        [InlineData(3, new[] { 1, 2, 3, 3, 2, 3, 1 }, new[] { 1, 2, 3, 3, 2 }, new[] { 3, 1 })]
        // No match
        [InlineData(4, new[] { 1, 2, 3, 3, 2, 3, 1 }, new[] { 4 }, new[] { 1, 2, 3, 3, 2, 3, 1 })]
        [InlineData(3, new[] { 1, 2, 3, 3, 2, 3, 1 }, new[] { 3, 3, 3 }, new[] { 1, 2, 3, 3, 2, 3, 1 })]
        [InlineData(3, new[] { 1, 2, 3, 3, 2, 3, 1 }, new[] { 3, 2, 1 }, new[] { 1, 2, 3, 3, 2, 3, 1 })]
        public void Test(int count, int[] x, int[] y, int[] z)
        {
            // Just to suppress xUnit1026 (unused parameters)
            // The content of the test doesn't actually matter
            Assert.NotEqual(0, count);
            Assert.NotNull(x);
            Assert.NotNull(y);
            Assert.NotNull(z);
        }
    }
}
