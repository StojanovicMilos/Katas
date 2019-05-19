using System;
using System.Collections.Generic;
using System.IO;
using CalculationsLibrary.FileWriter;

namespace CalculationsLibrary
{
    public class TextDataAccess
    {
        private readonly IFileWriter _fileWriter;

        public TextDataAccess(IFileWriter fileWriter)
        {
            _fileWriter = fileWriter ?? throw new ArgumentNullException(nameof(fileWriter));
        }

        public void SaveText(string filePath, List<string> lines)
        {
            if (filePath.Length > 260)
            {
                throw new PathTooLongException("The path needs to be less than 261 characters long.");
            }

            string fileName = Path.GetFileName(filePath);

            _fileWriter.WriteAllLines(fileName, lines);
        }
    }
}
