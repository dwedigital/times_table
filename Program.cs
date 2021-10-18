using System;

namespace times_tables
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                 Console.WriteLine("What times table would you like (type 'exit' to quit)?");

            string input = Console.ReadLine();
            try
            {
                TimesTable(Convert.ToInt16(input));

            }
            catch (FormatException)
            {
                if (input.ToLower() =="all")
                {
                    AllTimesTables();
                    
                }
                else if (input.ToLower() == "exit")
                {
                    break;
                }else{
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
