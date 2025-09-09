using Orion.Helpers.Binary_Trees;

namespace Orion.Helpers.UnitTests.Binary_Trees
{
    public class NodeDepthsClassUnitTest
    {
        [Fact(Skip ="Fix this")]
        public void Test1()
        {
            var root = new NodeDepthsClass.BinaryTree(1);
            root.Left = new GenericClassAlgorithm.BinaryTree(2);
            root.Left.Left = new GenericClassAlgorithm.BinaryTree(4);
            root.Left.Left.Left = new GenericClassAlgorithm.BinaryTree(8);
            root.Left.Left.Right = new GenericClassAlgorithm.BinaryTree(9);
            root.Left.Right = new GenericClassAlgorithm.BinaryTree(5);
            root.Right = new GenericClassAlgorithm.BinaryTree(3);
            root.Right.Left = new GenericClassAlgorithm.BinaryTree(6);
            root.Right.Right = new GenericClassAlgorithm.BinaryTree(7);
            int actual = GenericClassAlgorithm.NodeDepths(root);
            Assert.Equals(16, actual);
        }
    }
}