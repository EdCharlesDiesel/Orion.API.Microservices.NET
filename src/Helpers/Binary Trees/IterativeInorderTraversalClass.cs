namespace Orion.Helpers.Binary_Trees
{
    public static class IterativeInorderTraversalClass
    {
        // O(n) time | O(1) space
        public static void IterativeInOrderTraversal(BinaryTree tree, Action<BinaryTree> callback)
        {
            BinaryTree previousNode = null;
            BinaryTree currentNode = tree;
            while (currentNode != null)
            {
                BinaryTree nextNode;
                if (previousNode == null || previousNode == currentNode.parent)
                {
                    nextNode = currentNode.left;
                }
                else if (previousNode == currentNode.left)
                {
                    callback(currentNode);
                    nextNode = currentNode.right;
                }
                else
                {
                    nextNode = currentNode.parent;
                }
                previousNode = currentNode;
                currentNode = nextNode;
            }
        }

        public class BinaryTree
        {
            public BinaryTree left;
            public BinaryTree right;
            public BinaryTree parent;

            public BinaryTree(int i)
            {
                throw new NotImplementedException();
            }
        }
    }

    public class BinaryTree
    {
        public int value;
        public BinaryTree left;
        public BinaryTree right;
        public BinaryTree parent;
        public BinaryTree(int value)
        {
            this.value = value;
        }
        public BinaryTree(int value, BinaryTree parent)
        {
            this.value = value;
            this.parent = parent;
        }
    }
}