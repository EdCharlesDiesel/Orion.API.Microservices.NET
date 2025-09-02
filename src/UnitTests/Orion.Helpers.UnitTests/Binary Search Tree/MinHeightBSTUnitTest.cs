using _Main_;

namespace Orion.Helpers.UnitTests.Binary_Search_Tree
{
    public class ValidateBstUnitTest1
    {
        [Fact] // removed Skip so it actually runs
        public void Test1()
        {
            var array = new List<int> { 1, 2, 5, 7, 10, 13, 14, 15, 22 };
            _Go__.BST tree = _Go__.MinHeightBst(array);

            Assert.True(ValidateBst(tree));
            Assert.Equal(4, GetTreeHeight(tree));

            var inOrder = InOrderTraverse(tree, new List<int>());
            var expected = new List<int> { 1, 2, 5, 7, 10, 13, 14, 15, 22 };
            Assert.True(inOrder.SequenceEqual(expected));
        }

        static bool ValidateBst(_Go__.BST tree) =>
            ValidateBst(tree, int.MinValue, int.MaxValue);

        static bool ValidateBst(_Go__.BST tree, int minValue, int maxValue)
        {
            if (tree.value < minValue || tree.value >= maxValue)
                return false;

            if (tree.left != null && !ValidateBst(tree.left, minValue, tree.value))
                return false;

            if (tree.right != null && !ValidateBst(tree.right, tree.value, maxValue))
                return false;

            return true;
        }

        private static List<int> InOrderTraverse(_Go__.BST? tree, List<int> array)
        {
            if (tree.left != null)
                InOrderTraverse(tree.left, array);

            array.Add(tree.value);

            InOrderTraverse(tree.right, array);

            return array;
        }

        static int GetTreeHeight(_Go__.BST? tree) =>
            GetTreeHeight(tree, 0);

        static int GetTreeHeight(_Go__.BST? tree, int height)
        {
            if (tree == null) return height;
            int leftTreeHeight = GetTreeHeight(tree.left, height + 1);
            int rightTreeHeight = GetTreeHeight(tree.right, height + 1);
            return Math.Max(leftTreeHeight, rightTreeHeight);
        }
    }
}
