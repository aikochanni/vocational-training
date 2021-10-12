using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDay
{
    class ImageConverter
    {
        public object testt;

        static public void Convert(string path)
        {

            if (Program.extension != Program.txtEx) //when the file isn't text file
            {
                Console.Write("Please, enter a new name for the file: ");
                string newNameFile = Console.ReadLine(); //the user provides the new name for the file
                switch (Program.extension)
                {
                    case ".gif":
                        File.Move(Program.directory + "/" + Program.oldFileName, Program.directory + "/" + newNameFile + Program.txtEx); //the program changes the path (in this case, no) and name of the file
                        break;
                    case ".png":
                        File.Move(Program.directory + "/" + Program.oldFileName, Program.directory + "/" + newNameFile + Program.txtEx); //the program changes the path (in this case, no) and name of the file
                        break;
                    case ".jpg":
                        File.Move(Program.directory + "/" + Program.oldFileName, Program.directory + "/" + newNameFile + Program.txtEx); //the program changes the path (in this case, no) and name of the file
                        break;
                    case ".webp":
                        File.Move(Program.directory + "/" + Program.oldFileName, Program.directory + "/" + newNameFile + Program.txtEx); //the program changes the path (in this case, no) and name of the file
                        break;
                    case ".tiff":
                        File.Move(Program.directory + "/" + Program.oldFileName, Program.directory + "/" + newNameFile + Program.txtEx); //the program changes the path (in this case, no) and name of the file
                        break;
                    case ".bmp":
                        File.Move(Program.directory + "/" + Program.oldFileName, Program.directory + "/" + newNameFile + Program.txtEx); //the program changes the path (in this case, no) and name of the file
                        break;
                    case ".zip":
                        File.Move(Program.directory + "/" + Program.oldFileName, Program.directory + "/" + newNameFile + Program.txtEx); //the program changes the path (in this case, no) and name of the file
                        break;
                    case ".rar":
                        File.Move(Program.directory + "/" + Program.oldFileName, Program.directory + "/" + newNameFile + Program.txtEx); //the program changes the path (in this case, no) and name of the file
                        break;

                }
                Console.WriteLine("Done!");
            }

            else if (Program.extension == Program.txtEx) //when the file is text
            {
                Console.Write("Please, enter a new name for the file: ");
                string newNameFile = Console.ReadLine(); //the user provides the new name for the file

                if (Program.line.StartsWith(Program.gifVarAH)) //when file is gif type
                {
                    File.Move(Program.directory + "/" + Program.oldFileName, Program.directory + "/" + newNameFile + Program.gifEx); //the program changes the path (in this case, no) and name of the file
                }
                else if (Program.line.StartsWith(Program.gifVarBH)) //when file is gif type
                {
                    File.Move(Program.directory + "/" + Program.oldFileName, Program.directory + "/" + newNameFile + Program.gifEx); //the program changes the path (in this case, no) and name of the file
                }
                else if (Program.line.StartsWith(Program.pngH)) //when file is png type
                {
                    File.Move(Program.directory + "/" + Program.oldFileName, Program.directory + "/" + newNameFile + Program.pngEx); //the program changes the path (in this case, no) and name of the file
                }
                else if (Program.line.StartsWith("˙Ř˙")) //when file is jpg type
                {
                    File.Move(Program.directory + "/" + Program.oldFileName, Program.directory + "/" + newNameFile + Program.jpgEx); //the program changes the path (in this case, no) and name of the file
                }
                else if (Program.line.StartsWith(Program.webpH)) //when file is webp type
                {
                    File.Move(Program.directory + "/" + Program.oldFileName, Program.directory + "/" + newNameFile + Program.webpEx); //the program changes the path (in this case, no) and name of the file
                }
                else if (Program.line.StartsWith(Program.tiffH)) //when file is tiff type
                {
                    File.Move(Program.directory + "/" + Program.oldFileName, Program.directory + "/" + newNameFile + Program.tiffEx); //the program changes the path (in this case, no) and name of the file
                }
                else if (Program.line.StartsWith(Program.bmpH)) //when file is bmp type
                {
                    File.Move(Program.directory + "/" + Program.oldFileName, Program.directory + "/" + newNameFile + Program.bmpEx); //the program changes the path (in this case, no) and name of the file
                }
                else if (Program.line.StartsWith(Program.zipH)) //when file is zip type
                {
                    File.Move(Program.directory + "/" + Program.oldFileName, Program.directory + "/" + newNameFile + Program.zipEx); //the program changes the path (in this case, no) and name of the file
                }
                else if (Program.line.StartsWith(Program.rarH)) //when file is rar type
                {
                    File.Move(Program.directory + "/" + Program.oldFileName, Program.directory + "/" + newNameFile + Program.rarEx); //the program changes the path (in this case, no) and name of the file
                }
                else if (Program.line.StartsWith(Program.rarFourH)) //when file is rar4 type
                {
                    File.Move(Program.directory + "/" + Program.oldFileName, Program.directory + "/" + newNameFile + Program.rarEx); //the program changes the path (in this case, no) and name of the file
                }
                Console.WriteLine("Done!");
                //else
                //{
                //    Console.WriteLine("ERR0R!! Incorrect data was entered");
                //}
                Console.ReadKey();

            }
        }
    }
}
