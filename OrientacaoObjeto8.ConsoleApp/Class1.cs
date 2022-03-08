using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto8.ConsoleApp
{
    internal class Oleo
    {
        public double raio;
        public double altura;
        public double volume()
        {
            double ValorFinal = 3.14 * raio * raio * altura;
            return ValorFinal;
        }
    }
}
