using SumUpDashBoard.DataAccess;
using Microsoft.OpenApi.Models;
using SumUpDashBoard.BusinessService.SumUpBusinessService;
using SumUpDashBoard.BusinessService.ComptabilityBusinessService;
using SumUpDashBoard.BusinessModels.ComptabilityModels;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire components.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();


builder.Services.AddTransient<ISumUpBaseService, SumUpBaseService>();
builder.Services.AddTransient<ISumUpService, SumUpService>();

builder.Services.AddTransient<ISumUpImportService, SumUpImportService>();

builder.Services.AddMvc();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My SumUp API", Version = "v1" });
});

builder.Services.AddRepository();

builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();


app.MapGet("/Transactions/Import", (ISumUpImportService _sumUpService, string csv) => _sumUpService.ImportSumUpTransaction(csv));
app.MapGet("/Transactions", (ISumUpImportService _sumUpService) => _sumUpService.GetSumUpTransactions());
app.MapPost("/Trimester", (ISumUpImportService _sumUpService, Trimester trimester, int year, decimal? amountTaxe) => _sumUpService.CreateNewTrimestre(trimester, year, amountTaxe));
app.MapGet("/Trimester", (ISumUpImportService _sumUpService) => _sumUpService.GetTrimester());


app.MapDefaultEndpoints();

app.MapSwagger();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("v1/swagger.json", "My SumUp API V1");
    c.DisplayRequestDuration();
});

app.Run();
