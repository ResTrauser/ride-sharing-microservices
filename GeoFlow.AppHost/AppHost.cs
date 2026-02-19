var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder.AddPostgres("postgres");
var db = postgres.AddDatabase("geoflow-db");
var elasticsearch = builder.AddElasticsearch("elasticsearch");

builder.AddProject<Projects.GeoFlow_Services_Feedback>("feedback-service")
       .WithReference(db)
       .WithReference(elasticsearch);

builder.AddProject<Projects.GeoFlow_Services_Finance>("finance-service")
       .WithReference(db)
       .WithReference(elasticsearch);

builder.AddProject<Projects.GeoFlow_Services_Fleet>("fleet-service")
       .WithReference(db)
       .WithReference(elasticsearch);

builder.AddProject<Projects.GeoFlow_Services_Iam>("iam-service")
       .WithReference(db)
       .WithReference(elasticsearch);

builder.AddProject<Projects.GeoFlow_Services_Ride>("ride-service")
       .WithReference(db)
       .WithReference(elasticsearch);

builder.Build().Run();
