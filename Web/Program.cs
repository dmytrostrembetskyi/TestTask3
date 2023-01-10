using Core.Contexts;
using Core.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ArtsofteContext>(options =>
    options.UseMsSqlServer(builder.Configuration.GetConnectionString("ArtsofteConnection")));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();