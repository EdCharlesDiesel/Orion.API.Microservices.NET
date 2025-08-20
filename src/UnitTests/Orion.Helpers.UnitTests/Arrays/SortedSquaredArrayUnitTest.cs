

namespace Orion.Helpers.UnitTests.Arrays
{
    public class SortedSquaredArrayUnitTest
    {
        [Fact]
        public void Test1()
        {
            var input = new[] { 1, 2, 3, 5, 6, 8, 9 };
            var expected = new[] { 1, 4, 9, 25, 36, 64, 81 };
           var actual = new SortedSquaredArray.SortedSquaredArrayClass().SortedSquaredArray(input);
            for (int i = 0; i < expected.Length; i++)
            {
              Assert.True(expected[i] == actual[i]);
            }
        }
    }

    public abstract class SortedSquaredArray
    {
        public class SortedSquaredArrayClass
        {
            public object SortedSquaredArray(int[] input)
            {
                throw new NotImplementedException();
            }
        }
    }
}