using System;
using System.Collections.Generic;
using System.Text;
using Uni.Core.inetrfaces;
using Uni.Core.Models;

namespace Uni.Service
{
    public class StudentSerice
    {



        private readonly IStudentRepository _studentRepository;

        public StudentSerice(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }



        public async Task StudentRegister(Student student) { 
        
            var students = await _studentRepository.GetStudent();

            int lastId = 0;

            if (students.Any())
            {
                lastId = students.Max(s => s.Id);
                student.Id = lastId + 1;

            }

            else
            {
                lastId = 0;
            }

            student.password = BCrypt.Net.BCrypt.HashPassword(student.password);

            Random random = new Random();

            student.verifies = random.Next(1000, 9999).ToString();

            

            _studentRepository.SaveStudent(student);
            UniEmailService.SendEmail(student.Email, $"{student.verifies}", $"{student.verifies}  this is your verify code");

        }









        public void UpdateStudent(Student student)
        {

            if (!student.Email.Contains("@"))
            {
                throw new ArgumentException("Email is not valid");
            }


            _studentRepository.UpdateStudent(student);

        }





        public void DeleteStudent(int id)
        {
            if(id <= 0)
            {
                throw new ArgumentException("Id is not valid");
            }

            _studentRepository.DeleteStudent(id);
        }
























        public async Task Login(string email, string password)
        {
            var students = await _studentRepository.GetStudent();

            var student = students.FirstOrDefault(s => s.Email == email);

            if (student == null)
            {
                throw new Exception("Student not found");
            }

            bool passwordCorrect = BCrypt.Net.BCrypt.Verify(password, student.password);

            if (!passwordCorrect)
            {
                throw new Exception("Wrong password");
            }

            Console.WriteLine("Login successful");

            if (!student.IsVerifies) {


                throw new ArgumentException("please verify your account");
            
            }



           
        }










        public async Task Isverify(string email, string verifies)
        {
            Student student = await _studentRepository.GetStudentByEmail(email);

            if (student == null)
            {
                throw new ArgumentException("Invalid email");
            }

            if (student.verifies != verifies)
            {
                throw new ArgumentException("Invalid verify code");
            }

            Console.WriteLine("Successful verify");

            student.IsVerifies = true;
            student.verifies = null;
            UpdateStudent(student);
        }












    }
}
