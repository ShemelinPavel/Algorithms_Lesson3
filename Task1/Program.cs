/*

Shemelin Pavel

1

Попробовать оптимизировать пузырьковую сортировку.
Сравнить количество операций сравнения оптимизированной и неоптимизированной программы.
Написать функции сортировки, которые возвращают количество операций.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
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
        }

        /// <summary>
        /// пузырьковая сортировка массива
        /// </summary>
        /// <param name="arr">массив</param>
        /// <returns>число операций</returns>
        public static uint Sort_Arr( int[] arr )
        {

            void Swap( ref int a, ref int b )
            {
                int t = a;
                a = b;
                b = t;
            }

            uint counter = 0;

            for (uint i = 0; i < arr.Length; i++)
            {
                for (uint j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap( ref arr[j], ref arr[j + 1] );
                    }
                    counter++;
                }
            }

            return counter;
        }

        /// <summary>
        /// пузырьковая сортировка массива с оптимизацией
        /// </summary>
        /// <param name="arr">массив</param>
        /// <returns>число операций</returns>
        public static uint Sort_Arr_Optimum( int[] arr)
        {

            void Swap( ref int a, ref int b )
            {
                int t = a;
                a = b;
                b = t;
            }

            uint counter = 0;
            bool isSwap;

            for (uint i = 0; i < arr.Length; i++)
            {
                isSwap = false;

                for (uint j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap( ref arr[j], ref arr[j + 1] );
                        isSwap = true;
                    }
                    counter++;
                }

                if (!( isSwap )) break;
            }

            return counter;
        }

        static void Main( string[] args )
        {

            int[] arr1;
            uint res;

            int[] array = new int[] { 17, 5, 3, 2, 15, 7, 1, 9, 12, 20 };

            Console.WriteLine( "Начальный массив:" );
            Print_Arr( array );

            arr1 = (int[])array.Clone();

            res = Sort_Arr( arr1);

            Console.WriteLine( "\nОтсортированный массив (без оптимизации):" );
            Print_Arr( arr1 );
            Console.WriteLine( $"\nКоличество операций: {res}" );

            arr1 = (int[])array.Clone();

            res = Sort_Arr_Optimum( arr1 );

            Console.WriteLine( "\nОтсортированный массив (с оптимизацией):" );
            Print_Arr( arr1 );
            Console.WriteLine( $"\nКоличество операций: {res}" );

            Console.ReadKey();
        }
    }
}
