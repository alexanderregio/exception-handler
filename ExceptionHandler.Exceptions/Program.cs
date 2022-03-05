using ExceptionHandler.Exceptions;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build(); 

app.ConfigureCoreExceptionHandler(app.Environment);
app.Run();