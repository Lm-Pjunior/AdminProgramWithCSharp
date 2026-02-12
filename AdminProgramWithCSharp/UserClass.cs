using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgramWithCSharp
{
    internal class UserClass
    {
        private string _name;
        private string _email;
        private string _password;
        private int _age;


        public UserClass(string name, string email, string password, int age)
        {
            _name = name;
            _email = email;
            _password = password;
            _age = age;
        }

    }
}
