# hello-world-xunit

Lista de Exercícios — Garantia da Qualidade de Software (Gestão e Qualidade de Software).

**Aluno:** Patrick Oliveira Rabelo de Brito — RA 4251923386

## Sobre a solução

Aplicação console .NET que utiliza a classe `OlaMundo` com o método `ObterMensagem()`, que retorna a string `"Hello, World!"`. O resultado é impresso no terminal via `Console.WriteLine`.

O projeto de testes com xUnit instancia `OlaMundo`, chama `ObterMensagem()` e valida o retorno exato com `Assert.Equal("Hello, World!", resultado)` usando o atributo `[Fact]`.

## Tecnologias

- .NET 10
- xUnit

## Estrutura

```
MeuPrimeiroTeste.sln
MeuPrimeiroTeste.App/     # Projeto console (código de produção)
MeuPrimeiroTeste.Tests/   # Projeto de testes xUnit
```

## Como rodar

```bash
dotnet run --project MeuPrimeiroTeste.App
```

## Como testar

```bash
dotnet test
```

## Licença

MIT — veja [LICENSE](LICENSE).
