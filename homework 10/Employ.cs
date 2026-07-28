using homework_10.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace homework_10
{
    public class Employ
    {



        private DateTime _DateOfBirth {  get; set; }



        public Employ(string name, string surname, DateTime dateOfBirth, Country country, Gender gender, Contact contact)
        {
            
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Country = country;
            Gender = gender;
            Contact = contact;
        }





        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime DateOfBirth {
            get { return _DateOfBirth; }

            set
            {
                if(value > DateTime.Now)
                {
                    Console.WriteLine("date of birth");
                    return;

                }

                _DateOfBirth = value;
            }
        }




        public Country Country { get; set; }

        public Gender Gender { get; set; }

        public Contact Contact { get; set; }





        public int GetAge()
        {
            int age = DateTime.Now.Year - DateOfBirth.Year;

            if(DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
            {
                age -- ;
            }
            return age;
        }










    }

}
