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
            int[] num = { 7, 11, 88, 25, 66, 55};
            BubbleSort(num);
            int[] num1 = { 7, 11, 88, 25, 66, 55};
            SelectionSort(num1);
            int[] num2 = { 7, 11, 88, 25, 66, 55};
            InsertionSort(num2);

        }

        public static void InsertionSort(int[] _arr)
        {
            int inner, temp;
            Console.WriteLine("\n\n--Original Contents--");
            displayContents(_arr);//Display the original state of the array.

            Console.WriteLine("--Insertion Sort Process--");
            for (int i = 1; i <= _arr.Length - 1; i++)
            {
                inner = i;
                temp = _arr[i];
                while (inner > 0 && _arr[inner - 1] >= temp)
                {
                    _arr[inner] = _arr[inner - 1];
                    inner -= 1;
                }
                _arr[inner] = temp;
                displayContents(_arr);
            }
        }

        /*--Selection Sort Algorithm--*/
        public static void SelectionSort(int[] _arr)
        {
            int temp, min;//Variables used to temporarily store the array value while it swaps them around.

            Console.WriteLine("\n\n--Original Contents--");
            displayContents(_arr);//Display the original state of the array.

            Console.WriteLine("--Selection Sort Process--");
            for (int i = 0; i < _arr.Length - 1; i++)//Outter loops goes through all of the objects in the array.
            {
                min = i;//Minimum value is set to the current index that the outer loop is at.
                for (int j = i + 1; j < _arr.Length; j++)//Inner loop goes thorough and does the swaps.
                {
                    if (_arr[j] < _arr[min])//Condition checking of the current state of the array
                    {
                        min = j;//If the current value is less than _arr[min] then make j the new min.
                    }
                }
                displayContents(_arr);//Display the contents after each iteration of the algorithm
                if (min != 1)
                {
                    temp = _arr[i];
                    _arr[i] = _arr[min];
                    _arr[min] = temp;
                }
            }
            displayContents(_arr);
        }

        /*--Bubble sort algorithm--*/
        public static void BubbleSort(int[] _arr)
        {
            int temp;//Variable used to temporarily store the array value while it is swapped around.

            Console.WriteLine("--Original Contents--");
            displayContents(_arr);//Display the original state of the array.

            Console.WriteLine("--Bubble Sort Process--");
            for (int i = 0; i < _arr.Length; i++)//Outter loops goes through all of the objects in the array.
            {
                for (int j = 0; j < _arr.Length - 1; j++)//Inner loop goes thorough and does the swaps.
                {
                    if (_arr[j] > _arr[j + 1])//Condition checking of the current state of the array
                    {
                        temp = _arr[j + 1];//Swap the contents of the two array indicies
                        _arr[j + 1] = _arr[j];
                        _arr[j] = temp;
                    }
                }
                displayContents(_arr);//Display the contents after each iteration of the algorithm
            }
        }

        /*--Display contents of the arrays--*/
        public static void displayContents(int[] _arr)
        {
            for (int i = 0; i <= _arr.Length - 1; i++)//for loop used to display the contents of an array
            {
                Console.Write(_arr[i] + " ");
            }
            Console.WriteLine();
        }
    }

    /*--- Add the code for the tasks here ---*/
    class Exercises
    {
        /*
            string[] input = File.ReadLines(@"c:\Data.txt").ToArray();//copy from txt file to an array
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
            Console.WriteLine();
            */
    }
}
