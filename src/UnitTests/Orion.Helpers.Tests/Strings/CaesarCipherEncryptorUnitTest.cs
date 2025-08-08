namespace Orion.Helpers.Tests.Strings
{
    public class CaesarCipherEncryptorClassUnitTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(CaesarCipherEncryptorClass.CaesarCypherEncryptor("xyz", 2).Equals("zab"));
        }
    }
}