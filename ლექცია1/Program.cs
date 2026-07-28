using System.Text;

namespace ლექცია1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");



            //მომხმარებელმა შემოიყვანოს sallary
            //თუ მეტია 1000 ზე 
            //	დავუმატოთ ბონუსი 20% და
            //	დავუბეჭდოთ რა ეკუთვნინს
            //	თუ მეტია 1500 დავუმატოთ ბონუსი 15%
            //	და დავუბეჭდოთ რა ეკუთვნინს



            //Console.WriteLine("Please enter your salary:");

            //bool isValidInput = decimal.TryParse(Console.ReadLine(), out decimal salary);


            //if(salary >=1000 && salary <= 1500 && isValidInput)
            //{
            //    salary *= 1.2m;
            //}
            //else if(salary >=1500 && isValidInput) {

            //    salary *= 1.15m;

            //}

            //else
            //{
            //    Console.WriteLine("you don't have bonus");
            //}

            //მომხმარებელმა შემოიყვანოს ასაკი და შემოიყვანოს მოქალაქეობა "GEO"  
            //	თუ ქართველია და 0 18 მდეა უფასო ბილეთი
            //	ქართველია და სრულწლოვანია მივცეთ ნახევარ ფასად 
            //	და თუ ქართველი არ არის სრული თანხა გადაიხადოს



            Console.WriteLine("enter your citizenship:");

            string citizenship = Console.ReadLine();

            Console.WriteLine("enter your age:");

            bool isValidAge = byte.TryParse(Console.ReadLine(), out byte age);


            if (citizenship == "GEO" && age < 18 && isValidAge)
            {
                Console.WriteLine("you have free ticket");
            }
            else if (citizenship == "GEO" && age >= 18 && isValidAge)
            {
                Console.WriteLine("you have half price ticket");

            }
            else if (isValidAge)
            {
                Console.WriteLine("you have to pay full price");
            }
            else
            {
                Console.WriteLine("you have invalid input");
            }






        }
    }

}
