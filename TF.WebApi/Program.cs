using TF.WebApi.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDataBaseConfiguration(builder.Configuration);

builder.Services.AddDependencyInjectionConfiguration();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseDatabaseConfiguration(); // Se for para produção, o melhor é rodar as migrações antes do deploy, como parte do processo de CI/CD.

app.UseAuthorization();

app.MapControllers();

app.Run();
