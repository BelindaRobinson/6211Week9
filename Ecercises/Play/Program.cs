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


            Stopwatch MyTimer = new Stopwatch();
            MyTimer.Start();
            int inner, temp;
            Console.WriteLine("Original Array List");


            Console.WriteLine("Insertion Sorted List");
            for (int i = 1; i <= num.Length - 1; i++)
            {
                inner = i;
                temp = num[i];
                while (inner > 0 && num[inner - 1] >= temp)
                {
                    num[inner] = num[inner - 1];
                    inner -= 1;
                }
                num[inner] = temp;
                MyTimer.Stop();
                Console.WriteLine("timetaken:" + MyTimer.Elapsed);
                Console.ReadLine();
            }
        }
    }
}
