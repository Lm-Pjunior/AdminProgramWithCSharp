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
                user.showUserStats();
            }

        }

        public void removeUserOflist()
        {

        }
    }
}
