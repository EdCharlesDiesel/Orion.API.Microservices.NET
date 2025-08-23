using _Main_;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Orion.Helpers.UnitTests.Graph
{
    public class AncestralTreeUnitTest
    {
        [Fact(Skip ="Fix later")]
        public void Test1()
        {
            var trees = GetNewTrees();
            trees['A'].AddAsAncestor(
              new _Go__.AncestralTree[] { trees['B'], trees['C'] }
            );
            trees['B'].AddAsAncestor(
              new _Go__.AncestralTree[] { trees['D'], trees['E'] }
            );
            trees['D'].AddAsAncestor(
              new _Go__.AncestralTree[] { trees['H'], trees['I'] }
            );
            trees['C'].AddAsAncestor(
              new _Go__.AncestralTree[] { trees['F'], trees['G'] }
            );

            _Go__.AncestralTree yca =
                _Go__.GetYoungestCommonAncestor(trees['A'], trees['E'], trees['I']);
            Assert.True(yca == trees['B']);
        }

        private object GetNewTrees()
        {
            throw new NotImplementedException();
        }
    }

    public Dictionary<char, _Go__.AncestralTree> GetNewTrees()
    {
        var trees = new Dictionary<char, _Go__.AncestralTree>();
        var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        foreach (char a in alphabet)
        {
            trees.Add(a, new _Go__.AncestralTree(a));
        }

        trees['A'].AddAsAncestor(new[] {
      trees['B'], trees['C'], trees['D'], trees['E'], trees['F']
    });
        return trees;
    }
}