using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExample
{
    public class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento) => orcamento.Valor * 0.1;

        public double Declara(Orcamento orcamento) => orcamento.Valor;
    }
}
