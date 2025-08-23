using _Main_;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Orion.Helpers.UnitTests.Binary_Trees
{
    public partial class UnitTest1
    {
        [Fact(Skip = "Fix later")   ]
        public void Test1()
        {

        }
    }
}


_Go__.BinaryTree root = new _Go__.BinaryTree(1);
Insert(root, new int[] { 2, 3, 4, 5, 6, 7, 8, 9 });

void Insert(_Go__.BinaryTree binaryTree, int[] ints)
{
    throw new NotImplementedException();
}

root.left.right.right = new _Go__.BinaryTree(10);
root.right.left.left = new _Go__.BinaryTree(11);
root.right.right.left = new _Go__.BinaryTree(12);
root.right.right.right = new _Go__.BinaryTree(13);
root.right.left.left.left = new _Go__.BinaryTree(14);
_Go__.BinaryTree mutatedRoot = _Go__.RightSiblingTree(root);
List<int> actual = GetDfsOrder(mutatedRoot);

List<int> GetDfsOrder(_Go__.BinaryTree binaryTree)
{
    throw new NotImplementedException();
}

var expected = new List<int> {
      1, 2, 4, 8, 9, 5, 6, 11, 14, 7, 12, 13, 3, 6, 11, 14, 7, 12, 13
    };
Assert.True(expected.SequenceEqual(actual));
  }

  public void Insert(_Go__.BinaryTree root, int[] values)
{
    insert(root, values, 0);
}

  public void insert(_Go__.BinaryTree root, int[] values, int i)
  {
      if (i >= values.Length)
      {
          return;
      }

      Queue<_Go__.BinaryTree> queue = new Queue<_Go__.BinaryTree>();
      queue.Enqueue(root);
      while (queue.Count > 0)
      {
          _Go__.BinaryTree current = queue.Dequeue();
          if (current.left == null)
          {
              current.left = new _Go__.BinaryTree(values[i]);
              break;
          }

          queue.Enqueue(current.left);
          if (current.right == null)
          {
              current.right = new _Go__.BinaryTree(values[i]);
              break;
          }

          queue.Enqueue(current.right);
      }

      insert(root, values, i + 1);


      List<int> GetDfsOrder(_Go__.BinaryTree tree)
      {
          List<int> values = new List<int>();
          values.Add(tree.value);
          if (tree.left != null)
          {
              values.AddRange(GetDfsOrder(tree.left));
          }

          if (tree.right != null)
          {
              values.AddRange(GetDfsOrder(tree.right));
          }

          return values;
      }
  }