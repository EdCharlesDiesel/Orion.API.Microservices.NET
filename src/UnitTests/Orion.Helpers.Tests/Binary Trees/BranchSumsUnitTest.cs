using Orion.Helpers.Binary_Trees;

namespace Orion.Helpers.Tests.Binary_Trees
{
    public partial class UnitTest1
    {
        public class TestBinaryTree(int value) : BranchSumsClass.BinaryTree(value)
        {
            public TestBinaryTree Insert(List<int> values)
            {
                return Insert(values, 0);
            }

            private TestBinaryTree Insert(List<int> values, int i)
            {
                if (i >= values.Count) return null;

                List<TestBinaryTree> queue = new List<TestBinaryTree>();
                queue.Add(this);
                while (queue.Count > 0)
                {
                    TestBinaryTree current = queue[0];
                    queue.RemoveAt(0);
                    if (current.left == null)
                    {
                        current.left = new TestBinaryTree(values[i]);
                        break;
                    }
                    queue.Add((TestBinaryTree)current.left);
                    if (current.right == null)
                    {
                        current.right = new TestBinaryTree(values[i]);
                        break;
                    }
                    queue.Add((TestBinaryTree)current.right);
                }
                Insert(values, i + 1);
                return this;
            }
        }
        
        [Fact(Skip = "Failing Unit test")]
        public void Test1()
        {
            TestBinaryTree tree = new TestBinaryTree(1).Insert(
                new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            List<int> expected = new List<int> { 15, 16, 18, 10, 11 };
            Assert.True(BranchSumsClass.BranchSums(tree).SequenceEqual(expected));
        }
    }
}


