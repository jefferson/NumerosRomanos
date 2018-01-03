using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace WebAppNumerosRomanos.Models
{
    public static class Convert
    {
        public static string toRoman(int number)
        {
            if ((number < 0) || (number) > 3999)
                return String.Empty;

            if (number < 1)
                return String.Empty;

            if (number >= 9)
                return "IX" + toRoman(number - 9);

            if (number >= 5)
                return "V" + toRoman(number - 5);

            if (number >= 4)
                return "IV" + toRoman(number - 4);

            if (number >= 1)
                return "I" + toRoman(number - 1);

            return String.Empty;
        }
    }
}