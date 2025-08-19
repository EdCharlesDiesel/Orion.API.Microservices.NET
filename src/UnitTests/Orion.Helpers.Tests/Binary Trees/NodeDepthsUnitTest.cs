using Microsoft.VisualBasic.CompilerServices;
using Orion.Helpers.Binary_Trees;

namespace Orion.Helpers.Tests.Binary_Trees
{
    public class NodeDepthsClassUnitTest
    {
        [Fact(Skip ="Fix this")]
        public void Test1()
        {
            var root = new NodeDepthsClass.BinaryTree(1);
            root.left = new Program.BinaryTree(2);
            root.left.left = new Program.BinaryTree(4);
            root.left.left.left = new Program.BinaryTree(8);
            root.left.left.right = new Program.BinaryTree(9);
            root.left.right = new Program.BinaryTree(5);
            root.right = new Program.BinaryTree(3);
            root.right.left = new Program.BinaryTree(6);
            root.right.right = new Program.BinaryTree(7);
            int actual = Program.NodeDepths(root);
            Utils.AssertEquals(16, actual);
        }
    }
}