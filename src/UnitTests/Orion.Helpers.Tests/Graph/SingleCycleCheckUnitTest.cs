using Orion.Helpers.Graphs;

namespace Orion.Helpers.Tests.Graph
{
    public class SingleCycleCheckClassUnitTest
    {
        [Fact]
        public void Test1()
        {
           Assert.True(SingleCycleCheckClass.HasSingleCycle(new int[] { 2, 3, 1, -4, -4, 2 }));
        }
    }
}