using _Main_;
using Microsoft.VisualBasic.CompilerServices;

namespace Orion.Helpers.UnitTests.Heaps
{
    public class MinHeapUnitTest
    {
        [Fact]
        public void Test1()
        {

        }
    }
}

_Go__.MinHeap minHeap = new _Go__.MinHeap(new List<int> { 48, 12, 24, 7, 8, -5, 24, 391, 24, 56, 2, 6, 8, 41 });
minHeap.Insert(76);
Assert.True(isMinHeapPropertySatisfied(minHeap.heap));
Assert.True(minHeap.Peek() == -5);
Assert.True(minHeap.Remove() == -5);
Assert.True(isMinHeapPropertySatisfied(minHeap.heap));
Assert.True(minHeap.Peek() == 2);
Assert.True(minHeap.Remove() == 2);
Assert.True(isMinHeapPropertySatisfied(minHeap.heap));
Assert.True(minHeap.Peek() == 6);
minHeap.Insert(87);
Assert.True(isMinHeapPropertySatisfied(minHeap.heap));
  }

  bool isMinHeapPropertySatisfied(List<int> array)
{
    for (int currentIdx = 1; currentIdx < array.Count; currentIdx++)
    {
        int parentIdx = (currentIdx - 1) / 2;
        if (parentIdx < 0)
        {
            return true;
        }
        if (array[parentIdx] > array[currentIdx])
        {
            return false;
        }
    }

    return true;
}
}