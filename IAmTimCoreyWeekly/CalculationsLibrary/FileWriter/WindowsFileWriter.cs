using System.Collections.Generic;
using System.IO;

namespace CalculationsLibrary.FileWriter
{
    public class WindowsFileWriter : IFileWriter
    {
        public void WriteAllLines(string fileName, List<string> lines)
        {
            File.WriteAllLines(fileName, lines);
        }
    }
}
