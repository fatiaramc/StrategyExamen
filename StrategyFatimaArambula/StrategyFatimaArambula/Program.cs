using System;
using StrategyFatimaArambula.strategy;

namespace StrategyFatimaArambula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la temperatura a convertir: ");
            double temperatura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el número de estrategia que desea utilizar\n" +
                    "1.- Celsius a Fahrenheit\n" +
                    "2.- Celsius a Kelvin\n" +
                    "3.- Fahrenheit a Celsius\n" +
                    "4.- Fahrenheit a Kelvin\n" +
                    "5.- Kelvin a Celsius\n" +
                    "6.- Kelvin a Fahrenheit\n" +
                    "7.- Cerrar programa\n");
            int op = Convert.ToInt32(Console.ReadLine());

            ConvertidorClass convertidor;
            while(op!=7)
            {
                switch (op)
                {
                    case 1:
                        convertidor = new ConvertidorClass(new CelsiusFarenheit(), temperatura);
                        break;
                    case 2:
                        convertidor = new ConvertidorClass(new CelsiusKelvin(), temperatura);
                        break;
                    case 3:
                        convertidor = new ConvertidorClass(new FarenheitCelsius(), temperatura);
                        break;
                    case 4:
                        convertidor = new ConvertidorClass(new FarenheitKelvin(), temperatura);
                        break;
                    case 5:
                        convertidor = new ConvertidorClass(new KelvinCelsius(), temperatura);
                        break;
                    case 6:
                        convertidor = new ConvertidorClass(new KelvinFarenheit(), temperatura);
                        break;
                    default:
                        convertidor = new ConvertidorClass(new CelsiusFarenheit(), temperatura);
                        break;
                }
                convertidor.convertir();
                Console.WriteLine(convertidor.ToString());
                Console.WriteLine("Ingrese el número de estrategia que desea utilizar\n" +
                    "1.- Celsius a Fahrenheit\n" +
                    "2.- Celsius a Kelvin\n" +
                    "3.- Fahrenheit a Celsius\n" +
                    "4.- Fahrenheit a Kelvin\n" +
                    "5.- Kelvin a Celsius\n" +
                    "6.- Kelvin a Fahrenheit\n" +
                    "7.- Cerrar programa\n");
                op = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
