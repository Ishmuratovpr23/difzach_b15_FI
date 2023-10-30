using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleVector
{
    internal class Program
    {


        static void Main(string[] args)
        {

            //a
            int[] vector1 = new int[3]; // массив для хранения координат первого вектора
            int[] vector2 = new int[3]; // массив для хранения координат второго вектора

            // ввод координат первого вектора
            Console.WriteLine("Введите координаты первого вектора:");
            for (int i = 0; i < vector1.Length; i++)
            {
                Console.Write($"Координата {i + 1}: ");
                vector1[i] = int.Parse(Console.ReadLine());
            }

            // ввод координат второго вектора
            Console.WriteLine("Введите координаты второго вектора:");
            for (int i = 0; i < vector2.Length; i++)
            {
                Console.Write($"Координата {i + 1}: ");
                vector2[i] = int.Parse(Console.ReadLine());
            }

            int[] sumVector = new int[3]; // массив для хранения суммы векторов

            // вычисление суммы векторов
            for (int i = 0; i < vector1.Length; i++)
            {
                sumVector[i] = vector1[i] + vector2[i];
            }

            // вывод результата
            Console.WriteLine("Сумма векторов:");
            Console.WriteLine($"({vector1[0]}, {vector1[1]}, {vector1[2]}) " +
                $"+ ({vector2[0]}, {vector2[1]}, {vector2[2]})" +
                $" = ({sumVector[0]}, {sumVector[1]}, {sumVector[2]})");




            //b

            Console.Write("Введите количество массивов: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Массив {i + 1}:");
                Console.Write("Введите размер массива: ");
                int size = int.Parse(Console.ReadLine());

                int[] mass = new int[size];
                Console.WriteLine("Введите элементы массива:");

                for (int j = 0; j < size; j++)
                {
                    mass[j] = int.Parse(Console.ReadLine());
                }

                int min = mass[0];
                int zCount = 0; //количество нулей

                for (int j = 1; j < size; j++)
                {
                    if (mass[j] < min)
                    {
                        min = mass[j];
                    }
                    else if (mass[j] == 0 && min != 0)
                    {
                        zCount++;
                    }
                }

                Console.WriteLine($"Минимальный элемент: {min}");
                Console.WriteLine($"Количество нулей после минимального элемента: {zCount}");

            }









        }




       


    }

}

