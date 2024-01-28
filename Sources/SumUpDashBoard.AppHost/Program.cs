var builder = DistributedApplication.CreateBuilder(args);

var apiservice = builder.AddProject<Projects.SumUpDashBoard_ApiService>("apiservice");

builder.AddProject<Projects.SumUpDashBoard_Web>("webfrontend")
    .WithReference(apiservice);

builder.Build().Run();
