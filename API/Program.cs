var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region Separate Registration
builder.Services.AddDomainServices();
builder.Services.AddInfrastructureServices(builder.Configuration);
#endregion

#region Registration
builder.Services.AddHttpContextAccessor();
#endregion

#region NLog
// NLog: Setup NLog for Dependency injection
builder.Logging.ClearProviders();
builder.Host.UseNLog();
#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
