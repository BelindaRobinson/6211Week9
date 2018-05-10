using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Ecercises
{
    class Program
    {
        

        static void Main(string[] args)
            
        {
            
            int[] num = { 7, 45, 88, 25, 66, 55};
            BubbleSort(num);
            int[] num1 = { 7, 45, 88, 25, 66, 55};
            SelectionSort(num1);
            int[] num2 = { 7, 45, 88, 25, 66, 55};
            InsertionSort(num2);

        }

        public static void InsertionTiming(int[]_num)
        {
            Stopwatch MyTimer = new Stopwatch();
            MyTimer.Start();
            InsertionSort(_num);
            MyTimer.Stop();
            Console.WriteLine("timetaken:" + MyTimer.Elapsed);
            Console.ReadLine();
            
        }

        public static void SelectionTiming(int[] _num)
        {
            Stopwatch MyTimer = new Stopwatch();
            MyTimer.Start();
            SelectionSort(_num);
            MyTimer.Stop();
            Console.WriteLine("timetaken:" + MyTimer.Elapsed);
            Console.ReadLine();
        }

        public static void BubbleTiming(int[] _num)
        {
            Stopwatch MyTimer = new Stopwatch();
            MyTimer.Start();
            BubbleSort(_num);
            MyTimer.Stop();
            Console.WriteLine("timetaken:" + MyTimer.Elapsed);
            Console.ReadLine();
        }

        public static void InsertionSort(int[] _num)
        {
            int inner, temp;
            Console.WriteLine("Original Array List");
            displayContents(_num);

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
                _num[inner] = temp;
                displayContents(_num);
            }
        }
        
        public static void SelectionSort(int[] _num)
        {
            int temp, min;

            Console.WriteLine("Original Array List");
            displayContents(_num);

            Console.WriteLine("Selection Sorted List");
            for (int i = 0; i < _num.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < _num.Length; j++)
                {
                    if (_num[j] < _num[min])
                    {
                        min = j;
                    }
                }
                displayContents(_num);
                if (min != 1)
                {
                    temp = _num[i];
                    _num[i] = _num[min];
                    _num[min] = temp;
                }
            }
            displayContents(_num);
        }


        public static void BubbleSort(int[] _num)
        {
            int temp;

            Console.WriteLine("Original Array List");
            displayContents(_num);

            Console.WriteLine("Bubble Sorted List");
            for (int i = 0; i < _num.Length; i++)
            {
                for (int j = 0; j < _num.Length - 1; j++)
                {
                    if (_num[j] > _num[j + 1])
                    {
                        temp = _num[j + 1];
                        _num[j + 1] = _num[j];
                        _num[j] = temp;
                    }
                }
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

        public static void InsertionTimi(int[] _num) 
        {
            /*int sortTiming;

            for (int i = 0; i < _num.Length; i++)
                _num.Insert((int)(rnd.NextDouble() * 100));
            {
                sortTime.startTime();
                _num.InsertionSort();
                sortTime.stopTime();

            }*/     

        }
         

        

    }
    
}
