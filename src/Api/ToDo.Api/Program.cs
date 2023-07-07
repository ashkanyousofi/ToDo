
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region Base Config App
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#endregion

#region Service Registration
builder.Services.ConfigureApplicationSerivces();
builder.Services.ConfigureInfrastructureSerivces(builder.Configuration);
builder.Services.ConfigurePersistenceSerivces(builder.Configuration);
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
