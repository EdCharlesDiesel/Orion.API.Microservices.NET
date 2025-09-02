namespace Orion.Helpers.Binary_Search_Tree
{
    public class ValidateBstClass
    {
        // O(n) time | O(d) space
        public static bool ValidateBst(Bst tree)
        {
            return ValidateBst(tree, Int32.MinValue, Int32.MaxValue);
        }
        public static bool ValidateBst(Bst tree, int minValue, int maxValue)
        {
            if (tree.Value < minValue || tree.Value >= maxValue)
            {
                return false;
            }
            if (tree.Left != null && !ValidateBst(tree.Left, minValue, tree.Value))
            {
                return false;
            }
            if (tree.Right != null && !ValidateBst(tree.Right, tree.Value, maxValue))
            {
                return false;
            }
            return true;
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