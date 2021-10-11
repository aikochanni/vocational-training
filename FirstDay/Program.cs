using System;
using System.IO;
using System.Xml.Linq;

namespace FirstDay
{
    class Program
    {
        static void Main(string[] args)
        {
            // the program assigns constant values for text and pictures files
            string jpg = ".jpg";
            string txt = ".txt";

            //the user provides the path to the file
            Console.Write("Please, enter the path to the file: ");
            string path = Console.ReadLine();

            //the program extracts the necessary data from path
            string directory = Path.GetDirectoryName(path);
            string oldFileName = Path.GetFileName(path);
            string extension = Path.GetExtension(path);


            if (extension == jpg) //when the file is picture
            {
                Console.Write("Please, enter a new name for the file: "); 
                string newNameFile = Console.ReadLine(); //the user provides the new name for the file
                File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + txt); //the program changes the path (in this case, no) and name of the file
                Console.WriteLine("Done!");

            } else if (extension == txt) //when the file is text
            {
                Console.Write("Please, enter a new name for the file: ");
                string newNameFile = Console.ReadLine(); //the user provides the new name for the file
                File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + jpg); //the program changes the path (in this case, no) and name of the file
                Console.WriteLine("Done!");
            } else
            {
                Console.WriteLine("ERR0R!! Incorrect data was entered");
            }
            Console.ReadKey();

        }
    }
}
