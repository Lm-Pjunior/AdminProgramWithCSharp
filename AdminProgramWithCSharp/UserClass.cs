using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdminProgramWithCSharp
{
    public class UserClass
    {
        

        private string _name;
        private string _email;
        private int _age;
        private int _phonenumber;
        private string _houseAdres;

        private int _count;

        public int Age
        {
            get {return _age;}
            set { if (_age >= 18) { Console.WriteLine("You're older than 18"); }
            _age = value;}
        }
        
        public string Email
        {
            get {return _email;}
            set { if (_email.Contains ("@"))
                {
                    _email = value; 
                } 
                }
            }

        //The get is done to get the private variable  and the set allowes
          //for the possebility to chance this if i understod it correctly. the set can be public or private depending on whom
          //you want to be able to chance it
        public UserClass(string name, string email, int age, int phonenumber, string houseAdres)
        {
            //make a funcyion for typing stuff down that later be added to tnhe list
            Console.WriteLine("Write down your name.");
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
            bool repeat2 = true;
            while (repeat2)
            {
                Console.WriteLine("Write your email down it must contain a @.");
                _email = Console.ReadLine();
                if (_email.Contains("@"))
                {
                    repeat2 = false;
                }

            }

            bool repeat3 = true;

            while (repeat3)
            {
                Console.WriteLine("Write down your phonenumber it must be numbers.");
                bool intCheck2 = int.TryParse(Console.ReadLine(), out _phonenumber);
                if (intCheck2)
                {
                    repeat3 = false;
                }
            }
            
            Console.WriteLine("Write down you house adress.");
            _houseAdres = Console.ReadLine();

            
        }

       

        public void showUserStats()
        { //make a for each loop out of this.
            int number = _count;
            
            Console.WriteLine($"{number}: Showing stats, name: {_name}, email: {_email}," +
                $" age: {_age}, phonenumber: {_phonenumber}," +
                $" houseadress: {_houseAdres}.");


        }

        public void userCount()
        {
            _count++;
        }

    }
}
