using HW_19_mini_project.Enums;
using HW_19_mini_project.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW_19_mini_project.Models
{
    internal class Student : Person , IComparable<Student>
    {

        private double _gpa;
        public double GPA
        {
            get => _gpa;
            set
            {

                if (value < 0 || value > 4)
                {
                    throw new InvalidGPAException("GPA must be between 0 and 4");


                }


                this._gpa = value;

            }
        }




        public Faculty Faculty { get; set; }


        public override string? ToString()
        {
            return $"Name: {this.Name} , LastName:{this.LastName},  GPA : {this.GPA}, Faculty:{this.Faculty}.";
        }



        public int CompareTo(Student? other) {

            return this.GPA.CompareTo(other.GPA);
        }




    }
}
