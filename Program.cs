using System;

namespace times_tables
{
    class Program
    {
        static void Main(string[] args)
        {
            // keep going till a user exits
            while (true)
            {
                 Console.WriteLine("What times table would you like (type 'exit' to quit)?");
            // Get user input
            string input = Console.ReadLine();
            try
            {
                // Try to convert to an int and then run Times Table function
                TimesTable(Convert.ToInt16(input));

            }
            // If not possible to convert to int means a string
            catch (FormatException)
            {
                if (input.ToLower() =="all")
                {
                    // Run all times table function
                    AllTimesTables();
                    
                }
                // user has typed exit
                else if (input.ToLower() == "exit")
                {
                    // Break out of the while loop and terminate
                    break;
                }else{
                    // If none of the above if statements run then we do not understand it and try again
                    Console.WriteLine("Sorry I have no understanding of that");
                }
        }
            }
            

        static void TimesTable(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {num} = {i * num}");
            }
        }

        static void AllTimesTables()
        {
            // Nested loop to work through all 12 times tables
            for (int x = 1; x <= 12; x++)
            {
                Console.WriteLine($"{x} Times Table");
                for (int y = 1; y <= 12; y++)
                {
                    Console.WriteLine($"\t{y} x {x} = {x * y}");
                }
            }

        }

    }
    }
    }
