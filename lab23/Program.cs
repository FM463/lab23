/*lab20 (Библиотека шаблонов STL) - в C# нету шаблонов, а тем более шаблонов STL. 
 * 1.Напишите программу в которой обьявите короткое целое со значением  12345 и определите путем  
 * выполнения битовых операций С++ установлены  ли в нем 1, 7 и 10 биты.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 12345;
            int mask_1 = 1 << 1;
            int mask_7 = 1 << 7;
            int mask_10 = 1 << 10;

            Console.WriteLine($"{number} = {Convert.ToString(number, 2)}");
            Console.WriteLine($"первый бит = {Convert.ToString(mask_1, 2)}, {((number & mask_1) == 0 ? "не" : "")} установлен.");
            Console.WriteLine($"седьмой бит = {Convert.ToString(mask_7, 2)}, {((number & mask_7) == 0 ? "не" : "")} установлен.");
            Console.WriteLine($"десятый бит = {Convert.ToString(mask_10, 2)}, {((number & mask_10) == 0 ? "не" : "")} установлен.");
        }
    }
} //Здесь предполагается, что биты нумеруются с нуля. То-есть бит под индексом 1 - это будет второй бит справа.
  //Если нужно чтобы биты нумеровались с единицы, то можно заменить 1, 7, 10 на 0, 6, 9 в инициализации масок.
