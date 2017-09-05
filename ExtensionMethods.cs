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
    }
}