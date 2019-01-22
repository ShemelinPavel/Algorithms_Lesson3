/*

Shemelin Pavel

3

Реализовать бинарный алгоритм поиска в виде функции, которой передаётся отсортированный массив.
Функция возвращает индекс найденного элемента или –1, если элемент не найден.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        /// <summary>
        /// печать содержимого массива
        /// </summary>
        /// <param name="arr">массив</param>
        public static void Print_Arr( int[] arr )
        {
            foreach (var item in arr)
            {
                Console.Write( $" {item}" );
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="seekNumber">искомое число</param>
        /// <param name="arr">упорядоченный массив</param>
        /// <param name="counter">счетчик количества операций</param>
        /// <returns>индекс числа в массиве</returns>
        public static int BinarySeek( int seekNumber, int[] arr, out int counter )
        {
            int lowIndex = 0, midIndex = 0;
            int highIndex = arr.Length - 1;
            counter = 0;

            while (lowIndex <= highIndex)
            {
                counter++;

                midIndex = ( lowIndex + highIndex ) / 2;

                if (seekNumber < arr[midIndex]) highIndex = midIndex - 1;
                else if (seekNumber > arr[midIndex]) lowIndex = midIndex + 1;
                else return midIndex;
            }

            return -1;
        }

        static void Main( string[] args )
        {

            int[] array = new int[] { 1, 5, 10, 42, 56, 67, 78, 88, 91, 105, 117, 125 };
            Console.WriteLine( "Начальный массив:" );
            Print_Arr( array );

            int number = 105;

            int res = BinarySeek( number, array, out int counter1 );

            Console.WriteLine( $"\nПоиск значения {number} в массиве. Индекс {res}. Количество операций {counter1}" );

            number = 10;

            res = BinarySeek( number, array, out int counter2 );

            Console.WriteLine( $"\nПоиск значения {number} в массиве. Индекс {res}. Количество операций {counter2}" );

            number = 40;

            res = BinarySeek( number, array, out int counter3 );

            Console.WriteLine( $"\nПоиск значения {number} в массиве. Индекс {res}. Количество операций {counter3}" );

            Console.ReadKey();
        }
    }
}
