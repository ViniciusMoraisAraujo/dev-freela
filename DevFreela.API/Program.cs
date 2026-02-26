using DevFreela.Application.Services.Interfaces;
using DevFreela.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
ConfigureServices(builder);


app.Run();

 void ConfigureServices(WebApplicationBuilder applicationBuilder)
{
    applicationBuilder.Services.AddControllers();
    applicationBuilder.Services.AddEndpointsApiExplorer();
    applicationBuilder.Services.AddSwaggerGen();
    applicationBuilder.Services.AddSingleton<DevFreelaDbContext>();
    applicationBuilder.Services.AddScoped<IProjectService, IProjectService>();
}

