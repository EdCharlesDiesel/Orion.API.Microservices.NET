using Orion.Helpers.LinkedList;

namespace Orion.Helpers.Tests.LinkedList
{
    public partial class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            TestLinkedList test = new TestLinkedList(0);
            test.AddMany(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            test.GetNthNode(10).next = test.GetNthNode(5);
            Assert.True(FindLoopClass.FindLoop(test) == test.GetNthNode(5));
        }
    }

    public class TestLinkedList : FindLoopClass.LinkedList
    {
        public TestLinkedList(int value) : base(value) { }

        public void AddMany(int[] values)
        {
            FindLoopClass.LinkedList current = this;
            while (current.next != null)
            {
                current = current.next;
            }
            foreach (int value in values)
            {
                current.next = new FindLoopClass.LinkedList(value);
                current = current.next;
            }
        }

        public FindLoopClass.LinkedList GetNthNode(int n)
        {
            int counter = 1;
            FindLoopClass.LinkedList current = this;
            while (counter < n)
            {
                current = current.next;
                counter++;
            }
            return current;
        }
    }
}