namespace Orion.Helpers.Binary_Trees
{
    public class NodeDepthsClassSolution2
    {
        // Average case: when the tree is balanced
        // O(n) time | O(h) space - where n is the number of nodes in
        // the Binary Tree and h is the height of the Binary Tree
        public static int NodeDepths(BinaryTree root)
        {
            return NodeDepthsHelper(root, 0);
        }

        public static int NodeDepthsHelper(BinaryTree root, int depth)
        {
            if (root == null) return 0;
            return depth + NodeDepthsHelper(root.Left, depth + 1) + NodeDepthsHelper(root.Right,
            depth + 1);
        }
    }

    public class BinaryTreeClass2
    {
        public int Value;
        public BinaryTree Left;
        public BinaryTree Right;
        public BinaryTreeClass2(int value)
        {
            this.Value = value;
            Left = null;
            Right = null;
        }
    }
}
