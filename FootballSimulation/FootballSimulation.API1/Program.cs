using FootballSimulation.Business.Manager;
using FootballSimulation.Business.Services;
using FootballSimulation.DataAccess.DataAcces;
using FootballSimulation.DataAccess.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerDocument();
#region DataAccesLayer
builder.Services.AddScoped<IFixturesDal, FixturesDal>();
builder.Services.AddScoped<IMatchDal, MatchDal>();
builder.Services.AddScoped<ITeamDal, TeamDal>();
builder.Services.AddScoped<IWeekDal, WeekDal>();
#endregion



#region Business
builder.Services.AddScoped<IFixtureService, FixtureManager>();
builder.Services.AddScoped<IMatchService, MatchManager>();
builder.Services.AddScoped<ITeamService, TeamManager>();
builder.Services.AddScoped<IWeekService, WeekManager>();
#endregion



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
