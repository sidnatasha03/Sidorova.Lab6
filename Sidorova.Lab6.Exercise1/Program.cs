using System;

namespace Sidorovaa.Lab6.Exercise1
{

    class Program
    {
        static void Main(string[] args)
        {
            int c = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[c];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
            } 
            //создание массива

            //цикл вывести
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("_____________________");
            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] < 0)
                    array[i] = 3;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}
