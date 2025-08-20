


using Orion.Helpers.Recursion;

namespace Orion.Helpers.Tests.Recursion
{
    public class LowestCommonManagerUnitTest
    {
        public Dictionary<char, LowestCommonManagerClass.OrgChart> getOrgCharts()
        {
            var orgCharts = new Dictionary<char, LowestCommonManagerClass.OrgChart>();
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char a in alphabet)
            {
                orgCharts.Add(a, new LowestCommonManagerClass.OrgChart(a));
            }
            return orgCharts;
        }

        [Fact]
        public void TestCase1()
        {
            var orgCharts = getOrgCharts();
            orgCharts['A'].addDirectReports(new[] {orgCharts['B'],
                                                                orgCharts['C']});
            orgCharts['B'].addDirectReports(new[] {orgCharts['D'],
                                                                orgCharts['E']});
            orgCharts['C'].addDirectReports(new[] {orgCharts['F'],
                                                                orgCharts['G']});
            orgCharts['D'].addDirectReports(new[] {orgCharts['H'],
                                                                orgCharts['I']});
            LowestCommonManagerClass.OrgChart lcm = LowestCommonManagerClass.GetLowestCommonManager(orgCharts['A'],
                orgCharts['E'],
                orgCharts['I']);
            Assert.True(lcm == orgCharts['B']);
        }
    }
}