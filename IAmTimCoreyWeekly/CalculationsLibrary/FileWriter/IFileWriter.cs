using System.Collections.Generic;

namespace CalculationsLibrary.FileWriter
{
    public interface IFileWriter
    {
        void WriteAllLines(string fileName, List<string> lines);
    }
}