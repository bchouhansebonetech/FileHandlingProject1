using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingProject1
{
    internal class FileDescriptionWithComposition
    {
        public List<FileList> getFileDescription(string currentDirectory)
        {
            List<FileList> files = new List<FileList>();
            string[] filePaths = Directory.GetFiles(currentDirectory);
            if (filePaths.Length > 0)
            {
                Dictionary<string, List<File>> fileDescriptions = new Dictionary<string, List<File>>();
                foreach (string filePath in filePaths)
                {
                    File singleFile = new File();
                    singleFile.fileName = Path.GetFileName(filePath);
                    singleFile.fileSize = Path.GetFileName(filePath).Length + "kb";
                    singleFile.creationDate = System.IO.File.GetLastWriteTime(filePath);
                    singleFile.lastModifiedDate = System.IO.File.GetLastWriteTime(filePath);
                    var fs = new FileStream(filePath, FileMode.Open);
                    singleFile.writable = fs.CanWrite;
                    singleFile.readable = fs.CanRead;

                    if (fileDescriptions.ContainsKey(Path.GetExtension(filePath)))
                    {

                        fileDescriptions[Path.GetExtension(filePath)].Add(singleFile);
                    }
                    else
                    {
                        fileDescriptions[Path.GetExtension(filePath)] = new List<File>();
                        fileDescriptions[Path.GetExtension(filePath)].Add(singleFile);
                    }
                }

                foreach (string fileExtention in fileDescriptions.Keys)
                {
                    FileList fileList = new FileList();
                    fileList.fileExtention = fileExtention;
                    fileList.files = new List<File>();
                    var filesList = fileDescriptions[fileExtention];
                    for(int iterator = 0; iterator < filesList.Count; iterator++)
                    {
                        fileList.files.Add(filesList[iterator]);
                    }
                    //foreach (var file in filesList)
                    //{
                    //    fileList.files.Add(file);
                    //}
                    files.Add(fileList);
                }
            }
            return files;
        }
    }
}
