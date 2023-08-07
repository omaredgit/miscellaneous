using Microsoft.EntityFrameworkCore;
using miscellaneous.Data;
using miscellaneous.EnvVariables;
using miscellaneous.Services.UserService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ConfigureServices(builder.Services);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//var connectionString = builder.Configuration.GetConnectionString("PostgreSQLConnection");
EnvVariables envVariables = new(StageEnvironments.Dev);
var connectionString  = envVariables.Connectionstring;


builder.Services.AddDbContext<OfficeDB>(options => options.UseNpgsql(connectionString));

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

void ConfigureServices(IServiceCollection services)
{
    services.AddTransient<IUserService, UserService>();
} 