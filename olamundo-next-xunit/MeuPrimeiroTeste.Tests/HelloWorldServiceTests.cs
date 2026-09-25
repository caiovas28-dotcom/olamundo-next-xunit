using MeuPrimeiroTeste.App;

namespace MeuPrimeiroTeste.Tests;

public class HelloWorldServiceTests
{
   [Fact]
public void GerarSaudacao_DeveRetornarSaudacaoPadrao_QuandoNomeForNuloOuVazio()
{
// Arrange (Preparação)
var service = new HelloWorldService();
// Act (Ação)
var resultado = service.GerarSaudacao_DeveRetornarSucesso(null);
// Assert (Verificação)
Assert.Equal("Olá, Mundo!", resultado);
}
}
