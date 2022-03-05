using ExceptionHandler.Exceptions;
using Xunit;

namespace ExceptionHandler.Tests;

public class CoreErrorTests
{
    [Theory]
    [InlineData("TestKey", "TestMessage")]
    [Trait("Inheritance", "Sucesso")]
    public static void Inheritance_Sucesso(string expectedKey, string expectedMessage)
    {
        var coreError = new ClassCoreError("TestKey", "TestMessage");

        Assert.IsAssignableFrom<CoreError>(coreError);

        Assert.Equal(expectedKey, coreError.Key);
        Assert.Equal(expectedMessage, coreError.Message);
    }

    [Theory]
    [InlineData("ErroDeNegocio", "Mensagem de erro de negócio")]
    [Trait("Inheritance", "ChaveMensagem")]
    public static void Inheritance_ChaveMensagem(string expectedKey, string expectedMessage)
    {
        var coreError = ClassCoreError.ErroDeNegocio;

        Assert.IsAssignableFrom<CoreError>(coreError);

        Assert.Equal(expectedKey, coreError.Key);
        Assert.Equal(expectedMessage, coreError.Message);
    }
}