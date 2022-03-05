using ExceptionHandler.Exceptions;

namespace ExceptionHandler.Tests;

internal class ClassCoreError : CoreError
{
    public ClassCoreError(string key, string message)
        : base(key, message) { }

    public static ClassCoreError ErroDeNegocio
        => new(nameof(ErroDeNegocio), "Mensagem de erro de negócio");
}