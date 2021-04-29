using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExample
{
    public interface Imposto
    {
        double Calcula(Orcamento orcamento);
        double Declara(Orcamento orcamento);
    }
}
