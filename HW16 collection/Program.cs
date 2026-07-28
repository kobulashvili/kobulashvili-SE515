using static System.Net.Mime.MediaTypeNames;

namespace HW16_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {



//            ამოცანის აღწერა
//შექმენით Console Application, სადაც მართავთ სტუდენტების ქულებს.
//________________________________________
//მოთხოვნები
//1.გამოიყენეთ ორი სტრუქტურა:
//•	List<string> → სტუდენტების სახელებისთვის 
//•	Dictionary<string, int> → სტუდენტის სახელი და მისი ქულა
//________________________________________
//2.ფუნქციონალი
//პროგრამამ უნდა შეძლოს:
//            სტუდენტის დამატება
//•	მომხმარებელი შეიყვანს სახელს და ქულას
//•	დაამატეთ List-ში და Dictionary-ში
// სტუდენტის ძებნა
//•	მომხმარებელი შეიყვანს სახელს
//•	თუ არსებობს → აჩვენეთ ქულა 
//•	თუ არა → დაბეჭდეთ „სტუდენტი ვერ მოიძებნა“ 
// ქულის განახლება
//•	მომხმარებელი შეიყვანს სახელს და ახალ ქულას 
//•	თუ სტუდენტი არსებობს → განაახლეთ ქულა Dictionary - ში
// ყველა სტუდენტის ჩვენება
//•	List - ის მიხედვით დაბეჭდეთ ყველა სტუდენტი და მათი ქულა





            List<string> studentsName = new List<string>();

            Dictionary<string, int> studentsInfo = new Dictionary<string, int>();

            bool isRunning = true;


            while (true)  {
          
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Search student");
                Console.WriteLine("3. Update student score");
                Console.WriteLine("4. Show all students");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                { 
                case 1:
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter student score: ");
                        int score = Convert.ToInt32(Console.ReadLine());
                        studentsName.Add(name);
                        studentsInfo.Add(name, score);
                        break;

                case 2:
                        Console.Write("Enter student name to search: ");
                        string searchName = Console.ReadLine();
                        if (studentsInfo.ContainsKey(searchName))
                        {
                            Console.WriteLine($"Student {searchName} has score: {studentsInfo[searchName]}");
                        }
                        else
                        {
                            Console.WriteLine("Student not found");
                        }
                        break;

                case 3:
                        Console.Write("Enter student name to update score: ");
                        string findName = Console.ReadLine();
                        if (studentsInfo.ContainsKey(findName))
                        {
                            Console.Write("Enter new score: ");
                            int newScore = Convert.ToInt32(Console.ReadLine());
                            studentsInfo[findName] = newScore;
                            Console.WriteLine($"Student {findName}'s score updated to {newScore}");
                        }
                        else
                        {
                            Console.WriteLine("Student not found");
                        }
                        break;

                 case 4:
                        Console.WriteLine("All students and their scores:");
                        foreach (var student in studentsInfo)
                        {
                            Console.WriteLine($"Name: {student.Key}, Score: {student.Value}");
                        }
                        
                        break;









                }

                



            }











        }
    }
}
