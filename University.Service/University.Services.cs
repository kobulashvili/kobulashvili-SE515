using System;
using System.Collections.Generic;
using System.Text;
using University.Core.Interfaces;
using University.Core.Models;

namespace University.Service
{
    public class StudentService
    {




        


        private readonly IstudenRepositories _studentRepository;

        public StudentService(IstudenRepositories studentRepository)
        {
            _studentRepository = studentRepository;
        }







        public void studenRegister(Student student)
        {
            var students = _studentRepository.GetStudents();

            if (!student.Email.Contains("@"))
            {
                throw new ArgumentException("Email is not valid");
            }

            var lastId = students.Any() ? students.Max(s => s.Id) : 0;

            student.Id = lastId + 1;

            _studentRepository.SaveStudent(student);
        }




        public void UpdateStudent(Student student)
        {

            if (!student.Email.Contains("@"))
            {
                throw new ArgumentException("Email is not valid");
            }



            _studentRepository.UpdateStudent(student);
        }






        public void deleteStudent(int id) { 
        
            if(id <= 0)
            {
                throw new ArgumentException("Id is not valid");
            }
                _studentRepository.DeleteStudent(id);

        }



















    }
}
