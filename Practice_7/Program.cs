using System;

namespace Practice_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
        public static void Task1()
        {
            // Оказывается, можно)
            Console.WriteLine("Task1:");
            int[] array = new int[0];
            int arrayLength = array.Length;
            Console.WriteLine($"Длинна массива - {arrayLength}");

        }
        public static void Task2()
        {
            Console.WriteLine("\nTask2:");
            object[] array = new object[3];
            int num1 = 32;
            array[0] = num1;
            array[1] = 'A';
            array[2] = "Hello";
            foreach (object output in array)
            {
                Console.WriteLine(output);
            }
            array[0] = (int)array[0] + 10;
            array[2] = array[2] + " guys";
            foreach (object output2 in array)
            {
                Console.WriteLine(output2);
            }
        }
        public static void Task3()
        {
            Console.WriteLine("\nTask3:");
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
            Console.WriteLine("\nTask4:");
            short num1 = 10;
            object box1 = num1;
            sbyte unbox = (sbyte)(short)box1;
            Console.WriteLine(unbox);
            Console.WriteLine(unbox.GetType());

        }
    }
}
