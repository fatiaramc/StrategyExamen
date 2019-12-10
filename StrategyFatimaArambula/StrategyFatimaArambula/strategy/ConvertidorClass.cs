using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyFatimaArambula.strategy
{
    class ConvertidorClass
    {
        private readonly IStrategy _strategy;
        private readonly double _temperatura;
        public double Resultado { get; set; }

        public ConvertidorClass(IStrategy strategy, double temperatura)
        {
            _strategy = strategy;
            _temperatura = temperatura;
        }

        public void convertir()
        {
            Resultado = _strategy.convertir(_temperatura);
        }

        public override string ToString()
        {
            return "--------------------------\n" +
                "RESULTADO: " + _temperatura + " " + _strategy.ToString() + Resultado
                + "\n--------------------------\n";
        }
    }
}
