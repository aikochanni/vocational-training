using System;
using System.IO;


namespace FirstDay
{
    public class ImageConverter
    {
        private string oldFileName, directory, txtEx, extension, line, gifVarAH, gifVarBH, pngH, jpgEx, jpgH, gifEx, pngEx, rarFourEx, rarFourH, rarH, rarEx, webpH, webpEx, tiffH, tiffEx, bmpH, bmpEx, zipH, zipEx;

        public void Convert(string path)
        {
            if (extension != txtEx) //when the file isn't text file
            {
                Console.Write("Please, enter a new name for the file: ");
                string newNameFile = Console.ReadLine(); //the user provides the new name for the file
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
                Console.Write("Please, enter a new name for the file: ");
                string newNameFile = Console.ReadLine(); 

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


