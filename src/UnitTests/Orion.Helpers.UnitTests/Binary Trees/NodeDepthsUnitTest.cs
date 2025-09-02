using _Main_;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Orion.Helpers.Binary_Trees;

namespace Orion.Helpers.UnitTests.Binary_Trees
{
    public class NodeDepthsClassUnitTest
    {
        [Fact(Skip ="Fix this")]
        public void Test1()
        {
            var root = new NodeDepthsClass.BinaryTree(1);
            root.left = new _Go__.BinaryTree(2);
            root.left.left = new _Go__.BinaryTree(4);
            root.left.left.left = new _Go__.BinaryTree(8);
            root.left.left.right = new _Go__.BinaryTree(9);
            root.left.right = new _Go__.BinaryTree(5);
            root.right = new _Go__.BinaryTree(3);
            root.right.left = new _Go__.BinaryTree(6);
            root.right.right = new _Go__.BinaryTree(7);
            int actual = _Go__.NodeDepths(root);
            Assert.Equals(16, actual);
        }
    }
}