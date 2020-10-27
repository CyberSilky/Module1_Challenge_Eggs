using System;
using static System.Console;
//Name: James Shoemaker
//Date: 03/21/2020
//Purpose: Discussion response week 1

namespace Module1_Challenge_Eggs
{
    class Eggs
    {
        static void Main(string[] args)
        {
            int chicken1_eggs = 0;
            int chicken2_eggs = 0;
            int chicken3_eggs = 0;
            int chicken4_eggs = 0;
            int total_eggs = 0;
            int dozen_amount = 0;
            int leftover_eggs = 0;

            Write("Enter the eggs provided by chicken #1 : ");
            chicken1_eggs = Convert.ToInt32(ReadLine());

            Write("Enter the eggs provided by chicken #2 : ");
            chicken2_eggs = Convert.ToInt32(ReadLine());

            Write("Enter the eggs provided by chicken #3 : ");
            chicken3_eggs = Convert.ToInt32(ReadLine());

            Write("Enter the eggs provided by chicken #4 : ");
            chicken4_eggs = Convert.ToInt32(ReadLine());

            total_eggs = chicken1_eggs + chicken2_eggs + chicken3_eggs + chicken4_eggs;

            //calculate dozens
            //divide total eggs by 12

            dozen_amount = total_eggs / 12;

            //calculate leftover eggs
            //take the leftover egges and set equal to the remainder amount of the total eggs

            leftover_eggs = total_eggs % 12;

            //display results
            WriteLine("There are {0} eggs.", total_eggs);
            WriteLine("There are {0} and {1} leftover eggs", dozen_amount, leftover_eggs);
        }
    }
}
