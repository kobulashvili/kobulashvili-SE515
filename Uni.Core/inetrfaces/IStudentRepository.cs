using System;
using System.Collections.Generic;
using System.Text;
using Uni.Core.Models;

namespace Uni.Core.inetrfaces
{
    public interface IStudentRepository
    {


        Task <List<Student>> GetStudent();

        Task <List<Student>> SaveStudent(Student student);


        Task  UpdateStudent(Student student);

        Task DeleteStudent(int Id);

        Task  <Student> GetStudentByEmail(string Email);

    }
}

   