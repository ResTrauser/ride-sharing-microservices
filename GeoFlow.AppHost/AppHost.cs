var builder = DistributedApplication.CreateBuilder(args);

var db = builder.AddConnectionString("geoflow-db");

builder.AddProject<Projects.GeoFlow_Services_Feedback>("feedback-service").WithReference(db);

builder.AddProject<Projects.GeoFlow_Services_Finance>("finance-service").WithReference(db);

builder.AddProject<Projects.GeoFlow_Services_Fleet>("fleet-service").WithReference(db);

builder.AddProject<Projects.GeoFlow_Services_Iam>("iam-service").WithReference(db);

builder.AddProject<Projects.GeoFlow_Services_Ride>("ride-service").WithReference(db);

builder.Build().Run();
