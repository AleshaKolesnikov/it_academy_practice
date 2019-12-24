using System;

namespace Practice_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
        public static void Task1()
        {
            //массив всегда будет иметь содержимое по умолчанию

        }
        public static void Task2()
        {
            object[] array = new object[3];
            int num1 = 32;
            array[0] = num1;
            array[1] = 'A';
            array[2] = "Hello";
            foreach (object output in array)
            {
                Console.WriteLine(output);
            }
            int num2 = (int)array[0];
            int num3 = 10;
            array[0] = num2 + num3;
            string str1 = (string)array[2];
            string str2 = " guys";
            array[2] = str1 + str2;
            foreach (object output2 in array)
            {
                Console.WriteLine(output2);
            }
        }
    }
}
