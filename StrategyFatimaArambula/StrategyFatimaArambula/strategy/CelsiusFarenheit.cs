using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyFatimaArambula.strategy
{
    class CelsiusFarenheit : IStrategy
    {
        public double convertir(double temperatura)
        {
            return ((temperatura * (9 / 5)) + 32.0);
        }

        public override string ToString()
        {
            return "Celsius a Fahrenheit: ";
        }
    }
}
