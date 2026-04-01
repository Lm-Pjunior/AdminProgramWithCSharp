using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdminProgramWithCSharp
{
    internal class UserDatabase
    {
        //user IDs should be sorted within this class. 

        List<UserClass> _UserList = new List<UserClass>();
        





        public void addUserToList()
        {

            Console.WriteLine("Write down your name.");
            string _name = Console.ReadLine();

            Console.WriteLine("Type down your age, it has to be a number");
            bool intCheck = int.TryParse(Console.ReadLine(), out int _age);

            bool repeat = true;
            while (repeat)
            {
                
                if (intCheck)
                {
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Type down your age, it has to be a number");
                    intCheck = int.TryParse(Console.ReadLine(), out _age);
                }
            }

            Console.WriteLine("Write your email down it must contain a @.");
            string _email = Console.ReadLine();

            bool repeat2 = true;
            while (repeat2)
            {
                
                if (_email.Contains("@"))
                {
                    repeat2 = false;
                }
                else 
                {
                    Console.WriteLine("Write your email down it must contain a @.");
                    _email = Console.ReadLine(); 
                }

            }

            Console.WriteLine("Write down your phonenumber it must be numbers.");
            bool intCheck2 = int.TryParse(Console.ReadLine(), out int _phonenumber);

            bool repeat3 = true;

            while (repeat3)
            {
                
                if (intCheck2)
                {
                    repeat3 = false;
                }
                else
                {
                    Console.WriteLine("Write down your phonenumber it must be numbers.");
                     intCheck2 = int.TryParse(Console.ReadLine(), out _phonenumber);
                }
                
            }
            Console.WriteLine("Write down you house adress.");
            string _houseAdress = Console.ReadLine();


            _UserList.Add(new UserClass(_name,_email,_age,_phonenumber, _houseAdress));
            foreach (var /* int & string */ user in _UserList)
            {
                user.userCount();
            }
        } //should be fixed after switching the name = _name so it should be _name = name;

        public void show()
        {
            foreach (var /* int & string */ user in _UserList)
            {

                
               user.showUserStats();
            } 

        }

        public void removeUserOflist()
        {
        
            string removal = Console.ReadLine();
            /*
            Easiest way to remove from list by element's property value:
            */

            Console.WriteLine("Who are the people you want to remove?");
             _UserList.RemoveAll(user => user.Name == removal);
            //use a string by the user.Name = in order to delete it
        }

        public void editFunction()
        {
            string removing = Console.ReadLine();
            Console.WriteLine("Who are the people you want to edit? Than continue to press enter.");

            _UserList.RemoveAll(user => user.Name == removing);
          addUserToList();
            

        }
    }
}
