namespace ExceptionHandler.Exceptions;

public class CoreExceptionDto
{
    /// <summary>
    /// Chave da exceção
    /// </summary>
    public string Key { get; set; }

    public IEnumerable<CoreErrorDto> Errors { get; set; }
}

public class CoreErrorDto
{
    /// <summary>
    /// Chave do erro
    /// </summary>
    public string Key { get; set; }

    /// <summary>
    /// Mensagem do erro
    /// </summary>
    public string Message { get; set; }
}
