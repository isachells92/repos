using System;
using System.Collections.Generic;
using System.Text;

namespace ExtentionMethods
{
    static class ExtensionMethods   // allting ska vara statiskt här (Extension methods can only exist in a static class)
    {
        static public bool isOdd(this int i) // dekorera med "this" på första parametern, så att den blir en extension method.
        {
            return i % 2 == 1;
        }
        static public int ToInt(this string s)    // kolla om det går att konvertera till int - med bool.
        {
            int.TryParse(s, out int i);
            return i;
        }

    }

}
