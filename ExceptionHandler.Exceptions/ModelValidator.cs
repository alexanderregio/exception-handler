using System.ComponentModel.DataAnnotations;

namespace ExceptionHandler.Exceptions;

public static class ModelValidator
{
    public static void ThrowModelValidationExceptionIfNotValid<T>(T model)
    {
        var validationContext = new ValidationContext(model);
        var validationResults = new List<ValidationResult>();
        var isValid = Validator.TryValidateObject
            (model, validationContext, validationResults, true);

        if (!isValid)
        {
            var errors = validationResults
                .Select(v => new ModelValidationError(v.MemberNames?.FirstOrDefault(), v.ErrorMessage))
                .ToArray();

            throw new ModelValidationException(errors);
        }
    }
}