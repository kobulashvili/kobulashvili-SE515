using HW_19_mini_project.Enums;
using HW_19_mini_project.Models;

namespace HW_19_mini_project.Services
{
    internal class StudentService
    {
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student { Name = "გიორგი", LastName = "beridze", Age = 20, Email = "g.beridze@gmail.com", Phone = "595112233", GPA = 3.8, Faculty = Faculty.IT },
                new Student { Name = "ნინო", LastName = "კაპანაძე", Age = 21, Email = "nino.kapanadze@TSU.ge", Phone = "577445566", GPA = 3.9, Faculty = Faculty.Business },
                new Student { Name = "ლუკა", LastName = "მგელაძე", Age = 19, Email = "luka.mgeladze@tech.online", Phone = "555778899", GPA = 2.7, Faculty = Faculty.IT },
                new Student { Name = "ანა", LastName = "გელაშვილი", Age = 22, Email = "ana.gela@yahoo.com", Phone = "591223344", GPA = 3.5, Faculty = Faculty.IT },
                new Student { Name = "დავით", LastName = "მაისურაძე", Age = 20, Email = "d.maisuradze@freeuni.edu", Phone = "599334455", GPA = 3.2, Faculty = Faculty.Design },
                new Student { Name = "მარიამ", LastName = "კვარაცხელია", Age = 21, Email = "mari.kvara@gmail.com", Phone = "551667788", GPA = 4.0, Faculty = Faculty.IT },
                new Student { Name = "ირაკლი", LastName = "თოდუა", Age = 23, Email = "i.todua@outlook.com", Phone = "574889900", GPA = 2.9, Faculty = Faculty.IT },
                new Student { Name = "ელენე", LastName = "აშბა", Age = 19, Email = "elene.ashba@art.london", Phone = "593556677", GPA = 3.6, Faculty = Faculty.Design },
                new Student { Name = "ალექსანდრე", LastName = "ხუციშვილი", Age = 22, Email = "sandro.khuci@gmail.com", Phone = "598119922", GPA = 3.1, Faculty = Faculty.Medicine },
                new Student { Name = "თამარ", LastName = "შენგელია", Age = 20, Email = "tamuna.sh@Iliauni.ge", Phone = "555443322", GPA = 3.7, Faculty = Faculty.Medicine }
            };

          

            return students;
        }


      
        public static void ShowStudents(List<Student> students)
        {

         
            foreach (Student student in students)
            {
                
                Console.WriteLine(
                    $"{student.Name} {student.LastName} | Age: {student.Age} | Faculty: {student.Faculty} | GPA: {student.GPA}"
                );
            }
        }


      
        public static Student GetBestStudent(List<Student> students)
        {
            Student bestStudent = students[0];

            foreach (Student student in students)
            {
                if (student.GPA > bestStudent.GPA)
                {
                    bestStudent = student;
                }
            }
            Console.WriteLine("ყველაზე მაქალი GPA " + bestStudent);

            return bestStudent;
        }



        public static void SearchStudentByLastName(List<Student> students)
        {
            Console.Write("შეიყვანეთ სტუდენტის გვარი: ");

            string lastName = Console.ReadLine().Trim().ToLower();

            bool found = false;

            foreach (Student student in students)
            {
                if (student.LastName.ToLower().Contains(lastName))
                {
                    Console.WriteLine("სტუდენტი ნაპოვნია:");
                    Console.WriteLine(student);

                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("ასეთი გვარის მქონე სტუდენტი ვერ მოიძებნა.");
            }
        }


        public static double GetAverageGPA(List<Student> students)
        {
            double sum = 0;

            for (int i = 0; i < students.Count; i++)
            {
                sum = sum + students[i].GPA;
            }

            Console.WriteLine("GPA საშუალო: " + sum / students.Count);
            
            return sum / students.Count;

        }








        public static void SortedSudentsWithGPA(List<Student> students)
        {

            students.Sort();
            foreach (Student student in students)
            {

                Console.WriteLine(
                    $"{student.Name} {student.LastName} | Age: {student.Age} | Faculty: {student.Faculty} | GPA: {student.GPA}"
                );
            }
        }










        public static void AddStudent(List<Student> students)
        {
            Console.Write("სახელი: ");
            string? name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("სახელი სავალდებულოა.");
                return;
            }

            Console.Write("გვარი: ");
            string? lastName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(lastName))
            {
                Console.WriteLine("გვარი სავალდებულოა.");
                return;
            }

            Console.Write("ასაკი: ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("ასაკი უნდა იყოს რიცხვი.");
                return;
            }

            if (age <= 16)
            {
                Console.WriteLine("ასაკი უნდა იყოს 16-ზე მეტი.");
                return;
            }

            Console.Write("Email: ");
            string? email = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                Console.WriteLine("Email არასწორია.");
                return;
            }

            Console.Write("ტელეფონი: ");
            string? phone = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(phone))
            {
                Console.WriteLine("ტელეფონი სავალდებულოა.");
                return;
            }

            Console.Write("GPA: ");
            if (!double.TryParse(Console.ReadLine(), out double gpa))
            {
                Console.WriteLine("GPA უნდა იყოს რიცხვი.");
                return;
            }

            if (gpa < 0 || gpa > 100)
            {
                Console.WriteLine("GPA უნდა იყოს 0-100 შუალედში.");
                return;
            }

            Console.Write("ფაკულტეტი (IT, Business, Design, Medicine): ");

            if (!Enum.TryParse(Console.ReadLine(), true, out Faculty faculty))
            {
                Console.WriteLine("ფაკულტეტი არასწორია.");
                return;
            }

            Student student = new Student
            {
                Name = name,
                LastName = lastName,
                Age = age,
                Email = email,
                Phone = phone,
                GPA = gpa,
                Faculty = faculty
            };

            students.Add(student);

            Console.WriteLine("სტუდენტი წარმატებით დაემატა!");
        }




        public static void DeleteStudent(List<Student> students)
        {
            Console.Write("შეიყვანეთ სტუდენტის Email: ");

            string email = Console.ReadLine().Trim().ToLower();

            Student studentToDelete = null;


            foreach (Student student in students)
            {
                if (student.Email.ToLower().Equals(email))
                {
                    studentToDelete = student;
                    break;
                }
            }


            if (studentToDelete != null)
            {
                students.Remove(studentToDelete);

                Console.WriteLine("სტუდენტი წაიშალა.");
            }
            else
            {
                Console.WriteLine("ასეთი Email-ის მქონე სტუდენტი ვერ მოიძებნა.");
            }
        }









    }
}