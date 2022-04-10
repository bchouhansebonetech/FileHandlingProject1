using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string workingDirectory = "C:\\Users\\Bhanu Singh\\eclipse\\java-2021-12";
            SubDirectries subDirectries = new SubDirectries();
            subDirectries.getSubDirectries(workingDirectory);
        }
    }
}
