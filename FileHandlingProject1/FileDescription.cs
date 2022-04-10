using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingProject1
{
    public class FileDescription
    {
        public void getFileDescription(string currentDirectory)
        {
            string[] filePaths = Directory.GetFiles(currentDirectory);
            if (filePaths.Length > 0)
            {
                Dictionary<string, List<string>> fileDescriptions = new Dictionary<string, List<string>>();
                foreach (string filePath in filePaths)
                {
                    {
                        //string fileName = Path.GetFileName(filePath);
                        //string fileType = Path.GetExtension(filePath);
                        //long fileSize = fileName.Length;
                        //Console.WriteLine($"{fileName} ------------- {fileType} ------------- {fileSize}");
                    }

                    if (fileDescriptions.ContainsKey(Path.GetExtension(filePath)))
                    {
                        fileDescriptions[Path.GetExtension(filePath)].Add(filePath);
                    }
                    else
                    {
                        fileDescriptions[Path.GetExtension(filePath)] = new List<string>();
                        fileDescriptions[Path.GetExtension(filePath)].Add(filePath);
                    }
                }

                foreach (string fileExtention in fileDescriptions.Keys)
                {
                    var fileList = fileDescriptions[fileExtention];
                    Console.WriteLine($"File Type: {fileExtention}");
                    foreach (var file in fileList)
                    {
                        Console.WriteLine($"File Name: {Path.GetFileName(file)}, File Size: {Path.GetFileName(file).Length}kb");
                    }
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                }
            }
        }
    }
}
