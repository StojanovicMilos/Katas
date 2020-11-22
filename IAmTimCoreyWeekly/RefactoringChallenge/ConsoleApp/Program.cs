using System;
using System.Linq;
using DapperDemo.DAL;

namespace ConsoleApp
{
    public static class Program
    {
        public static void Main()
        {
            IDataAccessObject dao = new DataAccessObject(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DapperDemoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            string actionToTake;
            do
            {
                Console.Write("What action do you want to take (Display, Add, or Quit): ");
                actionToTake = Console.ReadLine();
                switch (actionToTake?.ToLower())
                {
                    case "display":
                        Console.WriteLine();
                        dao.GetAllUsers(IDataAccessObjectConstants.NoFilter).ToList().ForEach(user => Console.WriteLine(user.FullName));
                        Console.WriteLine();
                        break;
                    case "add":
                        Console.Write("What is the first name: ");
                        var firstName = Console.ReadLine();
                        Console.Write("What is the last name: ");
                        var lastName= Console.ReadLine();
                        dao.CreateUser(new UserDTO { FirstName = firstName, LastName = lastName });
                        Console.WriteLine();
                        break;
                    case "quit":
                        break;
                    default:
                        Console.WriteLine("Wrong input.");
                        break;
                }
            } while (actionToTake?.ToLower() != "quit");
        }
    }
}
