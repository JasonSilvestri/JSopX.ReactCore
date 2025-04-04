var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.JSopX_ReactCore_Server>("jsopx-reactcore-server");

builder.Build().Run();
