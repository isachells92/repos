using System;

namespace struct_o_datatyp
{
    class myDataType
    {
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myDataType my = new myDataType();
            my.Age = 58;
            Console.WriteLine(my.Age);
            DoubleAge(my);
            Console.WriteLine(my.Age);
    }

        private static void DoubleAge(myDataType myParam)
        {
            
            myParam.Age *= 2;
        }
    }
}
