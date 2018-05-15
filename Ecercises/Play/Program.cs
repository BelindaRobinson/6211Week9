using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace Play
{
    class Program
    {

        static void Main(string[] args)

        {

            int[] num = { 7, 45, 88, 25, 66, 55 };
            BubbleSort(num);
            

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
    }
}
