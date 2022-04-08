using System;
using System.IO;

namespace W3schoolsPractice
{
    static class FileHandle
    {
        public static void FileHandle1()
        {
            string fileName, readText, Dest;
            Console.WriteLine("enter a File name with extension to use : ");
            fileName = Console.ReadLine();
            Console.WriteLine("enter a string to insert inside the file : ");
            string textWriter = Console.ReadLine();
            File.WriteAllText(fileName, textWriter);

            //path - //D:\Practice Programs C#\file handling C# - practice
            //path - //D:/Practice Programs C#/file handling C# - practice/test1.txt

            
            readText = File.ReadAllText(fileName);
            Console.WriteLine();
            Console.WriteLine("File has the content of : "+readText);
            File.AppendText(fileName);
            Console.WriteLine();
            Console.WriteLine("Enter the destination where the file should be copied : ");
            Dest = Console.ReadLine();
            File.Copy(fileName, Dest);
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            Console.WriteLine("To create a new file enter the file name with path : ");
            fileName = Console.ReadLine();
            File.Create(fileName);

            File.Replace(fileName,Dest,"D:");
        }
    }
}
