using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTeste
{

    public CalculadoraOps ConstruirClasse()
    {
        DateTime data = DateTime.Now;
        CalculadoraOps calc = new(data);

        return calc;
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 6, 10)]
    [InlineData(7, 9, 16)]
    public void TestaSomar(int num1, int num2, int num3)
    {
        CalculadoraOps calc = ConstruirClasse();

        int resultadoEsperado = num3;
        int resultado = calc.Somar(num1, num2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(6, 4, 2)]
    [InlineData(16, 9, 7)]
    public void TestaSubtrair(int num1, int num2, int num3)
    {
        CalculadoraOps calc = ConstruirClasse();

        int resultadoEsperado = num3;
        int resultado = calc.Subtrair(num1, num2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 6, 24)]
    [InlineData(7, 9, 63)]
    public void TestaMultiplicar(int num1, int num2, int num3)
    {
        CalculadoraOps calc = ConstruirClasse();

        int resultadoEsperado = num3;
        int resultado = calc.Multiplicar(num1, num2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(2, 1, 2)]
    [InlineData(10, 2, 5)]
    [InlineData(21, 3, 7)]
    public void TestaDividir(int num1, int num2, int num3)
    {
        CalculadoraOps calc = ConstruirClasse();

        int resultadoEsperado = num3;
        int resultado = calc.Dividir(num1, num2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        CalculadoraOps calc = ConstruirClasse();

        //Verifica a divisão por zero
        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3, 0)
        );
    }

    [Fact]
    public void TestarHistorico()
    {
        CalculadoraOps calc = ConstruirClasse();

        calc.Somar(1, 2);
        calc.Somar(3, 5);
        calc.Somar(1, 11);
        calc.Somar(7, 44);

        var lista = calc.Historico();
        var tamanhoLista = 3;

        //testa se há elementos na lista passada
        Assert.NotEmpty(lista);
        Assert.Equal(tamanhoLista, lista.Count);
    }
}