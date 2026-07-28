using HW_19_mini_project.Exceptions;
using System.Text.RegularExpressions;

namespace HW_19_mini_project.Models
{
    internal abstract class Person
    {

        public string Name { get; set; }

        public string LastName { get; set; }

        private int _age;
        public int Age { get => _age;
            set {

                if (value < 0) {

                    throw new InvalidAgeException();
                }
                _age = value;

            } }


        private string _email;

        public string Email
        {
            get => _email;
            set
            {

                if (value != null && !value.Contains("@"))
                {
                    throw new INvalidEmailException();
                }

                if(Regex.IsMatch(value, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                {
                    //throw new InvalidEmailModelException();
                }
                              
                    _email = value;

                
            }
        }

        public string Phone { get; set; }


    }
}






