using CalculadoraUtil;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraNUnit
{
    [TestFixture]
    public  class CalculadoraTests
    {
        private Calculadora _calc;

        [SetUp]
        public void SetUp()
        {
            _calc = new Calculadora();
        }


        [Test]
        public void TestSomar()
        {
            Assert.AreEqual(4, _calc.Somar(2, 2));
        }

        [TearDown]
        public void TearDown()
        {
            _calc = null;
        }
    }
}
