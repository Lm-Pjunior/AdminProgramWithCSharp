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








        public void addUserToList()
        {
            List<UserClass> _UserList = new List<UserClass>();
            _UserList.Add(new UserClass("name", "email",/* age */ 0, /* phonenumber */ 0, "HouseAdress"));
        }

        public void removeUserOflist()
        {

        }
    }
}
