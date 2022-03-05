using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace ExceptionHandler.Exceptions;

public static class CoreExceptionMiddlewareExtensions
{
    public static void ConfigureCoreExceptionHandler
        (this IApplicationBuilder app, IWebHostEnvironment environment)
    {
        app.UseExceptionHandler(appError =>
        {
            appError.Run(async context =>
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";

                var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

                if (contextFeature != null)
                {
                    var coreException = contextFeature.Error as CoreException;

                    if (coreException is not null)
                    {
                        context.Response.StatusCode = (int)HttpStatusCode.BadRequest;

                        await context.Response.WriteAsJsonAsync(coreException);
                    }
                    else
                    {
                        var internalError = new InternalError
                            (context.Response.StatusCode, "Internal Server Error");

                        if (environment.IsDevelopment())
                        {
                            internalError = new InternalError
                                (context.Response.StatusCode, contextFeature.Error.Message);
                        }

                        await context.Response.WriteAsJsonAsync(internalError);
                    }
                }
            });
        });
    }
}