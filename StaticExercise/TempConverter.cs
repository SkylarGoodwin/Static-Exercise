using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahreinhietToCelsius(double fahreinhiet)
        {
            return (fahreinhiet - 32) / 1.8;
        }
        public static double CelsiusToFahreinhiet(double celsius)
        {
            return (celsius * 9) / 5 + 32;
        }
    }
}
