using _Main_;

namespace Orion.Helpers.UnitTests.Binary_Search_Tree
{
    public class BstUnitTest
    {
        [Fact(Skip ="Sort later")]
        public void Test1()
        {
            var root = new _Go__.BST(10);
            root.left = new _Go__.BST(5);
            root.left.left = new _Go__.BST(2);
            root.left.left.left = new _Go__.BST(1);
            root.left.right = new _Go__.BST(5);
            root.right = new _Go__.BST(15);
            root.right.left = new _Go__.BST(13);
            root.right.left.right = new _Go__.BST(14);
            root.right.right = new _Go__.BST(22);

            Assert.True(_Go__.ValidateBst(root));
        }
    }
}