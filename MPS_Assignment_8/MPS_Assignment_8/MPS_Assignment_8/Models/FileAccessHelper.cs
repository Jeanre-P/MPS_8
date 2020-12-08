using System;
using System.Collections.Generic;
using System.Text;

namespace MPS_Assignment_8.Models
{
    public class FileAccessHelper
    {
        public static string GetLocalFilePath(string filename)
        {
            return System.IO.Path.Combine(FileSystem.AppDataDirectory, filename);
        }
    }
}
