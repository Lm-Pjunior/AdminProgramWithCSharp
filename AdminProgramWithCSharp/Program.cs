using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgramWithCSharp
{
    internal class Program
    {
        string name = Console.ReadLine();
        string email = Console.ReadLine();
        string password = Console.ReadLine();
        bool intCheck1 = int.TryParse(Console.ReadLine(), out int age);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is the first bit of code");
            UserClass User = new UserClass("name", "email", "password", 10, 10, "houseAdres");
            User.showUserStats();
        }
    }
}
