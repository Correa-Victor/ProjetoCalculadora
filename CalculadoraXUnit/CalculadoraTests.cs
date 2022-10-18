using CalculadoraUtil;
using Xunit;

namespace CalculadoraXUnit
{
    public class CalculadoraTests : IDisposable
    {
        private Calculadora _calc;

        public CalculadoraTests()
        {
            _calc = new Calculadora();
        }

        [Fact]
        public void TestSomar()
        {
             Assert.Equal(4, _calc.Somar(2, 2));
        }

        [Fact]
        public void TestSubtarir()
        {
            Assert.Equal(0, _calc.Subtrair(2, 2));
        }

        [Fact]
        public void TestSomarExcepction()
        {
            Calculadora calc2 = new Calculadora(2);
            Assert.Equal(4, calc2.Somar(1, 1));
        }

        [Fact]
        public void TestMultplicar()
        {
            Assert.Equal(4, _calc.Multiplicar(2, 2));
        }

        [Fact]
        public void TestDividir()
        {
            Assert.Equal(1, _calc.Dividir(2, 2));
        }

        public void Dispose()
        {
            _calc = null;
        }
    }
}