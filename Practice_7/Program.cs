using System;

namespace Practice_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }
        public static void Task1()
        {
            // Оказывается, можно)
            int[] array = new int[0];
            int arrayLength = array.Length;
            Console.WriteLine($"Длинна массива - {arrayLength}");

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
        public static void Task3()
        {
            int[] array = new int[13];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next();
            }
            int current = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        current = array[i];
                    }
                }
            }
            foreach (int nums in array)
            {
                Console.WriteLine(nums);
            }
            Console.WriteLine($"Наибольшее число - {current}");
        }
        public static void Task4()
        {

        }
    }
}
