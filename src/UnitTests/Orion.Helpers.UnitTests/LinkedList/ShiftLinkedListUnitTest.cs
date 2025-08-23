using _Main_;
using Microsoft.VisualBasic.CompilerServices;

namespace Orion.Helpers.UnitTests.LinkedList
{
    public partial class UnitTest1
    {
        public List<int> linkedListToArray(_Go__.LinkedList head)
        {
            var array = new List<int>();
            var current = head;
            while (current != null)
            {
                array.Add(current.value);
                current = current.next;
            }
            return array;
        }
        [Fact(Skip ="Fix later")]
        public void Test1()
        {
            var head = new _Go__.LinkedList(0);
            head.next = new _Go__.LinkedList(1);
            head.next.next = new _Go__.LinkedList(2);
            head.next.next.next = new _Go__.LinkedList(3);
            head.next.next.next.next = new _Go__.LinkedList(4);
            head.next.next.next.next.next = new _Go__.LinkedList(5);
            var result = _Go__.ShiftLinkedList(head, 2);
            var array = this.linkedListToArray(result);

            var expected = new List<int> { 4, 5, 0, 1, 2, 3 };
            Assert.True(Enumerable.SequenceEqual(expected, array));
        }
    }
}