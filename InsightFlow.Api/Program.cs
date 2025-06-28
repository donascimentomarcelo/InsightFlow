using FluentValidation;
using InsightFlow.Application;
using InsightFlow.Application.Repositories;
using InsightFlow.Application.Services;
using InsightFlow.Application.Validator;
using InsightFlow.Infrastructure.Dependencies;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi()
    .AddValidatorsFromAssemblyContaining<CreateIncidentCommandValidator>()
    .AddMediatR(typeof(CreateIncidentCommandValidator).Assembly)
    .AddInsightFlowDependencies()
    .AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
