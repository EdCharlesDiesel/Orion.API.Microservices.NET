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
                if (previousNode == null || previousNode == currentNode.Parent)
                {
                    nextNode = currentNode.Left;
                }
                else if (previousNode == currentNode.Left)
                {
                    callback(currentNode);
                    nextNode = currentNode.Right;
                }
                else
                {
                    nextNode = currentNode.Parent;
                }
                previousNode = currentNode;
                currentNode = nextNode;
            }
        }

        public class BinaryTree
        {
            public BinaryTree Left;
            public BinaryTree Right;
            public BinaryTree Parent;

            public BinaryTree(int i)
            {
                throw new NotImplementedException();
            }
        }
    }

    public class BinaryTree
    {
        public int Value;
        public BinaryTree Left;
        public BinaryTree Right;
        public BinaryTree Parent;
        public BinaryTree(int value)
        {
            this.Value = value;
        }
        public BinaryTree(int value, BinaryTree parent)
        {
            this.Value = value;
            this.Parent = parent;
        }
    }
}