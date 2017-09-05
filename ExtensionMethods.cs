using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml.Serialization;

namespace MD.Extension
{
    /// <summary>
    /// This class is responsible of all extension methods for the application
    /// </summary>
    public static class ExtensionMethods 
    {
        /// <summary>
        /// Tries to convert the specified string representation of a logical value to its
        /// System.Boolean equivalent. A return value indicates the boolean value of the string or false if the convertion failed.
        /// </summary>
        /// <param name="self"></param>
        /// <returns>boolean value if self was converted successfully; otherwise, false</returns>
        public static bool ToBool(this string self)
        {
            bool.TryParse(self, out bool result);
            return result;
        }

        /// <summary>
        ///  Converts the string representation of a number in a specified style and culture-specific
        ///  format to its 32-bit signed integer equivalent. If conversion failed, returns 0 
        /// </summary>
        public static int ToInt(this string self)
        {
            int.TryParse(self, out int result);
            return result;
        }

        /// <summary>
        ///  Converts the string representation of a number in a specified style and culture-specific
        ///  format to its nullable 32-bit signed integer equivalent. If conversion failed, returns null 
        /// </summary>
        public static int? ToNullableInt(this string self)
        {
            int.TryParse(self, out int result);
            return result == 0 ? null : (int?)result;
        }

        /// <summary>
        ///  Converts the string representation of a number to its System.Decimal equivalent.
        /// </summary>
        public static decimal ToDecimal(this string self)
        {
            decimal.TryParse(self, out decimal result);
            return result;
        }
    }
}