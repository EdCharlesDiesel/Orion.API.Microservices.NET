namespace Orion.Helpers.Binary_Trees
{
    internal class InvertBinaryTreeClass2
    {
        // O(n) time | O(d) space
        public static void InvertBinaryTree(BinaryTree tree)
        {
            if (tree == null)
            {
                return;
            }
            swapLeftAndRight(tree);
            InvertBinaryTree(tree.left);
            InvertBinaryTree(tree.right);
        }
        private static void swapLeftAndRight(BinaryTree tree)
        {
            (tree.left, tree.right) = (tree.right, tree.left);
        }
        public class BinaryTree
        {
            public int value;
            public BinaryTree left;
            public BinaryTree right;
            public BinaryTree(int value)
            {
                this.value = value;
            }
        }
    }
}
