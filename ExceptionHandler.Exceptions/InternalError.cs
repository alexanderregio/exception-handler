namespace ExceptionHandler.Exceptions;

public class InternalError
{
    public readonly int StatusCode;
    public readonly string Message;

    public InternalError(int statusCode, string message)
    {
        StatusCode = statusCode;
        Message = message;
    }
}