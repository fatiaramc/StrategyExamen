using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyFatimaArambula.strategy
{
    class KelvinFarenheit : IStrategy
    {
        public double convertir(double temperatura)
        {
            return ((temperatura - 273.15) * (9 / 5)) + 32.0;
        }
        public override string ToString()
        {
            return "Kelvin a Fahrenheit: ";
        }
    }
}
