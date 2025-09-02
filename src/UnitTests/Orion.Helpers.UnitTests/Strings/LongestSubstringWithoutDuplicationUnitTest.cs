using Orion.Helpers.Strings;

namespace Orion.Helpers.UnitTests.Strings
{
    public class LongestSubstringWithoutDuplicationClassUnitTest
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(LongestSubstringWithoutDuplicationClass.LongestSubstringWithoutDuplication("clementisacap")
, "mentisac");
        }
    }
}