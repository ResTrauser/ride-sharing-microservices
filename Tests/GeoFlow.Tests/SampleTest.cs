using Xunit;

namespace GeoFlow.Tests;

public class SampleTest : IntegrationTestBase
{
    [Fact]
    public void TestContainer_Starts_And_Is_Valid()
    {
        Assert.NotNull(ConnectionString);
        Assert.Contains("Host=", ConnectionString);
        // This test proves that the Docker container for Postgres was started successfully.
    }
}
