using System;
using System.ComponentModel;

namespace fun_with_2D_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this Pseudo game to practice 2D arrays");

            //will allow user to enter the number of rows they want on their playground
            Console.WriteLine("How many rows do you want to generate?");
            int rows = Convert.ToInt32(Console.ReadLine());

            //will allow user to enter the number of columns they want on their playground
            Console.WriteLine("How many columns do you want to generate?");
            int columns = Convert.ToInt32(Console.ReadLine());
            
            //original 2D array syntax
            int[,] playground = new int [rows, columns];
            
            //variable syntax that will create random numbers for all cells in our array
            Random random = new Random();
            
            //For Loop that will populate array with random numbers
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    playground[i, j] = random.Next(0, 100);
                }
            }
            
            //For Loop that will go through each cell and let us find out what value is at each index
            for (int i = 0; i < playground.GetLength(0); i++)
            {
                for (int j = 0; j < playground.GetLength(1); j++)
                {
                    Console.Write(playground[i, j] + "\t");
                }

                Console.WriteLine();
            }

            // Will ask user what new numerical value they want 
            Console.WriteLine("Enter a new numerical value to override the index value of your choice");

            // user will enter a value 
            int input = Convert.ToInt32(Console.ReadLine());
            
            // Will ask the user what row number they will override its original value
            Console.WriteLine($"in which row would you like to place this {input}?");

            //User will enter their wished row
            int iAxis = Convert.ToInt32(Console.ReadLine());

            // Will ask the user the column number to override its original value
            Console.WriteLine($"In which column would you like to place this {input}?");

            //User will enter their wished column
            int jAxis = Convert.ToInt32(Console.ReadLine());

            //will iterate through the rows to replace the old value with the new value
            for (int i = 0; i< rows.CompareTo(0); i++)
            {
                for (int j = 0; j < columns.CompareTo(1); j++)
                {
                    int result = Convert.ToInt32(playground[iAxis, jAxis]);
                    Console.WriteLine(result);
                    result = input; 
                    Console.WriteLine(playground[iAxis, jAxis]= result);
                }
            }

            //will print an updated version of our 2D array 
            for (int i = 0; i < playground.GetLength(0); i++)
            {
                for (int j = 0; j < playground.GetLength(1); j++)
                {
                    Console.Write(playground[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
