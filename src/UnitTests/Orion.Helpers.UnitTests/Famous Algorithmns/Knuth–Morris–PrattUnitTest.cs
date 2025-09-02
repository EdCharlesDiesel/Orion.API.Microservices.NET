

using Orion.Helpers.FamousAlgorithms;

namespace Orion.Helpers.UnitTests.Famous_Algorithmns
{
    public class KnuthMorrisPrattClassUnitTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(
                  KnuthMorrisPrattClass.KnuthMorrisPrattAlgorithm("aefoaefcdaefcdaed", "aefcdaed")
                );
        }
    }
}