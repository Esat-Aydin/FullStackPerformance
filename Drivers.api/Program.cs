using Drivers.api.Configurations;
using Drivers.api.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var dbConfig = new DatabaseConfig();
var dbSettings = new DatabaseSettings();
builder.Configuration.GetSection("DatabaseConfig").Bind(dbConfig); // bind db config with appsettings properties.
builder.Configuration.GetSection("SQLiteDatabase").Bind(dbSettings); // bind db settings with appsettings properties.

builder.Services.AddDbContext<AppDbContext>(options => {
    options.UseSqlite(dbSettings.ConnectionString, action => {
        action.CommandTimeout(dbConfig.timeoutTime);
    });

    if(builder.Environment.IsDevelopment()){
        options.EnableDetailedErrors(dbConfig.detailedError);
        options.EnableSensitiveDataLogging(dbConfig.sensitiveDataLogging);
    }
    
}); // SQLite

builder.Services.AddScoped<DriverService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// add CORS rule
builder.Services.AddCors(options =>
{
    options.AddPolicy("AngularClient", policy => 
    {
        policy.WithOrigins("ClientSideConfig:AngularClientUrl")
            .AllowAnyHeader()
            .AllowAnyMethod();
    }
    );
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

app.UseCors("AngularClient");

app.Run();
