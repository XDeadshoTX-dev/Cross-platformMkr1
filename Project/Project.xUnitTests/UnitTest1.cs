using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Project.xUnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new string[] { "???", "abc" }, 64)]
        [InlineData(new string[] { "???", "000" }, 1)]
        [InlineData(new string[] { "abc", "999" }, 0)]
        [InlineData(new string[] { "abc", "abc" }, 64)]
        [InlineData(new string[] { "efg", "abc" }, 0)]
        [InlineData(new string[] { "????", "efgc" }, 256)]
        [InlineData(new string[] { "abcd", "aaaa" }, 24)]
        public void Test(string[] inputLines, int expected)
        { 
            // Act
            int actual = Program.GetResult(inputLines); 
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}