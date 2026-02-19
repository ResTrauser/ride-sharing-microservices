using Testcontainers.PostgreSql;
using Xunit;

namespace GeoFlow.Tests;

public class IntegrationTestBase : IAsyncLifetime
{
    private readonly PostgreSqlContainer _postgreSqlContainer = new PostgreSqlBuilder()
        .WithImage("postgres:16-alpine")
        .Build();

    public string ConnectionString => _postgreSqlContainer.GetConnectionString();

    public async Task InitializeAsync()
    {
        await _postgreSqlContainer.StartAsync();
        // TODO: Apply migrations here
        // Example:
        // var context = new MyDbContext(new DbContextOptionsBuilder<MyDbContext>().UseNpgsql(ConnectionString).Options);
        // await context.Database.MigrateAsync();
    }

    public async Task DisposeAsync()
    {
        await _postgreSqlContainer.DisposeAsync();
    }
}
