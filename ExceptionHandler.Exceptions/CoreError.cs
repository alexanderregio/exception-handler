namespace ExceptionHandler.Exceptions;

public abstract class CoreError
{
    public readonly string Key;

    public readonly string Message;

    protected CoreError(string key, string message)
    {
        Key = key;
        Message = message;
    }
}