using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExample
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double imp = imposto.Calcula(orcamento);
            Console.WriteLine(imp);
        }

        public void DeclaraImposto(Orcamento orcamento, Imposto imposto)
        {
            double imp = imposto.Declara(orcamento);
            Console.WriteLine(imp);
        }
    }
}
