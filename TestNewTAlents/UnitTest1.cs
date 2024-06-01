using NewTalents;

namespace TestNewTAlents
{
    public class UnitTest1
    {
        Calculadora calc = new Calculadora();

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 2, 4)]
        [InlineData(4, 5, 9)]
        [InlineData(7, 8, 15)]
        [InlineData(15, 23, 38)]
        [InlineData(145, 255, 400)]
        public void TestSomar(int val1, int val2, int resultado)
        {
            int resultadoCalculadora = calc.Somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 1)]
        [InlineData(2, 4, 2)]
        [InlineData(4, 5, 1)]
        [InlineData(7, 8, 1)]
        [InlineData(15, 23, 8)]
        [InlineData(145, 255, 110)]
        public void TestSubtrair(int val1, int val2, int resultado)
        {
            int resultadoCalculadora = calc.Subtrair(val2, val1);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(4, 5, 20)]
        [InlineData(7, 8, 56)]
        [InlineData(15, 23, 345)]
        [InlineData(145, 255, 36975)]
        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            int resultadoCalculadora = calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(2, 2, 1)]
        [InlineData(4, 8, 2)]
        [InlineData(7, 56, 8)]
        [InlineData(15, 330, 22)]
        [InlineData(145, 1450, 10)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            int resultadoCalculadora = calc.Dividir(val2, val1);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestDividirPorZero()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3,0));
        }

        [Fact]
        public void TestHistorico()
        {
            calc.Somar(1, 2);
            calc.Somar(3, 2);
            calc.Somar(5, 2);
            calc.Somar(7, 2);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}