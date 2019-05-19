using System.Collections.Generic;
using CalculationsLibrary.FileWriter;

namespace CalculationsLibrary.Tests
{
    class DummyFileWriter : IFileWriter
    {
        public string FileName { get; private set; }
        public List<string> Lines { get; private set; }

        public void WriteAllLines(string fileName, List<string> lines)
        {
            FileName = fileName;
            Lines = lines;
        }
    }
}
