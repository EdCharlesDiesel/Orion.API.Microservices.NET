

namespace Orion.Helpers.UnitTests.Binary_Search_Tree
{
    public class BstUnitTest
    {
        [Fact(Skip ="Sort later")]
        public void Test1()
        {
            var root = new GenericClassAlgorithm.BST(10);
            root.Left = new GenericClassAlgorithm.BST(5);
            root.Left.Left = new GenericClassAlgorithm.BST(2);
            root.Left.Left.Left = new GenericClassAlgorithm.BST(1);
            root.Left.Right = new GenericClassAlgorithm.BST(5);
            root.Right = new GenericClassAlgorithm.BST(15);
            root.Right.Left = new GenericClassAlgorithm.BST(13);
            root.Right.Left.Right = new GenericClassAlgorithm.BST(14);
            root.Right.Right = new GenericClassAlgorithm.BST(22);

            Assert.True(GenericClassAlgorithm.ValidateBST(root));
        }
    }
}