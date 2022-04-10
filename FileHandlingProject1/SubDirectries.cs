using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace FileHandlingProject1
{
    public class SubDirectries
    {
        public void getSubDirectries(string workingDirectory)
        {
            Queue directoryQueue = new Queue();
            directoryQueue.Enqueue(workingDirectory);

            while(directoryQueue.Count > 0)
            {
                string currentDirectory = directoryQueue.Dequeue().ToString();
                Console.WriteLine(currentDirectory);
                //FileDescription fileDescription = new FileDescription();
                //fileDescription.getFileDescription(currentDirectory);
                FileDescriptionWithComposition fileDescriptionWithComposition = new FileDescriptionWithComposition();
                List<FileList> fileLists = fileDescriptionWithComposition.getFileDescription(currentDirectory);
                PrintFileDetails printFileDetails = new PrintFileDetails();
                if(fileLists != null)
                    foreach (FileList fileList in fileLists)
                        printFileDetails.printAllDetailsOfFile(fileList);

                string[] subDirectories = Directory.GetDirectories(currentDirectory);

                if (subDirectories.Length > 0)
                    foreach (string subDirectory in subDirectories)
                    {
                        directoryQueue.Enqueue(subDirectory);
                    }
                else
                    continue;
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
        }
    }
}
