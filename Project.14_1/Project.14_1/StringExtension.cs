using System;
using System.Collections.Generic;
using System.Text;

namespace Project._14_1
{
    public static class StringExtension
    {
        // FIRST.
        // This method uses second parameter, but in Main method I can use any string as a parameter.

        public static string AddEllipsis(this string str, string changedString)
        {
            changedString = str.Substring(0, str.Length - 5) + "...";
            return changedString;
        }

        // SECOND.
        // This method doesn't use second parameter in itself, but it works the same

        public static string StringChange(this String str, object anything)
        {
            return str.Substring(0, str.Length - 5) + "...";
        }

        // THIRD.
        //I think the point of task is adding ellipsis in Main Method as parameter, than...
        public static string Changing(this String str, string ellipsis)
        {
            return str.Substring(0, str.Length - 5) + ellipsis;
        }
    }
}
