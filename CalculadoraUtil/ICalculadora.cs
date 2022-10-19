using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraUtil
{
    public interface ICalculadora
    {
        public int Somar(int a, int b);
        public int Subtrair(int a, int b);
        public int Multiplicar(int a, int b);
        public int Dividir(int a, int b);
    }
}