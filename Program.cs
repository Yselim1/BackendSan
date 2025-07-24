using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BackendSan.Services; 


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMemoryCache(); // Required for IMemoryCache
builder.Services.AddHttpClient(); // Required for IHttpClientFactory
builder.Services.AddSingleton<TokenStore>();
builder.Services.AddScoped<RelayService>(); 
builder.Services.AddControllers();

builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables(); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var relayService = scope.ServiceProvider.GetRequiredService<RelayService>();
    try
    {
        Console.WriteLine("Attempting to log in and retrieve initial token...");
        
        await relayService.InitializeTokenAsync(); 

        Console.WriteLine("Initial token retrieved successfully.");
    }
    catch (Exception ex)
    {
        Console.Error.WriteLine($"Error retrieving initial token: {ex.Message}");
        
    }
}


app.Run();
