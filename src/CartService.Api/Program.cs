var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(options =>
    {
        options.Title = "My API";
    });
}

app.UseHttpsRedirection();

app.MapGet("/", () => Console.Writeline("Demo app for git fundamentals practice!"));
app.MapGet("/admin", () => Console.Writeline("This is Admin Page"));
app.MapGet("/cart", () => Console.Writeline("Cart Page which added from another dev!"));

app.Run();


