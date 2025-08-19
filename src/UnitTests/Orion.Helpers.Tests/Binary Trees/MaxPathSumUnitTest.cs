using Microsoft.VisualBasic.CompilerServices;

namespace Orion.Helpers.Tests.Binary_Trees
{
    public class MaxPathSumUnitTest
    {
        [Fact(Skip ="Fix this")]
        public void Test1()
        {
            TestBinaryTree test = new TestBinaryTree(1);
            test.insert(new[] { 2, 3, 4, 5, 6, 7 }, 0);
            Utils.AssertTrue(Program.MaxPathSum(test) == 18);
        }

        public class TestBinaryTree : Program.BinaryTree
        {
            public TestBinaryTree(int value) : base(value) { }

            public void insert(int[] values, int i)
            {
                if (i >= values.Length)
                {
                    return;
                }
                List<Program.BinaryTree> queue = new List<Program.BinaryTree>();
                queue.Add(this);
                var index = 0;
                while (index < queue.Count)
                {
                    Program.BinaryTree current = queue[index];
                    index += 1;
                    if (current.left == null)
                    {
                        current.left = new Program.BinaryTree(values[i]);
                        break;
                    }
                    queue.Add(current.left);
                    if (current.right == null)
                    {
                        current.right = new Program.BinaryTree(values[i]);
                        break;
                    }
                    queue.Add(current.right);
                }
                insert(values, i + 1);
            }
        }
    }
}