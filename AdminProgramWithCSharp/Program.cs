using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgramWithCSharp
{
    internal class Program
    {
        //string name = Console.ReadLine();
        string email = Console.ReadLine();
        string password = Console.ReadLine();
        bool intCheck1 = int.TryParse(Console.ReadLine(), out int age);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is the first bit of code");
            UserDatabase User = new UserDatabase();
           // User.nameCharacter();
            


            string insideSystem;
            bool on = true;

            while (on)
            {
                Console.WriteLine("write down create to create a new character or type show to show all");
                insideSystem = Console.ReadLine();
                if(insideSystem == "create") 
                {
                    User.addUserToList();
                }
                if(insideSystem == "show")
                {
                    User.show();
                }
            }
        }
    }
}
