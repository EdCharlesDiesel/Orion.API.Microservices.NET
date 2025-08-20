using Orion.Helpers.Binary_Trees;

namespace Orion.Helpers.UnitTests.Binary_Trees
{
    public class AllKindsOfNodeDepthsUnitTest
    {
        [Fact]
        public void Test1()
        {
            var root = new AllKindsOfNodeDepths.AllKindsOfNodeDepthsClassBinaryTree(1);
            root.left = new AllKindsOfNodeDepths.AllKindsOfNodeDepthsClassBinaryTree(2);
            root.left.left = new AllKindsOfNodeDepths.AllKindsOfNodeDepthsClassBinaryTree(4);
            root.left.left.left = new AllKindsOfNodeDepths.AllKindsOfNodeDepthsClassBinaryTree(8);
            root.left.left.right = new AllKindsOfNodeDepths.AllKindsOfNodeDepthsClassBinaryTree(9);
            root.left.right = new AllKindsOfNodeDepths.AllKindsOfNodeDepthsClassBinaryTree(5);
            root.right = new AllKindsOfNodeDepths.AllKindsOfNodeDepthsClassBinaryTree(3);
            root.right.left = new AllKindsOfNodeDepths.AllKindsOfNodeDepthsClassBinaryTree(6);
            root.right.right = new AllKindsOfNodeDepths.AllKindsOfNodeDepthsClassBinaryTree(7);
            var actual = AllKindsOfNodeDepthsClass.AllKindsOfNodeDepths(root);
            Assert.Equal(26, actual);
        }
    }

    public abstract class AllKindsOfNodeDepths
    {
        public class AllKindsOfNodeDepthsClassBinaryTree : Helpers.Binary_Trees.AllKindsOfNodeDepthsClassBinaryTree
        {
            public AllKindsOfNodeDepthsClassBinaryTree(int i) : base()
            {
                throw new NotImplementedException();
            }
        }
    }
}