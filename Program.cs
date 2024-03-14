using curewellApp.Database;
using curewellApp.Repository;
using curewellApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionstring= builder.Configuration.GetConnectionString("mysql");

builder.Services.AddDbContext<CureWellDbContext>(options=>
    options.UseMySql(connectionstring,ServerVersion.AutoDetect(connectionstring))
);

builder.Services.AddScoped<IDoctorService,DoctorService>();
builder.Services.AddScoped<ISurgeryService,SurgeryService>();
builder.Services.AddScoped<IDoctorRepository,DoctorRepository>();
builder.Services.AddScoped<ISurgeryRepository,SurgeryRepository>();

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

app.Run();
