using System;
using System.IO;
using System.Linq;

namespace FirstDay
{
    public class ImageConverter
    {
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

        public void Convert(string path)
        {
            //the program extracts the necessary data from path
            string directory = Path.GetDirectoryName(path);
            string oldFileName = Path.GetFileName(path);
            string extension = Path.GetExtension(path);
            var line = File.ReadLines(path).First();
            Console.Write("Please, enter a new name for the file: ");
            string newNameFile = Console.ReadLine();

            if (extension != txtEx) //when the file isn't text file
            {
                switch (extension)
                {
                    case ".gif": //gif to txt
                        File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + txtEx);
                        break;
                    case ".png": //png to txt
                        File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + txtEx);
                        break;
                    case ".jpg": //jpg to txt
                        File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + txtEx);
                        break;
                    case ".webp": //webp to txt
                        File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + txtEx);
                        break;
                    case ".tiff": //tiff to txt
                        File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + txtEx);
                        break;
                    case ".bmp": //bmp to txt
                        File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + txtEx);
                        break;
                    case ".zip": //zip to txt
                        File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + txtEx);
                        break;
                    case ".rar": //rar to txt
                        File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + txtEx);
                        break;
                }
                Console.WriteLine("Done!");

            } else if (extension == txtEx)
            {

                if (line.StartsWith(gifVarAH)) //when file is gif type
                {
                    File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + gifEx); 
                }
                else if (line.StartsWith(gifVarBH)) //when file is gif type
                {
                    File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + gifEx); 
                }
                else if (line.StartsWith(pngH)) //when file is png type
                {
                    File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + pngEx); 
                }
                else if (line.StartsWith(jpgH)) //when file is jpg type
                {
                    File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + jpgEx); 
                }
                else if (line.StartsWith(webpH)) //when file is webp type
                {
                    File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + webpEx); 
                }
                else if (line.StartsWith(tiffH)) //when file is tiff type
                {
                    File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + tiffEx); 
                }
                else if (line.StartsWith(bmpH)) //when file is bmp type
                {
                    File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + bmpEx); 
                }
                else if (line.StartsWith(zipH)) //when file is zip type
                {
                    File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + zipEx); 
                }
                else if (line.StartsWith(rarH)) //when file is rar type
                {
                    File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + rarEx); 
                }
                else if (line.StartsWith(rarFourH)) //when file is rar4 type
                {
                    File.Move(directory + "/" + oldFileName, directory + "/" + newNameFile + rarFourEx);
                }
                Console.WriteLine("Done!");
            }
        }
    }
}


