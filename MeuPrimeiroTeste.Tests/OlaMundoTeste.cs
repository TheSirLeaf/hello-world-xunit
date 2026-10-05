using MeuPrimeiroTeste.App;

namespace MeuPrimeiroTeste.Tests;

public class OlaMundoTeste
{
    [Fact]
    public void ObterMensagem_DeveRetornarHelloWorld()
    {
        var olaMundo = new OlaMundo();

        var resultado = olaMundo.ObterMensagem();

        Assert.Equal("Hello, World!", resultado);
    }
}
