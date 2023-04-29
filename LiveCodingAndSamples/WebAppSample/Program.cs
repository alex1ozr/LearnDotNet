using FluentValidation;
using Microsoft.AspNetCore.HttpLogging;
using FluentValidation.AspNetCore;
using LearnDotNet.WebAppSample.Services;
using LearnDotNet.WebAppSample.Validators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddFluentValidationAutoValidation(x =>
{
    x.DisableDataAnnotationsValidation = true;
});
builder.Services.AddValidatorsFromAssemblyContaining<MyClassValidator>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckl
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new()
        { Title = "My Test Service API", Version = "v1" });
});
builder.Services.AddHttpLogging(options =>
{
    options.LoggingFields = HttpLoggingFields.All; 
    options.RequestBodyLogLimit = 4096; // default is 32k options.ResponseBodyLogLimit = 4096; // default is 32k
});

// Adding logging to Console
builder.Host.ConfigureLogging(logging =>
{
    logging.ClearProviders();
    logging.AddConsole();
});

builder.Host.ConfigureServices(collection =>
{
    collection.AddTransient<ISampleService, SampleService>();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpLogging();
app.UseRouting();

//...
app.MapControllers();

app.Run();