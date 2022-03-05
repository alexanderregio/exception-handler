using ExceptionHandler.Exceptions;
using ExceptionHandler.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExceptionHandler.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExceptionsController : ControllerBase
{
    private readonly Example example;

    public ExceptionsController()
    {
        example = new Example
        {
            Identificador = Guid.Empty,
            NomeCompleto = nameof(ExceptionsController),
            Codigo = long.MaxValue
        };
    }

    [HttpGet("CoreException")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(CoreException), StatusCodes.Status400BadRequest)]
    public IActionResult GetMethod_CoreException()
    {
        ModelValidator.ThrowModelValidationExceptionIfNotValid(new Example
        {
            Identificador = null,
            NomeCompleto = "",
            Codigo = 0
        });

        return Ok();
    }

    [HttpGet("InternalError")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(InternalError), StatusCodes.Status500InternalServerError)]
    public IActionResult GetMethod_InternalError()
    {
        var numerador = 10;
        var denominador = 0;

        var resultado = numerador / denominador;

        return Ok();
    }
}