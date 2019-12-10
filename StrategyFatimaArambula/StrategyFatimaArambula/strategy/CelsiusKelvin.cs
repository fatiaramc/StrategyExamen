using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyFatimaArambula.strategy
{
    class CelsiusKelvin : IStrategy
    {
        public double convertir(double temperatura)
        {
            return temperatura + 273.15;
        }
        public override string ToString()
        {
            return "Celsius a Kelvin: ";
        }
    }
}
