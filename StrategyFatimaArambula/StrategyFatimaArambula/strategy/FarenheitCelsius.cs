using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyFatimaArambula.strategy
{
    class FarenheitCelsius : IStrategy
    {
        public double convertir(double temperatura)
        {
            return ((temperatura - 32) * (5 / 9));
        }
        public override string ToString()
        {
            return "Fahrenheit a Celsius: ";
        }
    }
}
