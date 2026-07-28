using System.Text.Json;
using Uni.Core.inetrfaces;
using Uni.Core.Models;

namespace Uni.Infrastructure.repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly string _path =
            @"C:\Users\admin\Desktop\C# kobulashvili\Uni.Infrastructure\data\Student.txt";

        public async Task<List<Student>> GetStudent()
        {
            if (!File.Exists(_path))
            {
                return new List<Student>();
            }

            var json = await File.ReadAllTextAsync(_path);

            if (string.IsNullOrWhiteSpace(json))
            {
                return new List<Student>();
            }

            try
            {
                return JsonSerializer.Deserialize<List<Student>>(json)
                       ?? new List<Student>();
            }
            catch (JsonException)
            {
                return new List<Student>();
            }
        }

        public async Task<Student?> GetStudentByEmail(string email)
        {
            var students = await GetStudent();

            return students.FirstOrDefault(s => s.Email == email);
        }

        public async Task<List<Student>> SaveStudent(Student student)
        {
            var students = await GetStudent();

            students.Add(student);

            var json = JsonSerializer.Serialize(students);

            await File.WriteAllTextAsync(_path, json);

            return students;
        }

        public async Task UpdateStudent(Student student)
        {
            var students = await GetStudent();

            var existingStudent = students.FirstOrDefault(s => s.Id == student.Id);

            if (existingStudent == null)
            {
                throw new Exception("Student not found");
            }

            existingStudent.Name = student.Name;
            existingStudent.Age = student.Age;
            existingStudent.Email = student.Email;
            existingStudent.password = student.password;
            existingStudent.Gender = student.Gender;
            existingStudent.GPA = student.GPA;
            existingStudent.subjact = student.subjact;
            existingStudent.verifies = student.verifies;
            existingStudent.IsVerifies = student.IsVerifies;

            var json = JsonSerializer.Serialize(students);

            await File.WriteAllTextAsync(_path, json);
        }

        public async Task DeleteStudent(int id)
        {
            var students = await GetStudent();

            var studentToRemove = students.FirstOrDefault(s => s.Id == id);

            if (studentToRemove == null)
            {
                throw new Exception("Student not found");
            }

            students.Remove(studentToRemove);

            var json = JsonSerializer.Serialize(students);

            await File.WriteAllTextAsync(_path, json);
        }
    }
}
