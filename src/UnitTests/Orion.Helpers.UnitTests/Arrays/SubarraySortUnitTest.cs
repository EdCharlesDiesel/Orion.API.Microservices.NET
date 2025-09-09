using Orion.Helpers.Arrays;

namespace Orion.Helpers.UnitTests.Arrays
{
    public class SubarraySortUnitTest
    {
        [Fact]
        public void Test1()
        {
            int[] expected = { 3, 9 };
            Assert.True(Enumerable.SequenceEqual(
                (
                new[] { 1, 2, 4, 7, 10, 11, 7, 12, 6, 7, 16, 18, 19 }
              ),
              expected
            ));
        }
    }
}