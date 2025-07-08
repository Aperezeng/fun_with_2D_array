using System;

namespace fun_with_2D_array
{
    internal class Program
    {
        static void Main(string[] args, int colums, object usersPlayground)
        {
            Console.WriteLine("Welcome to this Pseudo game to practice 2D arrays");
            //will allow user to enter the number of columns they want on their playground
            Console.WriteLine("How many columns do you want to generate?");
            int columns = Convert.ToInt32(Console.ReadLine());
            //will allow user to enter the number of rows they want on their playground
            Console.WriteLine("How many rows do you want to generate?");
            int rows = Convert.ToInt32(Console.ReadLine());
            
            // Will ask user what symbol they'll like to fill in and in what index
            Console.WriteLine("Enter a value or symbol to fill in your grid of choice");
                        
            // user will enter a value or character or symbol 
            ConsoleKeyInfo input = Console.ReadKey();

            // Will ask the user the row where to place their input 
            Console.WriteLine($"in which row would you like to place this {input}?");
            
            //User will enter their wished row
            int yAxis = Convert.ToInt32(Console.ReadLine());
            
            // Will ask the user the column where to place their input 
            Console.WriteLine($"In which column would you like to place this {input}?");
            
            //User will enter their wished column
            int xAxis = Convert.ToInt32(Console.ReadLine());
            
            // will have two for loops iterate through the rows and columns until finds the correct index
            //for the user's input
           //for (rows = 0; rows < usersPlayground.GetLength(0); rows++)
                //for (xAxis = 0; colums < usersPlayground.GetLength(1); columns++)
                
        }
    }
}