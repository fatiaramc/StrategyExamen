using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyFatimaArambula.strategy
{
    class FarenheitKelvin : IStrategy
    {
        public double convertir(double temperatura)
        {
            return ((temperatura - 32) * (5 / 9)) + 273.15;
        }
        public override string ToString()
        {
            return "Fahrenheit a Kelvin: ";
        }
    }
}
