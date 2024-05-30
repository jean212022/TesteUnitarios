using System.Security.Cryptography.X509Certificates;
using NewTalent.Entities;

namespace TesteNewTalent;

public class UnitTest1
{
    public Calculadora Construir()
    {
        return new Calculadora(DateTime.ParseExact("02/02/2020", "dd/MM/yyyy", null));
    }
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int val1, int val2, int resultado)
    {
        Calculadora calculadora = Construir();

        int resultadoFinal = calculadora.Somar(val1,val2);

        Assert.Equal(resultado, resultadoFinal);
    }
    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(4, 5, -1)]
    public void TesteSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calculadora = Construir();

        int resultadoFinal = calculadora.Subtrair(val1,val2);

        Assert.Equal(resultado, resultadoFinal);
    }
    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TesteMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora calculadora = Construir();

        int resultadoFinal = calculadora.Multiplicar(val1,val2);

        Assert.Equal(resultado, resultadoFinal);
    }
    [Theory]
    [InlineData(8, 2, 4)]
    [InlineData(10, 5, 2)]
    public void TesteDividir(int val1, int val2, int resultado)
    {
        Calculadora calculadora = Construir();

        int resultadoFinal = calculadora.Dividir(val1,val2);

        Assert.Equal(resultado, resultadoFinal);
    }
    [Fact]
    public void TestarDividirPorZero(){
        Calculadora calc = Construir();
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3,0));
    }
    [Fact]
    public void TestarHistorico(){
        Calculadora calc = Construir();

        calc.Somar(1,2);
        calc.Somar(2,8);
        calc.Somar(3,7);
        calc.Somar(4,1);
        
        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);  
    }
}
