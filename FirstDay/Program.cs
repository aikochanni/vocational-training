using System;
using System.IO;
using System.Linq;

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

            //the program extracts the necessary data from path
            string directory = Path.GetDirectoryName(path);
            string oldFileName = Path.GetFileName(path);
            string extension = Path.GetExtension(path);

            var line = File.ReadLines(path).First();

            ImageConverter ConvertTo = new ImageConverter();
        }
    }
}


