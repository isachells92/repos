using System;
using System.Security.Cryptography.X509Certificates;

namespace TestClass
{
    class TestBaseClass
    {
        static void Main(string[] args)
        {
            SubClass instance = new SubClass(58, "Håkan");
        }
        class BaseClass
        {
            public string StringValue { get; set; }
            public BaseClass(string stringvalue)
            {
                StringValue = stringvalue;
            }

            public BaseClass()
            {
                StringValue = "N/A";
            }
        }
        class SubClass : BaseClass
        {
            public int IntValue { get; set; }
            public SubClass(int intValue, string stringValue) : base(stringValue)// Här behövs inte Base då en parameterlös konstructor har skapats.
            {
                IntValue = intValue;
            }
}
        }
    }

