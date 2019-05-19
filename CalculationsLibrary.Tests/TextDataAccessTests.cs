using System.Collections.Generic;
using System.IO;
using Xunit;

namespace CalculationsLibrary.Tests
{
    public class TextDataAccessTests
    {
        private readonly DummyFileWriter _fileWriter;
        private readonly TextDataAccess _textDataAccess;

        public TextDataAccessTests()
        {
            _fileWriter = new DummyFileWriter();
            _textDataAccess = new TextDataAccess(_fileWriter);
        }

        public static IEnumerable<object[]> TooLongFilePathData
        {
            get
            {
                var list = new List<object[]>
                {
                    new object[]{ "The path needs to be less than 261 characters long. The path needs to be less than 261 characters long. The path needs to be less than 261 characters long. The path needs to be less than 261 characters long. The path needs to be less than 261 characters long. The path needs to be less than 261 characters long.", new List<string>( )}
                };
                foreach (var element in list)
                {
                    yield return element;
                }
            }
        }

        [MemberData(nameof(TooLongFilePathData))]
        [Theory]
        public void TooLongPathNamesThrowException(string filePath, List<string> lines)
        {


            PathTooLongException ex = Assert.Throws<PathTooLongException>(() => _textDataAccess.SaveText(filePath, lines));

            Assert.Equal("The path needs to be less than 261 characters long.", ex.Message);
        }

        public static IEnumerable<object[]> Data
        {
            get
            {
                var list = new List<object[]>
                {
                    new object[]{ "filename.txt", new List<string>{"data1", "data2"}}
                };
                foreach (var element in list)
                {
                    yield return element;
                }
            }
        }

        [MemberData(nameof(Data))]
        [Theory]
        public void SavingFilesWorks(string filePath, List<string> lines)
        {


            _textDataAccess.SaveText(filePath, lines);

            Assert.Equal(filePath, _fileWriter.FileName);
            Assert.Equal(lines, _fileWriter.Lines);
        }

    }
}
