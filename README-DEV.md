# GeoFlow Development Environment

This project has been configured with professional development environment settings, including Docker integration, Testcontainers, and Serilog logging.

## Docker & Aspire

This solution uses .NET Aspire for container orchestration.
- The `GeoFlow.AppHost` project defines the application composition, including PostgreSQL and Elasticsearch resources.
- Run the application via Visual Studio or `dotnet run --project GeoFlow.AppHost`.

## Logging

Serilog has been integrated for detailed logging.
- Logs are configured to write to the console and to Elasticsearch.
- Configuration is centralized in `GeoFlow.ServiceDefaults`.

## Testing

Integration tests are configured to run with `Testcontainers`.
- Each test run spins up a fresh PostgreSQL container ensuring isolation and real database interaction.
- Tests can be run locally via `dotnet test` (requires Docker Desktop).
- Tests can also be run inside a Docker container using the provided script:

  ```bash
  ./run-tests-docker.sh
  ```

  This builds the test project into a Docker image and runs the tests, mounting the Docker socket so Testcontainers works correctly.

## Prerequisites

- Docker Desktop (or compatible engine) running.
- .NET 10 SDK (as per project configuration).
