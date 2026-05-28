using MeuProjeto;
using Xunit;
public class CalculadoraTests
{
    private readonly Calculadora _calc = new();

    [Fact]
    public void Soma_DeveRetornarResultadoCorreto()
    {
        Assert.Equal(7, _calc.Soma(3, 4));
    }

    [Fact]
    public void Subtracao_DeveRetornarResultadoCorreto()
    {
        Assert.Equal(1, _calc.Subtracao(5, 4));
    }

    [Fact]
    public void Divisao_DeveRetornarResultadoCorreto()
    {
        // INSTRUÇÃO: Para gerar o Run #1 (erro proposital), troque 5 por 999 aqui,
        // faça o push, aguarde o pipeline falhar, depois volte para 5 e faça outro push.
        Assert.Equal(999, _calc.Divisao(10, 2));
    }
}
