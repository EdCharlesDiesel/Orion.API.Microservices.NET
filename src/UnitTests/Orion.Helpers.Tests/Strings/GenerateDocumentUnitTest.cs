namespace Orion.Helpers.Tests.Strings
{
    public class GenerateDocumentClassUnitTest
    {
        [Fact]
        public void Test1()
        {
            string characters = "Bste!hetsi ogEAxpelrt x ";
            string document = "AlgoExpert is the Best!";
            bool expected = true;
            var actual = new GenerateDocumentClass().GenerateDocument(characters, document);
            Assert.True(expected == actual);
        }
    }
}