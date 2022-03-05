using System.Runtime.Serialization;

namespace ExceptionHandler.Exceptions;

public class ModelValidationException : CoreException<ModelValidationError>
{
    public override string Key => nameof(ModelValidationException);

    public ModelValidationException(params ModelValidationError[] errors) { AddError(errors); }

    private ModelValidationException() { }

    private ModelValidationException(string message) : base(message) { }

    private ModelValidationException(SerializationInfo info, StreamingContext context)
        : base(info, context) { }

    private ModelValidationException(string message, Exception innerException)
        : base(message, innerException) { }
}