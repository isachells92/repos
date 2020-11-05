using System;

namespace ValueTypeVsRefferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass aClass = new MyClass();
            // aClass.Integers = new int[10]; Cannot access cause private set: 
            aClass.Integers[0] = 10;
            Console.WriteLine(aClass.Integers[0]);

            ManipulateArray(aClass.Integers);
            
        }
        public static void ManipulateArray(int[] ints)
        {
            
        }
    }

    class MyClass
    {
        public int[] Integers { get; private set; } =new int [] { 4, 32, 355, 876 };
    }
}
