using System;

namespace Sidorovaa.Lab6.Exercise2
{

    class Program
    {
        static void Main(string[] args)
        {
            const int size = 3;
            int[,] array = { { 5, 3, 8 }, { 1, 2, 7 }, { 9, 1, 4 } };

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            int MinValue = 0, indexI = 0, indexJ = 0;

            for (int i = 0; i < size; i++)
            {
                MinValue = array[i, 0];
                indexI = i;
                for (int j = 1; j < size; j++)
                {
                    if (array[i, j] < MinValue)
                    {
                        MinValue = array[i, j];
                        indexJ = j;
                    }
                }


                bool check = true;
                for (int count = 0; count < size; count++)
                {
                    if (count == indexI) continue;
                    if (array[indexI, indexJ] <= array[count, indexJ])
                    {
                        Console.WriteLine("В строке " + (indexI + 1) + " нет седловой точки");
                        check = false;
                        break;
                    }
                }

                if (check)
                {
                    Console.WriteLine("В строке " + (indexI + 1) + " есть седловая точка с индексами(" + indexI + ";" + indexJ + ")");
                }
            }
        }

    }
}
