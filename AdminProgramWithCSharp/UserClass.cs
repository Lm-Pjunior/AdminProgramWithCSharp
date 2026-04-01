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
        //make sure to implement more name = name because that'll alowe more smoothing out

        private string _name;
        private string _email;
        private int _age;
        private int _phonenumber;
        private string _houseAdres;
        private int _count;

            
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        } 

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
            
            _name = name;
            _email = email;
            _age = age;
            _phonenumber = phonenumber;
            _houseAdres = houseAdres;
            
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
