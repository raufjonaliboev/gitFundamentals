var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/", () => Console.Writeline("Demo app for git fundamentals practice!"));
app.MapGet("/admin", () => Console.Writeline("This is Admin Page"));

app.Run();


