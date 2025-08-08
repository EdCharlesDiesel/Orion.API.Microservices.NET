namespace Orion.Helpers.Tests.Strings
{
    public class LongestSubstringWithoutDuplicationClassUnitTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(LongestSubstringWithoutDuplicationClass.LongestSubstringWithoutDuplication("clementisacap")
                    .Equals("mentisac"));
        }
    }
}