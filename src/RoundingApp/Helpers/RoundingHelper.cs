using System;
using System.Collections.Generic;
using System.Text;

namespace RoundingApp.Helpers
{
    public class RoundingHelper
    {
        public static int _defaultPrecision = 4;

        public static decimal Round(decimal value, int precision)
        {
            return Math.Round(value, precision, MidpointRounding.AwayFromZero);
        }

        public static decimal Round(decimal value)
        {
            return Round(value, _defaultPrecision);
        }
    }
}
