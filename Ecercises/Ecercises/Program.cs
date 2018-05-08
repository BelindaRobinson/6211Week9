using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 37, 11, 88, 25, 66, 55, 7, 41, 30, 86, 58, 90, 93, 59, 56, 93, 36, 66, 50, 63, 71, 24, 84, 21, 4, 65, 14, 92, 68, 54, 43, 71, 27, 27, 36, 49, 68, 47, 64, 53, 62, 86, 22, 62, 30, 61, 67, 24, 68, 3, 19, 70, 99, 76, 59, 9, 5, 48, 21, 21, 15, 87, 23, 46, 5, 81, 20, 20, 25, 90, 77, 42, 39, 92, 7, 46, 31, 60, 85, 66, 65, 88, 55, 30, 29, 14, 18, 17, 11, 38, 97, 84, 98, 25, 76, 28, 15, 48, 41, 25 };
            BubbleSort(num);
            int[] num1 = { 37, 11, 88, 25, 66, 55, 7, 41, 30, 86, 58, 90, 93, 59, 56, 93, 36, 66, 50, 63, 71, 24, 84, 21, 4, 65, 14, 92, 68, 54, 43, 71, 27, 27, 36, 49, 68, 47, 64, 53, 62, 86, 22, 62, 30, 61, 67, 24, 68, 3, 19, 70, 99, 76, 59, 9, 5, 48, 21, 21, 15, 87, 23, 46, 5, 81, 20, 20, 25, 90, 77, 42, 39, 92, 7, 46, 31, 60, 85, 66, 65, 88, 55, 30, 29, 14, 18, 17, 11, 38, 97, 84, 98, 25, 76, 28, 15, 48, 41, 25 };
            SelectionSort(num1);
            int[] num2 = { 37, 11, 88, 25, 66, 55, 7, 41, 30, 86, 58, 90, 93, 59, 56, 93, 36, 66, 50, 63, 71, 24, 84, 21, 4, 65, 14, 92, 68, 54, 43, 71, 27, 27, 36, 49, 68, 47, 64, 53, 62, 86, 22, 62, 30, 61, 67, 24, 68, 3, 19, 70, 99, 76, 59, 9, 5, 48, 21, 21, 15, 87, 23, 46, 5, 81, 20, 20, 25, 90, 77, 42, 39, 92, 7, 46, 31, 60, 85, 66, 65, 88, 55, 30, 29, 14, 18, 17, 11, 38, 97, 84, 98, 25, 76, 28, 15, 48, 41, 25 };
            InsertionSort(num2);

        }

        public static void InsertionSort(int[] _num)
        {
            int inner, temp;

            Console.WriteLine("Original Array List");
            DisplayContents(_num);

            Console.WriteLine("Inserion Sorted List");
            for (int i = 0; i < _num.Length-1; i++)
            {
                inner = i;
                temp = _num[i];
                while(inner >0 && _num[inner-1] >= temp)
                {
                    _num[inner] = _num[inner - 1];
                    inner -= 1;
                }
                _num[inner] = temp;
                DisplayContents(_num);
            }
        }

        public static void SelectSort(int[] _num)
        {
            int temp, min;

            Console.WriteLine("Original Array List");
            DisplayContents(_num);
        }
    }
}
