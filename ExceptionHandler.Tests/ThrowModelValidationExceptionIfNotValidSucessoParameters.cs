using System.Collections;

namespace ExceptionHandler.Tests;

public class ThrowModelValidationExceptionIfNotValidSucessoParameters : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[]
        {
                new ClassModel { Identificador = null, NomeCompleto = nameof(ThrowModelValidationExceptionIfNotValidSucessoParameters), Codigo = long.MaxValue },
                "Identificador",
                "Informe o identificador"
        };

        yield return new object[]
        {
                new ClassModel { Identificador = Guid.Empty, NomeCompleto = "", Codigo = long.MaxValue },
                "NomeCompleto",
                "Informe o nome do completo"
        };

        yield return new object[]
        {
                new ClassModel { Identificador = Guid.Empty, NomeCompleto = nameof(ThrowModelValidationExceptionIfNotValidSucessoParameters), Codigo = 0 },
                "Codigo",
                $"Informe o código maior que 1 e menor que 9000000000000000000"
        };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}