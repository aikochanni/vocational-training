using System;

namespace FirstDay
{
    class Program
    {

        public static void Main(string[] args)
        {
            // Hello sentence
            Console.WriteLine("Hello! I am pleased to welcome you to the \"converting\" program");
            Console.WriteLine("================================================================");

            //the user provides the path to the file
            Console.Write("Please, enter the path to the file: ");
            string path = Console.ReadLine();
            ImageConverter Convert = new ImageConverter();
            Convert.Convert(path);

            for (int i = 0; i >= 0; i++)
            {
                Console.WriteLine("Do you want to convert another file (Y/N)");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.WriteLine("  soo let's go...");
                    Console.Write("Please, enter the path to the file: ");
                    path = Console.ReadLine();
                    Convert.Convert(path);
                }
                else if (Console.ReadKey().Key == ConsoleKey.N)
                {
                    Console.WriteLine("Okay, Thank you for using our program ^^");
                }
            }
        }
    }
}


