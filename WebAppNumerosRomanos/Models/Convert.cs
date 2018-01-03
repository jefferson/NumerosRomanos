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



            if (number >= 1)
                return "I" + toRoman(number - 1);

            return String.Empty;
        }
    }
}