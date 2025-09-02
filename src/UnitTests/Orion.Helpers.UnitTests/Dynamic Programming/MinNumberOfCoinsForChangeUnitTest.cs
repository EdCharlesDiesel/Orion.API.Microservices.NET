using _Main_;
using Microsoft.VisualBasic.CompilerServices;

namespace Orion.Helpers.UnitTests.Dynamic_Programming
{
    public class MinNumberOfCoinsForChangeUnitTest
    {
        [Fact(Skip = "Fix this")    ]
        public void Test1()
        {
            int[] input = { 1, 5, 10 };
            Assert.True(_Go__.MinNumberOfCoinsForChange(7, input) == 3);
        }
    }
}