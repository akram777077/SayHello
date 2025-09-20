var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/", () => "Hello from Render + .NET!");
app.MapGet("/stats", () => new { saved = 5, reviewed = 3 });


app.Run();
