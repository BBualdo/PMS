using Data;
using Data.Helpers;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

ConfigureServices();

var app = builder.Build();

ConfigureMiddlewares();

await using var scope = app.Services.CreateAsyncScope();
var seeder = scope.ServiceProvider.GetService<Seeder>();
await seeder.SeedRolesAsync();
await seeder.CreateAdminAsync();

app.Run();

return;

void ConfigureServices()
{
    builder.Services.AddControllers();

    builder.Services.AddDbContext<PmsDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("Default")));

    builder.Services.AddIdentityCore<User>()
        .AddRoles<IdentityRole>()
        .AddEntityFrameworkStores<PmsDbContext>();

    builder.Services.AddIdentityApiEndpoints<User>();
    builder.Services.AddAuthentication();

    builder.Services.AddCors(options =>
        options.AddPolicy("policy", policyBuilder =>
            policyBuilder.AllowCredentials().AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200")));

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.AddTransient<Seeder>();
}

void ConfigureMiddlewares()
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();
    app.UseCors("policy");
    app.UseAuthentication();
    app.UseAuthorization();
    app.MapControllers();
    app.MapIdentityApi<User>();
}