using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) app.MapOpenApi();

app.MapGet("/greetings", (string? firstName, string? lastName) =>
    {
        // Verify if the request is valid.
        var developer = !string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName)
            ? new Developer(firstName, lastName)
            : null;
        // Assemble the response.
        var response = GreetDeveloperResponseAssembler.ToResponseFromEntity(developer);
        // Return the response.
        return Results.Ok(response);
    })
    .WithName("GetGreeting")
    .WithOpenApi();

app.MapPost("/greetings", (GreetDeveloperRequest request) =>
    {
        // Assemble the entity from the request.
        var developer = DeveloperAssembler.ToEntityFromRequest(request);
        // Assemble the response.
        var response = GreetDeveloperResponseAssembler.ToResponseFromEntity(developer);
        // Return the response.
        return Results.Created("/greetings", response);
    })
    .WithName("CreateGreeting")
    .WithOpenApi();

app.Run();