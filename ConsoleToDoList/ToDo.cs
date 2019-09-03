using System;

namespace ConsoleToDoList
{
    public class ToDo
    {
        public int Number { get; }
        private string TaskName { get; }

        public ToDo(int number, string taskName)
        {
            if (number <= 0) throw new ArgumentOutOfRangeException(nameof(number));
            Number = number;
            TaskName = taskName ?? throw new ArgumentNullException(nameof(taskName));
        }

        public override string ToString() => $"{Number} {TaskName}";
    }
}