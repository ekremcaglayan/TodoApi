var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapWhen(context => context.Request.Query.ContainsKey("Ekrem"), UserTest);

//app.MapWhen(context => context.Request.Path.StartsWithSegments("/v1/user/"), appBuilder =>
//{
//    appBuilder.UseMiddleware<ActiveEndPointCheck>();
//});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

static void UserTest(IApplicationBuilder app)
{
    app.Run(async context =>
    {
        var test = context.Request.Query["Ekrem"];
        await context.Response.WriteAsync($"Branch used = {test}");
    });
}