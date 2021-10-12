using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace FirstDay
{
    public class Program
    {
        static public void Main(string[] args)
        {
            // Hello sentence
            Console.WriteLine("Hello! I am pleased to welcome you to the \"converting\" program");
            Console.WriteLine("================================================================");

            Console.WriteLine("Please, enter a new name for the file: ");
        }
            public static string path = Console.ReadLine(); //the user provides the new name for the file

        // the program assigns constant values for text and pictures files
        public static string gifEx = ".gif";
        public static string pngEx = ".png";
        public static string jpgEx = ".jpg";
        public static string webpEx = ".webp";
        public static string tiffEx = ".tiff";
        public static string bmpEx = ".bmp";
        public static string zipEx = ".zip";
        public static string rarEx = ".rar";
        public static string txtEx = ".txt";

        // headers files
        public static string gifVarAH = "GIF87a";
        public static string gifVarBH = "GIF89a";
        public static string pngH = "PNG";
        public static string jpgH = "˙Ř˙ŕ";
        public static string webpH = "RIFF";
        public static string tiffH = "䥉*";
        public static string bmpH = "BMŠ";
        public static string zipH = "PK";
        public static string rarH = "慒ⅲ";
        public static string rarFourH = "Rar!";

        //the program extracts the necessary data from path
        public static string directory = Path.GetDirectoryName(path);
        public static string oldFileName = Path.GetFileName(path);
        public static string extension = Path.GetExtension(path);

        //the program only reads the first line of code
        public static string line = File.ReadLines(path).First();

        ImageConverter testt = new ImageConverter();
    }
}


