using VictorBack.Models;
using VictorBack.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IData,DataAccess>();

var origins = builder.Configuration.GetSection("AllowedHosts").Get<string[]>();
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins(origins).AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corsapp");

// app.UseHttpsRedirection();

// app.UseAuthorization();

app.Map("/experience", (IData data) => {
    return Results.Ok(data.GetExperience());
});

app.Run();
