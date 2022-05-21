using VictorBack.Services;

const string corsName = "mycors";
var builder = WebApplication.CreateBuilder(args);
var origins = builder.Configuration.GetSection("CorsOrigins").Get<string[]>();
builder.Services.AddCors(p => p.AddPolicy(name:corsName, builder =>
{
    builder.WithOrigins(origins)
        .AllowAnyMethod()
        .AllowAnyHeader();
}));
// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthorization();
builder.Services.AddSingleton<IData, DataAccess>();
builder.Services.AddSingleton<IUserService, UserService>();



var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(corsName);

// app.UseAuthorization();

app.Map("/api/experience", (IUserService user) => {
    return Results.Ok(user.GetExperience());
});

app.Map("/api/about", (IUserService user) => {
    return Results.Ok(user.GetUserInfo());
});

app.Run();
