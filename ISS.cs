using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExample
{
    public class ISS : Imposto
    {
        public double Calcula(Orcamento orcamento) => orcamento.Valor * 0.06;
        public double Declara(Orcamento orcamento) => orcamento.Valor;
    }
}
