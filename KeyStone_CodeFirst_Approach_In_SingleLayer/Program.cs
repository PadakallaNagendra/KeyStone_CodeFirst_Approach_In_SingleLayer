using KeyStone_CodeFirst_Approach_In_SingleLayer.DbConnect;
using KeyStone_CodeFirst_Approach_In_SingleLayer.InterFace;
using KeyStone_CodeFirst_Approach_In_SingleLayer.Repositary;
using KeyStone_CodeFirst_Approach_In_SingleLayer.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRoomRepositary, RoomRepositary>();
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddDbContext<HotelRoomContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
