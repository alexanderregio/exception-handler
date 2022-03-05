using ExceptionHandler.Exceptions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.ConfigureCoreExceptionHandler(app.Environment);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
