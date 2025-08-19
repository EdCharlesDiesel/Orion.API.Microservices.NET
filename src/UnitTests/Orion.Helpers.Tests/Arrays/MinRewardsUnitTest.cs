using Orion.Helpers.Arrays;

namespace Orion.Helpers.Tests.Arrays
{
    public class MinRewardsClassUnitTest
    {
        [Fact]
        public void Test1()
        {
            var input = new int[] { 8, 4, 2, 1, 3, 6, 7, 9, 5 };
            var actual = MinRewardsClass.MinRewards(input);
            var expected = 25;
            Assert.Equal(expected, actual);
        }
    }
}