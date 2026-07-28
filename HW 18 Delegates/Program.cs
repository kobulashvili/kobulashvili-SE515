using HW_18_Delegates.helper;

namespace HW_18_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {


//            მეთოდი აღწერა
//Where ფილტრავს კოლექციას და აბრუნებს მხოლოდ იმ ელემენტებს, რომლებიც მოცემულ პირობას აკმაყოფილებენ.


            IEnumerable<int> numbers = new List<int> { 1, 3, 2, 4, 6, 5, 7, 8, 9, 10 };


            IEnumerable<int> result = numbers.CustomWhere(x => x > 5);

            foreach (int x in result)
            {
                Console.WriteLine(x);
            }





            //OrderBy ალაგებს ელემენტებს ზრდადობით(Ascending).


            var sortedNumbers = numbers.CustomOrderBy(x => x);

            foreach (int x in sortedNumbers)
            {
                Console.WriteLine(x);
            }






            //First აბრუნებს პირველ ელემენტს. თუ ელემენტი არ არსებობს, აგდებს Exception - ს.


            var firstNumber = numbers.CustomFirst(x => x > 0);
            Console.WriteLine($"first number: {firstNumber}");





            //FirstOrDefault აბრუნებს პირველ ელემენტს, ხოლო თუ ვერ იპოვა — აბრუნებს default მნიშვნელობას(null, 0, false და ა.შ.).


            var firstOrDefaultNumber = numbers.FirstOrDefault(x => x > 5);
            Console.WriteLine($"first or default number {firstOrDefaultNumber}");

            //Single აბრუნებს ერთადერთ ელემენტს, რომელიც პირობას აკმაყოფილებს. თუ არ არსებობს ან ერთზე მეტია — აგდებს Exception-ს.


            var singleNumber = numbers.Single(x => x == 5);

            Console.WriteLine($"single number: {singleNumber}");



            //SingleOrDefault აბრუნებს ერთადერთ ელემენტს, ხოლო თუ არ არსებობს — აბრუნებს default - ს.თუ ერთზე მეტია, მაინც აგდებს Exception-ს.

            //Any ამოწმებს არსებობს თუ არა მინიმუმ ერთი ელემენტი, რომელიც პირობას აკმაყოფილებს. აბრუნებს true ან false.

            //All ამოწმებს აკმაყოფილებს თუ არა ყველა ელემენტი მოცემულ პირობას.აბრუნებს true ან false.

            //Count ითვლის ელემენტების რაოდენობას(სურვილის შემთხვევაში მხოლოდ იმათს, რომლებიც პირობას აკმაყოფილებენ).

            //Distinct აშორებს დუბლირებულ ელემენტებს და ტოვებს მხოლოდ უნიკალურ მნიშვნელობებს.



        }
    }
}
