using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleToDoList
{
    class Program
    {
        private static readonly List<ToDo> ToDos = new List<ToDo>
        {
            new ToDo(1, "task 1"),
            new ToDo(2, "task 2"),
            new ToDo(3, "task 3"),
            new ToDo(4, "task 4")
        };

        //skipping user input validation
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter command");
                switch (Console.ReadLine()?.ToLower())
                {
                    case "add":
                        AddToDo();
                        break;
                    case "finish":
                        FinishToDo();
                        break;
                    case "print":
                        PrintThreeToDos();
                        break;
                    case "print all":
                        PrintToDos();
                        break;
                    case "exit":
                        return;
                    default:
                        HandleIncorrectCommand();
                        break;
                }
            }
        }

        private static void AddToDo()
        {
            Console.WriteLine("Enter number");
            int newTaskNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter task name");
            string taskName = Console.ReadLine();
            ToDos.Add(new ToDo(newTaskNumber, taskName));
        }

        private static void FinishToDo()
        {
            Console.WriteLine("Enter number");
            int existingTaskNumber = Convert.ToInt32(Console.ReadLine());
            var todo = ToDos.FirstOrDefault(t => t.Number == existingTaskNumber);
            if (todo != null)
            {
                ToDos.Remove(todo);
            }
            else
            {
                Console.WriteLine("todo with number " + existingTaskNumber + " doesn't exist in the list");
            }
        }

        private static void PrintThreeToDos()
        {
            foreach (var toDo in ToDos.Take(3))
            {
                Console.WriteLine(toDo.ToString());
            }
        }

        private static void PrintToDos()
        {
            foreach (var toDo in ToDos)
            {
                Console.WriteLine(toDo.ToString());
            }
        }

        private static void HandleIncorrectCommand() => Console.WriteLine("Incorrect command, try again");
    }
}
