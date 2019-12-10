using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyFatimaArambula.strategy
{
    interface IStrategy
    {
        double convertir(double temperatura);
        string ToString();
    }
}
