using ExceptionHandler.Exceptions;
using Xunit;

namespace ExceptionHandler.Tests;

public class ModelValidatorTests
{
    [Theory]
    [ClassData(typeof(ThrowModelValidationExceptionIfNotValidSucessoParameters))]
    [Trait("ThrowModelValidationExceptionIfNotValid", "Sucesso")]
    public static void ThrowModelValidationExceptionIfNotValid_Sucesso
        (ClassModel classModel, string modelValidationKeyExpected, string modelValidationMessageExpected)
    {
        var modelValidationException = Assert.Throws<ModelValidationException>
            (() => ModelValidator.ThrowModelValidationExceptionIfNotValid(classModel));

        Assert.IsAssignableFrom<CoreException>(modelValidationException);
        Assert.NotNull(modelValidationException);
        Assert.Single(modelValidationException.Errors);

        var modelValidationError = modelValidationException.Errors.Single();

        Assert.Equal(modelValidationKeyExpected, modelValidationError.Key);
        Assert.Equal(modelValidationMessageExpected, modelValidationError.Message);
    }
}