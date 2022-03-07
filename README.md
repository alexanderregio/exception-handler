# Exception Handler
É uma biblioteca destinada para tratamento de exceções.

## CoreError
Abstração de erros que serão gerados no core da aplicação.

## CoreException
Abstração da exceção disparada pelo core da aplicação.
Contém a lista de erros do tipo CoreError.

## InternalError
Classe que encapsula erros técnicos contendo o código do status e a mensagem.

## CoreExceptionMiddlewareExtensions
Middleware para realizar o tratamento de exceções do tipo CoreException e Exception.
Deve ser chamado durante as configurações da aplicação.

```
app.ConfigureCoreExceptionHandler(app.Environment);
```
