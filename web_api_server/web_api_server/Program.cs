var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Use(async (context, next) =>
{
    await next();
    Console.WriteLine("First name");
});

app.Use(async (context, next) =>
{
    Console.WriteLine("Second name");
    await next();
});

app.Use(async (context, next) =>
{
    Console.WriteLine("Third name");
    await next();
});



app.MapGet("/", () => "Hello World");



app.Run();

