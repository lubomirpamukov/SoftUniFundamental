namespace _03._Extract_File
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine(); // taking the input

            int fileNamePositionIndex = filePath.LastIndexOf("\\") + 1; // taking the index of the last "\"
            int fileExtensionPositionIndex = filePath.LastIndexOf(".") + 1; // taking the index of the last "."

            string fileName = filePath.Substring(fileNamePositionIndex, fileExtensionPositionIndex - fileNamePositionIndex - 1);
            string fileExtension = filePath.Substring(fileExtensionPositionIndex);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");

        }
    }
}