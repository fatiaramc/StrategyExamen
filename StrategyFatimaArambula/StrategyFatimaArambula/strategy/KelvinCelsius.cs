using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyFatimaArambula.strategy
{
    class KelvinCelsius : IStrategy
    {
        public double convertir(double temperatura)
        {
            return temperatura - 273.15;
        }
        public override string ToString()
        {
            return "Kelvin a Celsius: ";
        }
    }
}
