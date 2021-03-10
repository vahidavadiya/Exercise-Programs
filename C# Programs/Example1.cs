using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Example1
    {
        public static void Main(string[] args)
        {
            //Write a program that prompts the user to enter an integer from 1 to 15 and displays a pyramid.
             Console.Write("Please Enter number between 1 and 15: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = number; i > 0; i--)
            {
                bool decr = true;
                for (int num = i, j = 2 * i - 1; j > 0 ; j = j - 1)
                {
                    Console.Write(num + " ");

                    if (decr)
                        num--;
                    else
                        num++;
                    if (num == 0)
                    {
                        decr = false;
                        num = 2;
                    }

                }
                Console.WriteLine();
            }

                Console.ReadLine();
        }
    }
}
