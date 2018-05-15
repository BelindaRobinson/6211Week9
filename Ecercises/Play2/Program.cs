using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Play2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 7, 45, 88, 25, 66, 55 };
            InsertionSort(num);

        }
        public static void InsertionSort(int[] _num)
        {
            int inner, temp;
            Console.WriteLine("Original Array List");
            displayContents(_num);

            Stopwatch MyTimer = new Stopwatch();
            MyTimer.Start();

            Console.WriteLine("Insertion Sorted List");
            for (int i = 1; i <= _num.Length - 1; i++)
            {
                inner = i;
                temp = _num[i];
                while (inner > 0 && _num[inner - 1] >= temp)
                {
                    _num[inner] = _num[inner - 1];
                    inner -= 1;
                }

                Console.WriteLine("timetaken:" + MyTimer.Elapsed);
                Console.ReadLine();

                _num[inner] = temp;
                displayContents(_num);
            }
        }
        public static void displayContents(int[] _num)

        {
            for (int i = 0; i <= _num.Length - 1; i++)
            {
                Console.Write(_num[i] + " ");
            }
            Console.WriteLine();
        }
    }
    
}
