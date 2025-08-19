using Microsoft.VisualBasic.CompilerServices;
using Orion.Helpers.Arrays;

namespace Orion.Helpers.Tests.Arrays
{
    public class FourNumberSumClassUnitTest
    {
        [Fact]
        public void Test1()
        {
            List<int[]> output =
              FourNumberSumClass.FourNumberSum(new[] { 7, 6, 4, -1, 1, 2 }, 16);
            List<int[]> quadruplets = new List<int[]>();
            quadruplets.Add(new[] { 7, 6, 4, -1 });
            quadruplets.Add(new[] { 7, 6, 1, 2 });
            Assert.True(quadruplets.Count == output.Count);
            Assert.True(compare(quadruplets, output));
        }

        private bool compare(List<int[]> quads1, List<int[]> quads2)
        {
            foreach (int[] quad in quads2)
            {
                Array.Sort(quad);
            }
            foreach (int[] quad in quads1)
            {
                Array.Sort(quad);
            }
            foreach (int[] quad2 in quads2)
            {
                bool found = false;
                foreach (int[] quad1 in quads1)
                {
                    if (quad2.SequenceEqual(quad1))
                    {
                        found = true;
                        break;
                    }
                }
                if (found == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}



[Test]
public void TestCase1()
{
    List<int[]> output =
      Program.FourNumberSum(new[] { 7, 6, 4, -1, 1, 2 }, 16);
    List<int[]> quadruplets = new List<int[]>();
    quadruplets.Add(new[] { 7, 6, 4, -1 });
    quadruplets.Add(new[] { 7, 6, 1, 2 });
    Utils.AssertTrue(quadruplets.Count == output.Count);
    Utils.AssertTrue(this.compare(quadruplets, output));
}