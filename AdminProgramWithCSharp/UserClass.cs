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

        public string Name 
        {
            get {return _name;}

            set {_name = value;}
        }

        public int Age
        {
            get {return _age;}
            set { if (_age >= 18) { Console.WriteLine("You're older than 18"); }
            _age = value;}
        } //The get is done to get the private variable  and the set allowes
          //for the possebility to chance this if i understod it correctly. the set can be public or private depending on whom
          //you want to be able to chance it
        public UserClass(string Name, string email, string password, int Age, int phonenumber, string houseAdres)
        {
            _name = Console.ReadLine();
           
            bool repeat = true;
            while (repeat) 
            {
                Console.WriteLine("Type down your age, it has to be a number");
                bool intCheck = int.TryParse(Console.ReadLine(), out _age);
                if (intCheck)
                {
                    repeat = false;
                }
            }
            _email = email;
            _password = password;
            _phonenumber = phonenumber;
            _houseAdres = houseAdres;
            
        }
        public void showUserStats()
        {
            Console.WriteLine($"Showing stats, name: {Name}, email: {_email}, password: {_password}, age: {_age}, phonenumber: {_phonenumber}," +
                $" houseadress: {_houseAdres}.");
        }

    }
}
