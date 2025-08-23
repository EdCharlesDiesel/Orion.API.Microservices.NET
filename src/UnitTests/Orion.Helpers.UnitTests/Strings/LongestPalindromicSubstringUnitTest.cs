using Orion.Helpers.Strings;

namespace Orion.Helpers.UnitTests.Strings
{
    public class LongestPalindromicSubstringClassUnitTest
    {
        [Fact(Skip = "Fix this")]
        public void Test1()
        {
            Assert.True(
                LongestPalindromicSubstringClass.LongestPalindromicSubstring("abaxyzzyxf").Equals("xyzzyx")
            );
        }
    }
}