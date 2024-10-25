var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("VueAppPolicy", builder =>
    {
        builder.WithOrigins("http://localhost:5173") // 替換為您的 Vue 應用 URL
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.

app.UseAuthorization();
app.UseCors("VueAppPolicy");

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
