using University.Core.Interfaces;
using University.Core.Models;
using University.Infostructure.Repositories;
using University.Service;

namespace University.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the University Management System!");


            Student student = new Student();
            
            student.Name = "sadasdasdhn Doe";
            student.Age = 20;
            student.Email = "kasbdjksa@gmail.com";
            student.Subjact = new List<Subjact>
            {
                new Subjact { Id = 1, Title = "Math", Grade = 3 },
                new Subjact { Id = 2, Title = "Programing", Grade = 4 }
            };

            IstudenRepositories IstudenRepositories = new StudentRepository();

            StudentService studentService = new StudentService(IstudenRepositories);

            studentService.studenRegister(student);





            //Student student2 = new Student();
            
            //student2.Name = "asd Doe";
            //student2.Age = 20;
            //student2.Email = "kasbdjksa@gmail.com";
            //student2.Subjact = new List<Subjact>
            //{
            //    new Subjact { Id = 1, Title = "Math", Grade = 3 },
            //    new Subjact { Id = 2, Title = "Programing", Grade = 4 }
            //};

            //studentService.UpdateStudent(student2);




            //studentService.deleteStudent(1);










        }
    }
}
