namespace Orion.Helpers.Binary_Search_Tree
{
    public class BtsTaversalClass
    {
        // O(n) time | O(n) space
        public static List<int> InOrderTraverse(Bst tree, List<int> array)
        {
            if (tree.Left != null)
            {
                InOrderTraverse(tree.Left, array);
            }
            array.Add(tree.Value);
            if (tree.Right != null)
            {
                InOrderTraverse(tree.Right, array);
            }
            return array;
        }
        // O(n) time | O(n) space
        public static List<int> PreOrderTraverse(Bst tree, List<int> array)
        {
            array.Add(tree.Value);
            if (tree.Left != null)
            {
                PreOrderTraverse(tree.Left, array);
            }
            if (tree.Right != null)
            {
                PreOrderTraverse(tree.Right, array);
            }
            return array;
        }
        // O(n) time | O(n) space
        public static List<int> PostOrderTraverse(Bst tree, List<int> array)
        {
            if (tree.Left != null)
            {
                PostOrderTraverse(tree.Left, array);
            }
            if (tree.Right != null)
            {
                PostOrderTraverse(tree.Right, array);
            }
            array.Add(tree.Value);
            return array;
        }
        public class Bst
        {
            public int Value;
            public Bst Left;
            public Bst Right;
            public Bst(int value)
            {
                this.Value = value;
            }
        }
    }
}