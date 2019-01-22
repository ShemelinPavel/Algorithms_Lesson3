/*

Shemelin Pavel

2

Реализовать шейкерную сортировку

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
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
        /// шейкерная сортировка
        /// </summary>
        /// <param name="arr">массив</param>
        /// <returns>количество операций</returns>
        public static uint Shake_Sort(int[] arr)
        {
            void Swap( ref int a, ref int b )
            {
                int t = a;
                a = b;
                b = t;
            }

            uint counter = 0;
            int lMark = 0;
            int rMark = arr.Length - 1;
          
            while(lMark < rMark)
            {
                for (int i = lMark; i < rMark; i++)
                {
                    if (arr[i] > arr[i + 1] ) Swap( ref arr[i], ref arr[i + 1] );
                    counter++;
                }
                rMark--;

                for (int i = rMark; i > lMark; i--)
                {
                    if (arr[i] < arr[i - 1]) Swap( ref arr[i], ref arr[i - 1] );
                    counter++;
                }
                lMark++;
            }
            return counter;
        }

        static void Main( string[] args )
        {

            int[] array = new int[] { 17, 5, 3, 2, 15, 7, 1, 9, 12, 20 };

            Console.WriteLine( "Начальный массив:" );
            Print_Arr( array );

            uint res = Shake_Sort( array );

            Console.WriteLine( "\nОтсортированный массив:" );
            Print_Arr( array );
            Console.WriteLine( $"\nКоличество операций: {res}" );

            Console.ReadKey();
        }
    }
}
