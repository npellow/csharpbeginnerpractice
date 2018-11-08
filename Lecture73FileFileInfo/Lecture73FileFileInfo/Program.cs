using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lecture73FileFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //File examples
            var path = @"c:\somefile.jpg";

            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //do something
            }
            var content = File.ReadAllText(path);

            //FileInfo examples
            var fileInfo = new FileInfo(path);

            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //do something
            }
        }
    }
}
