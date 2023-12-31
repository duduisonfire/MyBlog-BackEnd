using API;
using API.Context;
using API.Repository;
using API.Services;
using dotenv.net;
using Microsoft.EntityFrameworkCore;

DotEnv.Load();
var builder = WebApplication.CreateBuilder(args);
var connectionString = Environment.GetEnvironmentVariable("ConnectionString");

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: "MyAllowSpecificOrigins",
        policy =>
            policy.WithOrigins("http://localhost:3000", "https://localhost:3000").AllowAnyHeader()
    );
});

builder.Services.AddDbContext<AppDbContext>(
    options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
);

builder.Services.AddTransient<IBlogPostRepository, BlogPostRepository>();
builder.Services.AddTransient<IBlogPostServices, BlogPostServices>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("MyAllowSpecificOrigins");
app.UseAuthorization();
app.MapControllers();
app.Run();
