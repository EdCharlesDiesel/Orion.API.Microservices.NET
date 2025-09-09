using Orion.Helpers.Binary_Search_Tree;

namespace Orion.Helpers.UnitTests.Binary_Search_Tree
{
    public class BtsTraversalClassUnitTest
    {
        [Fact]
        public void Test1()
        {
            var root = new BtsTraversalClass.BST(10);
            root.Left = new BtsTraversalClass.BST(5);
            root.Left.Left = new BtsTraversalClass.BST(2);
            root.Left.Left.Left = new BtsTraversalClass.BST(1);
            root.Left.Right = new BtsTraversalClass.BST(5);
            root.Right = new BtsTraversalClass.BST(15);
            root.Right.Right = new BtsTraversalClass.BST(22);

            List<int> inOrder = new List<int> { 1, 2, 5, 5, 10, 15, 22 };
            List<int> preOrder = new List<int> { 10, 5, 2, 1, 5, 15, 22 };
            List<int> postOrder = new List<int> { 1, 2, 5, 5, 22, 15, 10 };

            Assert.True(BtsTraversalClass.InOrderTraverse(root, new List<int>()).SequenceEqual(inOrder
            ));
            Assert.True(BtsTraversalClass.PreOrderTraverse(root, new List<int>()).SequenceEqual(preOrder
            ));
            Assert.True(BtsTraversalClass.PostOrderTraverse(root, new List<int>()).SequenceEqual(postOrder
            ));
        }
    }
}