var builder = WebApplication.CreateBuilder(args);
var mongoSettings = builder.Configuration.GetSection("MongoConnection");

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run("http://localhost:3000");
