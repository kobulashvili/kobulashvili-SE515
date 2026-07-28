using HW_19_mini_project.Models;

using HW_19_mini_project.Services;
using System.Text;

namespace HW_19_mini_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            List<Student> students = StudentService.GetStudents();

            while (true)
            {
                Console.WriteLine("1. ყველა სტუდენტის ჩვენება");
                Console.WriteLine("2. საუკეთესო სტუდენტის პოვნა");
                Console.WriteLine("3. GPA-ის საშუალოს გამოთვლა");
                Console.WriteLine("4. სტუდენტის ძებნა გვარით");
                Console.WriteLine("5. სტუდენტების დალაგება GPA-ის მიხედვით");
                Console.WriteLine("6. ახალი სტუდენტის დამატება");
                Console.WriteLine("7. სტუდენტის წაშლა");
                Console.WriteLine("8. პროგრამიდან გასვლა");


                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        StudentService.ShowStudents(students);
                        break;


                    case "2":
                        Student bestStudent = StudentService.GetBestStudent(students);
                        Console.WriteLine(bestStudent);
                        break;


                    case "3":
                        double average = StudentService.GetAverageGPA(students);
                        Console.WriteLine($"საშუალო GPA: {average}");
                        break;


                    case "4":
                        StudentService.SearchStudentByLastName(students);
                        break;


                    case "5":
                        StudentService.SortedSudentsWithGPA(students);
                        
                        break;


                    case "6":
                        StudentService.AddStudent(students);
                        break;


                    case "7":
                        StudentService.DeleteStudent(students);
                        break;


                    case "8":
                        Console.WriteLine("პროგრამა დასრულდა");
                        return;


                    default:
                        Console.WriteLine("არასწორი არჩევანი");
                        break;
                }
            }

        }
    }
}
