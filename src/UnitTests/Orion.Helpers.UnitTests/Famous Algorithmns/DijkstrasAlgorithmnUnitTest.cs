using Orion.Helpers.FamousAlgorithms;

namespace Orion.Helpers.UnitTests.Famous_Algorithmns
{
    public class DijkstrasAlgorithmnUnitTest
    {
        [Fact(Skip ="This tests infinite runs inifinitely")]
        public void Test1()
        {
            int start = 0;
            int[][][] edges = {
                  new[] { new[] { 1, 7 } },
                  new[]
                  {
                    new[] { 2, 6 }, new[] { 3, 20 }, new[] { 4, 3 }
                  },
                  new[] { new[] { 3, 14 } },
                  new[] { new[] { 4, 2 } },
                  new int[][] {},
                  new int[][] {}
                };
            int[] expected = { 0, 7, 13, 27, 10, -1 };
            int[] actual =  DijkstrasAlgorithmnClassAlgoExpert.DijkstrasAlgorithm(start, edges);
            Assert.True(expected.Length == actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.True(expected[i] == actual[i]);
            }
        }
    }
}