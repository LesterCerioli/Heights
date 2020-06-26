using System;
using System.ComponentModel.DataAnnotations;

namespace HeightConverter
{
    public class HeightConverter
    {
        public static double FootParameters(double foot)
        {
            return foot * 0.3048;
        }
    }
}
