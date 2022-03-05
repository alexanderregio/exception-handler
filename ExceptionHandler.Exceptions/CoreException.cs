using System.Runtime.Serialization;

namespace ExceptionHandler.Exceptions;

public abstract class CoreException : Exception
{
    public abstract string Key { get; }

    protected ICollection<CoreError> errors = new List<CoreError>();

    public IEnumerable<CoreError> Errors => errors;

    protected CoreException() { }

    protected CoreException(string message) : base(message) { }

    protected CoreException(SerializationInfo info, StreamingContext context)
        : base(info, context) { }

    protected CoreException(string message, Exception innerException)
        : base(message, innerException) { }
}

public abstract class CoreException<T> : CoreException where T : CoreError
{
    protected CoreException() { }

    protected CoreException(string message) : base(message) { }

    protected CoreException(SerializationInfo info, StreamingContext context)
        : base(info, context) { }

    protected CoreException(string message, Exception innerException)
        : base(message, innerException) { }

    public void AddError(params T[] errors)
    {
        foreach (var error in errors)
        {
            this.errors.Add(error);
        }
    }
}