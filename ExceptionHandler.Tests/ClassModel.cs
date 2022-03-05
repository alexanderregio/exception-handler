using System.ComponentModel.DataAnnotations;

namespace ExceptionHandler.Tests;

public class ClassModel
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Informe o identificador")]
    public Guid? Identificador { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Informe o nome do completo")]
    public string NomeCompleto { get; set; }

    [Range(1, long.MaxValue, ErrorMessage = "Informe o código maior que {1} e menor que 9000000000000000000")]
    public long Codigo { get; set; }
}