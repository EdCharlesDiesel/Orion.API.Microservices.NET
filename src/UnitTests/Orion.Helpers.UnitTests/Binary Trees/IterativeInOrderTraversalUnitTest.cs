using Orion.Helpers.Binary_Trees;

namespace Orion.Helpers.UnitTests.Binary_Trees
{
    public partial class UnitTest1
    {
        [Fact]
        public void IterativeInorderTraversalClassTest1()
        {
            var root = new IterativeInorderTraversalClass.BinaryTree(1);
            root.Left = new IterativeInorderTraversalClass.BinaryTree(2, root);
            root.Left.Left = new IterativeInorderTraversalClass.BinaryTree(4, root.Left);
            root.Left.Left.Right = new GenericClassAlgorithm.BinaryTree(9, root.Left.Left);
            root.Right = new GenericClassAlgorithm.BinaryTree(3, root);
            root.Right.Left = new GenericClassAlgorithm.BinaryTree(6, root.Right);
            root.Right.Right = new GenericClassAlgorithm.BinaryTree(7, root.Right);

            testArray.Clear();
            GenericClassAlgorithm.IterativeInOrderTraversal(root, testCallback);
            Assert.True(
              Enumerable.SequenceEqual(testArray, new List<int> { 4, 9, 2, 1, 6, 3, 7 })
            );
        }
    }
   
}