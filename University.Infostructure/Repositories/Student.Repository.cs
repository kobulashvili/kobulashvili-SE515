using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Linq;
using University.Core.Models;
using University.Core.Interfaces;


namespace University.Infostructure.Repositories
{
    public class StudentRepository : IstudenRepositories
    {


        private readonly string _path = "C:\\Users\\admin\\Desktop\\C# kobulashvili\\University.Infostructure\\Data\\Student.txt";

        public List<Student> GetStudents()
        {
            if (!File.Exists(_path))
                return new List<Student>();

            var json = File.ReadAllText(_path);

            if (string.IsNullOrWhiteSpace(json))
                return new List<Student>();

            return JsonSerializer.Deserialize<List<Student>>(json)
                   ?? new List<Student>();
        }





        //public Student StudentByEmail(string email)
        //{
        //    var students = GetStudents();
        //    var student = students.FirstOrDefault(s => s.Email == email);
        //    if (student == null)
        //    {
        //        throw new Exception("Student not found");
        //    }
        //    return student;
        //}




        public void SaveStudent(Student student) { 
            
            var students = GetStudents();
            students.Add(student);
            var json = JsonSerializer.Serialize(students);
            File.WriteAllText(_path, json);
        }


        public void UpdateStudent(Student student)
        {
            var students = GetStudents();

            var existingStudent = students.FirstOrDefault(s => s.Id == student.Id);
            if (existingStudent != null)
            {

                existingStudent.Name = student.Name;
                existingStudent.Age = student.Age;
                existingStudent.Email = student.Email;
                existingStudent.Gender = student.Gender;
                existingStudent.Subjact = student.Subjact;

            }

            var json = JsonSerializer.Serialize(students);
            File.WriteAllText(_path, json);



        }


        public void DeleteStudent(int id)
        {
            var students = GetStudents();

          

            var student = students.FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                students.Remove(student);

                var json = JsonSerializer.Serialize(students);
                File.WriteAllText(_path, json);
            }
            else
            {
                throw new Exception("Student not found");
            }
        }







    }
}
