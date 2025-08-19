using Orion.Helpers.Arrays;

namespace Orion.Helpers.Tests.Arrays
{
    public class ArrayOfProductsUnitTest
    {
        [Fact(Skip = "Need to look at this function")]
        public void Test1()
        {
            var input = new[] { 5, 1, 4, 2 };
            var expected = new[] { 8, 40, 10, 20 };
            int[] actual = ArrayOfProductsClass.ArrayOfProducts(input);
            Assert.True(expected.Length == actual.Length);
            for (int i = 0; i < actual.Length; i++)
            {
                Assert.True(actual[i] == expected[i]);
            }
        }
    }
}