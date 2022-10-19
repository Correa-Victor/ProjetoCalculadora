namespace CalculadoraUtil
{
    public class Calculadora : ICalculadora
    {
        private int _limiteMinimo;

        public Calculadora(int limiteMinimo = 0)
        {
            _limiteMinimo = limiteMinimo;
        }

        public int Somar(int a, int b)
        {
            if (a < _limiteMinimo || b < _limiteMinimo)
            {
                throw new ArgumentOutOfRangeException("O Arumento está abaixo do limite mínimo.");
            }
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            if (a < _limiteMinimo || b < _limiteMinimo)
            {
                throw new ArgumentOutOfRangeException("O Arumento está abaixo do limite mínimo.");
            }
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            if (a < _limiteMinimo || b < _limiteMinimo)
            {
                throw new ArgumentOutOfRangeException("O Arumento está abaixo do limite mínimo.");
            }
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            if (a < _limiteMinimo || b < _limiteMinimo)
            {
                throw new ArgumentOutOfRangeException("O Arumento está abaixo do limite mínimo.");
            }
            return a / b;
        }
    }
}