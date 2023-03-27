var builder = WebApplication.CreateBuilder(args);

builder.Configuration.ConfigureEnvironment(builder.Environment);

builder.Services
    .InstallServices(
        builder.Configuration,
        typeof(IServiceInstaller).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopmentEnv())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CMS SERVICE v1"));
}

#region DATABASE INIT AND SEED

// Initialize and seed database.
using var scope = app.Services.CreateScope();
var initializer = scope.ServiceProvider.GetRequiredService<ApplicationDbContextInitializer>();
await initializer.InitializeAsync();
await initializer.SeedAsync();
#endregion

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseCors("Open");

app.MapControllers();

app.Run();
