using _Main_;
using Microsoft.VisualBasic.CompilerServices;

namespace Orion.Helpers.UnitTests.Binary_Trees
{
    public class MaxPathSumUnitTest
    {
        [Fact(Skip ="Fix this")]
        public void Test1()
        {
            TestBinaryTree test = new TestBinaryTree(1);
            test.Insert(new[] { 2, 3, 4, 5, 6, 7 }, 0);
            Assert.True(_Go__.MaxPathSum(test) == 18);
        }

        public class TestBinaryTree : _Go__.BinaryTree
        {
            public TestBinaryTree(int value) : base(value) { }

            public void Insert(int[] values, int i)
            {
                if (i >= values.Length)
                {
                    return;
                }
                List<_Go__.BinaryTree> queue = new List<_Go__.BinaryTree>();
                queue.Add(this);
                var index = 0;
                while (index < queue.Count)
                {
                    _Go__.BinaryTree current = queue[index];
                    index += 1;
                    if (current.left == null)
                    {
                        current.left = new _Go__.BinaryTree(values[i]);
                        break;
                    }
                    queue.Add(current.left);
                    if (current.right == null)
                    {
                        current.right = new _Go__.BinaryTree(values[i]);
                        break;
                    }
                    queue.Add(current.right);
                }
                Insert(values, i + 1);
            }
        }
    }
}