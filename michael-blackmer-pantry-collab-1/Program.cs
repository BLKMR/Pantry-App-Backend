using michael_blackmer_pantry_collab_1;
using michael_blackmer_pantry_collab_1.Services.FamilyAccountServices;
using michael_blackmer_pantry_collab_1.Services.UserAccountServices;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<DataContext>(options => {
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
//});


builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer("Server=localhost;Initial Catalog=PantryDb;Integrated Security=False;User Id=sa;Password=S3cur3P@ssW0rd!;MultipleActiveResultSets=True;encrypt=false");
});

builder.Services.AddScoped<IUserAccountService, UserAccountService>();

builder.Services.AddScoped<IFamilyAccountService, FamilyAccountService>();

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
