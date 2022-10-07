var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()

    .AddMutationConventions()
    .AddMutationType<Mutation>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.MapGraphQL();

app.Run();
