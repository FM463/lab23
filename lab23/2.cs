/* 2.Напишите программу, в которой создайте байтовый флаг со значение "10000000" и путем  
 * выполнения битовых операций С++ измените его на "10010001".
 * 3.Измените эту программу, применив в ней личный класс с битовыми полями.
 * 4.Измените эту программу, применив в ней личное объединение с битовыми полями.
 * 5.Измените эту программу, применив в ней класс-шаблон из библиотеки STL.
 * 6.Измените программу п.1, используя класс-шаблон из библиотеки STL.
 * 7.Выполните распечатку всех битов байта, используя класс-шаблон из библиотеки STL.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23
{
    class _2
    {
        static void Main(string[] args)
        {
            int a = 1 << 7;
            Console.WriteLine(Convert.ToString(a, 2));

            a |= 1 << 0 | 1 << 4 | 1 << 7;
            Console.WriteLine(Convert.ToString(a, 2));
        }
    }
}
