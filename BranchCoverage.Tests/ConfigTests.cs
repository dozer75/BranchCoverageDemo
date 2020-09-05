using Xunit;

namespace BranchCoverage.Tests
{
    public class ConfigTests
    {
        [Fact]
        public void TestConnectionString()
        {
            var config = new Config(new Options { ConnectionString = "blabla" });

            Assert.Equal("blabla", config.ConnectionString);
        }
    }
}
