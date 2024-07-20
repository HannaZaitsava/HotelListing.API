using HotelListing.API.Data;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connetionString = builder.Configuration.GetConnectionString("HotelListingDbConnectionString");
builder.Services.AddDbContext<HotelListeningDbContext>(options =>
{
    options.UseSqlServer(connetionString);
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => { 
    options.AddPolicy("AllowAll", 
        b => b.AllowAnyHeader().AllowAnyHeader().AllowAnyMethod()); 
});

builder.Host.UseSerilog((context, loggerConfig) => 
loggerConfig.WriteTo.Console().ReadFrom.Configuration(context.Configuration)
); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSerilogRequestLogging();
app.UseHttpsRedirection();
app.UseCors("AllowAll");


app.UseAuthorization();

app.MapControllers();

app.Run();
