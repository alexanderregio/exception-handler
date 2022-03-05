using ExceptionHandler.Exceptions;
using System;
using System.Runtime.Serialization;

namespace ExceptionHandler.Tests;

internal class ClassCoreException : CoreException<ClassCoreError>
{
    public override string Key => nameof(ClassCoreException);

    public ClassCoreException(params ClassCoreError[] errors) { AddError(errors); }

    private ClassCoreException() { }

    private ClassCoreException(string message) : base(message) { }

    private ClassCoreException(SerializationInfo info, StreamingContext context)
        : base(info, context) { }

    private ClassCoreException(string message, Exception innerException)
        : base(message, innerException) { }
}