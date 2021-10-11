using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
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
            int counter = 1;
            int count = 0;

            //the program counts words and numbers from 0 to 9
            foreach (char litera in oldFileName)
                if (litera == ' ') counter++;
            foreach (int cyfra in oldFileName)
                if (cyfra == 0) count++;
                else if (cyfra == '1')
                    count++;
                else if (cyfra == '2')
                    count++;
                else if (cyfra == '3')
                    count++;
                else if (cyfra == '4')
                    count++;
                else if (cyfra == '5')
                    count++;
                else if (cyfra == '6')
                    count++;
                else if (cyfra == '7')
                    count++;
                else if (cyfra == '8')
                    count++;
                else if (cyfra == '9')
                    count++;
                else if (cyfra == '0')
                    count++;

            if (extension == jpg) //when the file is picture
            {
                Console.Write("Please, enter a new name for the file: "); 
                string newNameFile = Console.ReadLine(); //the user provides the new name for the file
                File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + txt); //the program changes the path (in this case, no) and name of the file
                Console.WriteLine("Done!");

            } else if (extension == txt) //when the file is text
            {
                if (counter+count <= 1) //when file name has one word
                {
                    Console.Write("Incorrect file format");
                } else if (counter+count > 1) //when file name has more words
                {
                    Console.Write("Please, enter a new name for the file: ");
                    string newNameFile = Console.ReadLine(); //the user provides the new name for the file
                    File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + jpg); //the program changes the path (in this case, no) and name of the file
                    Console.WriteLine("Done!");
                }
            } else
            {
                Console.WriteLine("ERR0R!! Incorrect data was entered");


            }
            Console.ReadKey();

        }
    }
}
