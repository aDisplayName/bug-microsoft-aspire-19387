using Microsoft.Extensions.Configuration;

var builder = DistributedApplication.CreateBuilder(args);
var mode = builder.Configuration.GetValue<string>("mode");

var apiService = builder.AddProject<Projects.aspire_starter_ApiService>("apiservice")
    .WithHttpHealthCheck("/health");

switch (mode)
{
    case "1":

        break;
    case "2":

        builder.AddProject<Projects.aspire_starter_Web>("webfrontend")
            .WithExternalHttpEndpoints()
            .WithHttpHealthCheck("/health")
            .WithReference(apiService)
            .WaitFor(apiService);
        break;
}

builder.Build().Run();
