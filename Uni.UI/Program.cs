using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using Uni.Core.Enums;
using Uni.Core.inetrfaces;
using Uni.Core.Models;
using Uni.Infrastructure.repositories;
using Uni.Service;

namespace Uni.UI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");



            Student student = new Student();

            student.Id = 1;
            student.Name = "John Doe";
            student.Age = 20;
            student.Email = "kobulakobula.13@gmail.com";
            student.password = "password";
            student.Gender = Gender.male;
            student.GPA = 3.5m;
            student.subjact = new List<Subjact>
            {
                new Subjact { Title = "math", Credits = 99 },

            };



            IStudentRepository IstudenRepositories = new StudentRepository();

            StudentSerice studentService = new StudentSerice(IstudenRepositories);



            //await studentService.StudentRegister(student);



            //studentService.DeleteStudent(1);






            //სტუდენტის ვერიფიკაცია


            try
            {

                Console.WriteLine("enter your email");
                string email = Console.ReadLine();

                Console.WriteLine("enter your verify code");
                string verifies = Console.ReadLine();
                studentService.Isverify(email, verifies);

            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }














            //Login


            //try
            //{

            //    Console.WriteLine("enter email");
            //    string email = Console.ReadLine();

            //    Console.WriteLine("enter password");
            //    string password = Console.ReadLine();

            //    studentService.Login(email, password);
            //}

            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}








        }
    }
}
