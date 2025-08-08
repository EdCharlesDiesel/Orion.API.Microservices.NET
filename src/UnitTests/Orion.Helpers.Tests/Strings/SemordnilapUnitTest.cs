namespace Orion.Helpers.Tests.Strings
{
    public class USemordnilapClassnitTest 
    {
        [Fact(Skip ="Failing Unit Test")]
        public void Test1()
        {
            var input = new string[] { "desserts", "stressed", "hello" };
            List<List<string>> expected = new List<List<string>>();
            List<string> pair = new List<string> { "desserts", "stressed" };
            expected.Add(pair);
            var actual = new SemordnilapClass().Semordnilap(input);
            Assert.True(expected.Count == actual.Count);
            for (var i = 0; i < expected.Count; i++)
            {
                Assert.True(Enumerable.SequenceEqual(expected[i], actual[i]));
            }
        }
    }
}