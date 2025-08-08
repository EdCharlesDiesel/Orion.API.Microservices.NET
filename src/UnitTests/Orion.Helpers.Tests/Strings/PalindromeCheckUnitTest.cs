namespace Orion.Helpers.Tests.Strings
{
    public class PalindromeCheckClassUnitTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(PalindromeCheckClass.IsPalindrome("abcdcba"));
        }
    }
}