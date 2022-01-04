using MyApi;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ContactRepository>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapContactApi();

app.Run();
