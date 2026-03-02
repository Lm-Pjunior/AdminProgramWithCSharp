using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgramWithCSharp
{
    public class UserClass
    {
        private string _name;
        private string _email;
        private string _password;
        private int _age;
        private int _phonenumber;
        private string _houseAdres;

        public UserClass(string name, string email, string password, int age, int phonenumber, string houseAdres)
        {
            name = _name;
            _email = email;
            _password = password;
            _age = age;
            _phonenumber = phonenumber;
            _houseAdres = houseAdres;
            _name = Console.ReadLine();
        }
        public void showUserStats()
        {
            Console.WriteLine($"Showing stats, name: {_name}, email: {_email}, password: {_password}, age: {_age}, phonenumber: {_phonenumber}," +
                $" houseadress: {_houseAdres}.");
        }

    }
}
