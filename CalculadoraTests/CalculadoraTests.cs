using CalculadoraUtil;

namespace CalculadoraTests
{
    [TestClass]
    public class CalculadoraTests
    {
        private Calculadora _calc;

        [TestInitialize]
        public void SetUp()
        {
            _calc = new Calculadora();
        }

        [TestMethod]
        public void TestSomar()
        {
            Assert.AreEqual(4, _calc.Somar(2, 2));
        }

        [TestMethod]
        public void TestSubtarir()
        {
            Assert.AreEqual(0, _calc.Subtrair(2, 2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSomarExcepction()
        {
            Calculadora calc2 = new Calculadora(2);
            calc2.Somar(1, 1);
        }

        [TestMethod]
        public void TestMultplicar()
        {
            Assert.AreEqual(4, _calc.Multiplicar(2, 2));
        }

        [TestMethod]
        public void TestDividir()
        {
            Assert.AreEqual(1, _calc.Dividir(2, 2));
        }

        [TestCleanup]
        public void CleanUp()
        {
            _calc = null;
        }
    }
}