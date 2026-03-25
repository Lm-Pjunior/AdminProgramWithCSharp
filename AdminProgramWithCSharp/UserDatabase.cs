using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgramWithCSharp
{
    internal class UserDatabase
    {
        //user IDs should be sorted within this class. 

        List<UserClass> _UserList = new List<UserClass>();
        





        public void addUserToList()
        {
            
            _UserList.Add(new UserClass("name", "email",/* age */ 0, /* phonenumber */ 0, "HouseAdress"));
        }

        public void show()
        {
            foreach (var /* int & string */ user in _UserList)
            {

                user.userCount();
               user.showUserStats();
            } //use a list.last and than do a + mayby that'll work

        }

        public void removeUserOflist()
        {
            //private bool Remove(T item) might be usefull

            /*
            Easiest way to remove from list by element's property value:
            */
            Console.WriteLine("Who are the people you want to remove?");
             _UserList.RemoveAll(user => user.Name == Console.ReadLine());
            
        }

        public void editFunction()
        {
            Console.WriteLine("Who are the people you want to edit? Than continue to press enter.");
            _UserList.RemoveAll(user => user.Name == Console.ReadLine());
            _UserList.Add(new UserClass("name", "email",/* age */ 0, /* phonenumber */ 0, "HouseAdress"));


        }
    }
}
