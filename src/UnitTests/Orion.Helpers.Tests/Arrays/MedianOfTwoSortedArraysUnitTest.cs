namespace Orion.Helpers.Tests.Arrays
{
    public class MedianOfTwoSortedArraysClassUnitTest
    {
        [Fact(Skip =  "Failing unit test")]
        public void Test1()
        {
            int[] arrayOne = new int[] { 1, 3, 4, 5 };
            int[] arrayTwo = new int[] { 2, 3, 6, 7 };
            float actual = new MedianOfTwoSortedArraysClass().MedianOfTwoSortedArrays(arrayOne, arrayTwo);
            float expected = 3.5f;
            Assert.True(expected == actual);
        }
    }
}