using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FarenheitToCelsius(double farenheiht)
        {
            return ((farenheiht - 32) / 1.8);
        }

        public static double CelsiusToFarenheit(double celsius)
        {
            return ((celsius * 9) / 5) + 32;
        }
    }


}
