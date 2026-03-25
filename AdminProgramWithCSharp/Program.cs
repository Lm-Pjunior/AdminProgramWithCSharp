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
                Console.WriteLine("Would you like to 'create', 'remove', 'edit', 'show' or 'shutdown'?");
                insideSystem = Console.ReadLine();
                if(insideSystem == "create") 
                {
                    User.addUserToList();
                    Console.Clear();
                }
                if(insideSystem == "show")
                {
                    User.show();
                }
                if (insideSystem == "remove")
                {
                    User.removeUserOflist();
                    Console.Clear();
                }
                if(insideSystem == "edit")
                {
                    User.editFunction();
                }
                if(insideSystem == "shutdown")
                {
                    on = false;
                }

            }
        }
    }
}
