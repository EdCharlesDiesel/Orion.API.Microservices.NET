using _Main_;

namespace Orion.Helpers.UnitTests.LinkedList
{
    public partial class UnitTest1
    {
        [Fact(Skip = "Fix later")   ]
        public void Test1()
        {
            void TestCase1()
            {
                _Go__.LinkedList test = newLinkedList(new int[] { 0, 1, 2, 3, 4, 5 });
                List<int> result = toList(_Go__.ReverseLinkedList(test));
                int[] expected = new int[] { 5, 4, 3, 2, 1, 0 };
                Assert.True(arraysEqual(result, expected));
            }

            _Go__.LinkedList newLinkedList(int[] values)
            {
                _Go__.LinkedList ll = new _Go__.LinkedList(values[0]);
                _Go__.LinkedList current = ll;
                for (int i = 1; i < values.Length; i++)
                {
                    current.Next = new _Go__.LinkedList(values[i]);
                    current = current.Next;
                }
                return ll;
            }

            List<int> toList(_Go__.LinkedList ll)
            {
                List<int> arr = new List<int>();
                _Go__.LinkedList current = ll;
                while (current != null)
                {
                    arr.Add(current.Value);
                    current = current.Next;
                }
                return arr;
            }

            bool arraysEqual(List<int> arr1, int[] arr2)
            {
                if (arr1.Count != arr2.Length) return false;
                for (int i = 0; i < arr1.Count; i++)
                {
                    if (arr1[i] != arr2[i]) return false;
                }
                return true;
            }
        }
    }
    
}