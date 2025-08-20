using Orion.Helpers.Arrays;

namespace Orion.Helpers.UnitTests.Arrays
{
    public class EvaluateExpressionTreeClassUnitTest
    {
        [Fact]
        public void Test1()
        {
            EvaluateExpressionTreeClass.BinaryTree tree = new EvaluateExpressionTreeClass.BinaryTree(-1);
            tree.left = new EvaluateExpressionTreeClass.BinaryTree(2);
            tree.right = new EvaluateExpressionTreeClass.BinaryTree(-2);
            tree.right.left = new EvaluateExpressionTreeClass.BinaryTree(5);
            tree.right.right = new EvaluateExpressionTreeClass.BinaryTree(1);
            var expected = 6;
            var actual = new EvaluateExpressionTreeClass().EvaluateExpressionTree(tree);
            Assert.True(expected == actual);
        }
    }
}