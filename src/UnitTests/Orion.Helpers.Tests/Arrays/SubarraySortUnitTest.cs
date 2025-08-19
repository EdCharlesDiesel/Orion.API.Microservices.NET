using Microsoft.VisualBasic.CompilerServices;

namespace Orion.Helpers.Tests.Arrays
{
    public class SubarraySortUnitTest
    {
        [Fact]
        public void Test1()
        {
            int[] expected = { 3, 9 };
            Utils.AssertTrue(Enumerable.SequenceEqual(
              SubarraySort(
                new int[] { 1, 2, 4, 7, 10, 11, 7, 12, 6, 7, 16, 18, 19 }
              ),
              expected
            ));
        }
    }
}