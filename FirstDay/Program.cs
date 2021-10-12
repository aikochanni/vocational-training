using System;
using System.Collections.Generic;
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
            // Hello sentence
            Console.WriteLine("Hello! I am pleased to welcome you to the \"converting\" program");
            Console.WriteLine("================================================================");

            // the program assigns constant values for text and pictures files
            string gifEx = ".gif";
            string pngEx = ".png";
            string jpgEx = ".jpg";
            string webpEx = ".webp";
            string tiffEx = ".tiff";
            string bmpEx = ".bmp";
            string zipEx = ".zip";
            string rarEx = ".rar";
            string rarFourEx = ".rar";
            string txtEx = ".txt";

            // headers files
            string gifVarAH = "GIF87a";
            string gifVarBH = "GIF89a";
            string pngH = "PNG";
            string jpgH = "˙Ř˙ŕ";
            string webpH = "RIFF";
            string tiffH = "䥉*";
            string bmpH = "BMŠ";
            string zipH = "PK";
            string rarH = "慒ⅲ";
            string rarFourH = "Rar!";


            //the user provides the path to the file
            Console.Write("Please, enter the path to the file: ");
            string path = Console.ReadLine();

            //the program extracts the necessary data from path
            string directory = Path.GetDirectoryName(path);
            string oldFileName = Path.GetFileName(path);
            string extension = Path.GetExtension(path);

            var line = File.ReadLines(path).First();

            if (extension != txtEx) //when the file isn't text file
            {
                switch (extension)
                {
                    case ".gif":
                        Console.Write("Please, enter a new name for the file: ");
                        string newNameFile = Console.ReadLine(); //the user provides the new name for the file
                        File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + txtEx); //the program changes the path (in this case, no) and name of the file
                        Console.WriteLine("Done!");
                        break;
                    case ".png":
                        Console.Write("Please, enter a new name for the file: ");
                        newNameFile = Console.ReadLine(); //the user provides the new name for the file
                        File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + txtEx); //the program changes the path (in this case, no) and name of the file
                        Console.WriteLine("Done!");
                        break;
                    case ".jpg":
                        Console.Write("Please, enter a new name for the file: ");
                        newNameFile = Console.ReadLine(); //the user provides the new name for the file
                        File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + txtEx); //the program changes the path (in this case, no) and name of the file
                        Console.WriteLine("Done!");
                        break;
                    case ".webp":
                        Console.Write("Please, enter a new name for the file: ");
                        newNameFile = Console.ReadLine(); //the user provides the new name for the file
                        File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + txtEx); //the program changes the path (in this case, no) and name of the file
                        Console.WriteLine("Done!");
                        break;
                    case ".tiff":
                        Console.Write("Please, enter a new name for the file: ");
                        newNameFile = Console.ReadLine(); //the user provides the new name for the file
                        File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + txtEx); //the program changes the path (in this case, no) and name of the file
                        Console.WriteLine("Done!");
                        break;
                    case ".bmp":
                        Console.Write("Please, enter a new name for the file: ");
                        newNameFile = Console.ReadLine(); //the user provides the new name for the file
                        File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + txtEx); //the program changes the path (in this case, no) and name of the file
                        Console.WriteLine("Done!");
                        break;
                    case ".zip":
                        Console.Write("Please, enter a new name for the file: ");
                        newNameFile = Console.ReadLine(); //the user provides the new name for the file
                        File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + txtEx); //the program changes the path (in this case, no) and name of the file
                        Console.WriteLine("Done!");
                        break;
                    case ".rar":
                        Console.Write("Please, enter a new name for the file: ");
                        newNameFile = Console.ReadLine(); //the user provides the new name for the file
                        File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + txtEx); //the program changes the path (in this case, no) and name of the file
                        Console.WriteLine("Done!"); ;
                        break;

                }
            }

            else if (extension == txtEx)
            {//when the file is text

                if (line.StartsWith(gifVarAH)) //when file is png type
                {
                    Console.Write("Please, enter a new name for the file: ");
                    string newNameFile = Console.ReadLine(); //the user provides the new name for the file
                    File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + gifEx); //the program changes the path (in this case, no) and name of the file
                    Console.WriteLine("Done!");
                }
                else if (line.StartsWith(gifVarBH)) //when file is jpg type
                {
                    Console.Write("Please, enter a new name for the file: ");
                    string newNameFile = Console.ReadLine(); //the user provides the new name for the file
                    File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + gifEx); //the program changes the path (in this case, no) and name of the file
                    Console.WriteLine("Done!");
                }
                else if (line.StartsWith(pngH)) //when file is jpg type
                {
                    Console.Write("Please, enter a new name for the file: ");
                    string newNameFile = Console.ReadLine(); //the user provides the new name for the file
                    File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + pngEx); //the program changes the path (in this case, no) and name of the file
                    Console.WriteLine("Done!");
                }
                else if (line.StartsWith("˙Ř˙")) //when file is jpg type
                {
                    Console.Write("Please, enter a new name for the file: ");
                    string newNameFile = Console.ReadLine(); //the user provides the new name for the file
                    File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + jpgEx); //the program changes the path (in this case, no) and name of the file
                    Console.WriteLine("Done!");
                }
                else if (line.StartsWith(webpH)) //when file is jpg type
                {
                    Console.Write("Please, enter a new name for the file: ");
                    string newNameFile = Console.ReadLine(); //the user provides the new name for the file
                    File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + webpEx); //the program changes the path (in this case, no) and name of the file
                    Console.WriteLine("Done!");
                }
                else if (line.StartsWith(tiffH)) //when file is jpg type
                {
                    Console.Write("Please, enter a new name for the file: ");
                    string newNameFile = Console.ReadLine(); //the user provides the new name for the file
                    File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + tiffEx); //the program changes the path (in this case, no) and name of the file
                    Console.WriteLine("Done!");
                }
                else if (line.StartsWith(bmpH)) //when file is jpg type
                {
                    Console.Write("Please, enter a new name for the file: ");
                    string newNameFile = Console.ReadLine(); //the user provides the new name for the file
                    File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + bmpEx); //the program changes the path (in this case, no) and name of the file
                    Console.WriteLine("Done!");
                }
                else if (line.StartsWith(zipH)) //when file is jpg type
                {
                    Console.Write("Please, enter a new name for the file: ");
                    string newNameFile = Console.ReadLine(); //the user provides the new name for the file
                    File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + zipEx); //the program changes the path (in this case, no) and name of the file
                    Console.WriteLine("Done!");
                }
                else if (line.StartsWith(rarH)) //when file is jpg type
                {
                    Console.Write("Please, enter a new name for the file: ");
                    string newNameFile = Console.ReadLine(); //the user provides the new name for the file
                    File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + rarEx); //the program changes the path (in this case, no) and name of the file
                    Console.WriteLine("Done!");
                }
                else if (line.StartsWith(rarFourH)) //when file is jpg type
                {
                    Console.Write("Please, enter a new name for the file: ");
                    string newNameFile = Console.ReadLine(); //the user provides the new name for the file
                    File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + rarFourEx); //the program changes the path (in this case, no) and name of the file
                    Console.WriteLine("Done!");
                }
                //else
                //{
                //    Console.WriteLine("ERR0R!! Incorrect data was entered");
                //}
                Console.ReadKey();

            }
        }
    }
}
