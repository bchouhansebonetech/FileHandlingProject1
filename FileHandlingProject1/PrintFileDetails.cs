using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingProject1
{
    public class PrintFileDetails
    {
        public void printAllDetailsOfFile(FileList fileList)
        {
            if(fileList != null)
            {
                Console.WriteLine($"File Type: {fileList.fileExtention}");
                List<File> files = fileList.files;
                foreach(File file in files)
                {
                    Console.WriteLine($"File Name: {file.fileName}, File Size: {file.fileSize}, Creation: {file.creationDate.ToString()}, " +
                        $"Last Modified: {file.lastModifiedDate.ToString()}, Readable: {file.readable}, Writable: {file.writable}");
                }
                Console.WriteLine("---------------------------------------------------------------------------------------");
            }
        }
    }
}
