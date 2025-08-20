using _Main_;
using Microsoft.VisualBasic.CompilerServices;
using Orion.Helpers.Binary_Trees;

namespace Orion.Helpers.UnitTests.Binary_Trees
{
    public partial class UnitTest1
    {
        [Fact]
        public void IterativeInorderTraversalClassTest1()
        {
            var root = new IterativeInorderTraversalClass.BinaryTree(1);
            root.left = new Program.BinaryTree(2, root);
            root.left.left = new Program.BinaryTree(4, root.left);
            root.left.left.right = new Program.BinaryTree(9, root.left.left);
            root.right = new Program.BinaryTree(3, root);
            root.right.left = new Program.BinaryTree(6, root.right);
            root.right.right = new Program.BinaryTree(7, root.right);

            testArray.Clear();
            _Go__.IterativeInOrderTraversal(root, testCallback);
            Utils.AssertTrue(
              Enumerable.SequenceEqual(testArray, new List<int> { 4, 9, 2, 1, 6, 3, 7 })
            );
        }
    }
   
}