using ExceptionHandler.Exceptions;
using System.Linq;
using Xunit;

namespace ExceptionHandler.Tests;

public class CoreExceptionTests
{
    [Theory]
    [InlineData("ErroDeNegocio", "Mensagem de erro de negócio")]
    [Trait("Throw", "Sucesso")]
    public static void Throw_Sucesso(string expectedKey, string expectedMessage)
    {
        var coreException = Assert.ThrowsAny<CoreException>
            (() => throw new ClassCoreException(ClassCoreError.ErroDeNegocio));

        Assert.IsAssignableFrom<CoreException>(coreException);
        Assert.NotEmpty(coreException.Errors);

        var coreError = coreException.Errors.First();

        Assert.Equal(expectedKey, coreError.Key);
        Assert.Equal(expectedMessage, coreError.Message);
    }
}