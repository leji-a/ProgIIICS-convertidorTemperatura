using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioStatic
{
    static internal class convertidorTemperatura
    {
        static public double CelsiusAFahrenheit(double pCelsius)
        {
            double fahrenheit = 0;
            fahrenheit = (pCelsius * 9 / 5) + 32;
            return fahrenheit;
        }
        static public double FahrenheitACelsius(double pFahrenheit)
        {
            double celsius = 0;
            celsius = (pFahrenheit - 32) * 5/9;
            return celsius;
        }
    }
}
