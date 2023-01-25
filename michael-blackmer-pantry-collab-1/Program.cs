using michael_blackmer_pantry_collab_1;
using michael_blackmer_pantry_collab_1.Models;
using michael_blackmer_pantry_collab_1.Services.FamilyService;
using michael_blackmer_pantry_collab_1.Services.ItemService;
using michael_blackmer_pantry_collab_1.Services.UserService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "localhost",
        policy =>
        {
            policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader().AllowCredentials();
        });
});

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IFamilyService, FamilyService>();
builder.Services.AddScoped<IItemService, ItemService>();




builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer("Server=localhost;Initial Catalog=PantryDb;Integrated Security=False;User Id=sa;Password=S3cur3P@ssW0rd!;MultipleActiveResultSets=True;encrypt=false");
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("localhost");

app.Run();
