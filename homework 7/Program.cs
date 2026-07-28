using System.Numerics;

namespace homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //            დავალება 1

            //დაწერეთ ფუნქცია რომელიც მიიღებს ორ ინტ პარამეტრს და აიყვანს
            //პირველ რიცხვ მეორე რიცხვის ხარისხში.
            //მაგალითად:
            //        input: 3 და 2
            //result: 3 - ის კვადრატი 9
            //სხვა მაგალითი:
            //input: 2 და 4
            //result: 2 - ის მეოთხე ხარისხში ანუ 2 * 2 * 2 * 2 იქნება 16





            //    Console.WriteLine("enter first number:");
            //    bool num1 = int.TryParse(Console.ReadLine(), out int number1);

            //    Console.WriteLine("enter second number:");
            //    bool num2 = int.TryParse(Console.ReadLine(), out int number2);

            //    double result = PowerFunc(number1, number2);

            //    Console.WriteLine(result);


            //static double PowerFunc(int x, int y)
            //{
            //    return Math.Pow(x, y);
            //}









            //დავალება 2

            //დაწერეთ ფუნქცია რომელიც მიიღებს ინტ რიცხვს დაგვიბრუნებს
            //bool მნიშვნელობას იმის მიხედვით რიცხვი
            //მარტივია თუ არა: ანუ იყოფა მარტო საკუთარ თავზე და 1 ზე.
            //მაგ:
            //input: 31
            //return: true
            //console output: 31 მარტივი რიცხვია
            //2 | P a g e
            //მაგ2:
            //input: 6
            //return: false
            //console output: 6 არ არის მარტივი რიცხვი


            //Console.WriteLine("enter a number:");

            //bool num1 = int.TryParse(Console.ReadLine(), out int number1);   




            //if (Comp(number1))
            //{
            //    Console.WriteLine($"{number1} martivi");
            //}
            //else
            //{
            //    Console.WriteLine($"{number1} shedgenili");
            //}

            //bool Comp(int x) { 

            //    if(x <= 1)

            //        return false;

            //    for(int i = 2; i < x; i++)
            //    {
            //        if (x % i == 0)
            //        {
            //            return false;
            //        }
            //    }

            //   return true;

            //}












            //დავალება 3

            //დაწერეთ რეკურსიული მეთოდი რომელიც მიიღებს რაიმე
            //სტრინგს კონსოლიდან და დაგვიბრენუბს true ან false
            //იმის მიხედვით არის თუ არა სტრინგი პალიდრომი.
            //განმარტება: პალიდრომი წარმოადგენს ისეთ ტექსტ,
            //რომელიც რომელი მხრიდანაც არ უნდა წავიკითხოთ, ის
            //ერთნაირად იკითხება.
            //მაგ:
            //inp: stepets
            //console output: stepets არის პალინდრომი.
            //მაგ2:
            //inp: noon
            //console output: noon არის პალინდრომი.




            //string name = "stepets";

            //bool Str(string name)
            //{
            //    char[] charArr = name.ToCharArray();

            //   Array.Reverse(charArr);

            //    string reversed = new string(charArr);

            //    return name == reversed;

            //};


            //Console.WriteLine(Str(name));






            //დავალება 4

            //დაწერეთ კოდი რომელიც გადაიყვანს კონსოლიდან შემოყვანილ მთელ რიცხვს მის ბინარულ ჩანაწერში
            //რეკურსიის გამოყენებით,
            //შიგნითვე დააბეჭდიეთ კონსოლში რომ არ იწვალოთ
            //მაგ:
            //        inpt: 10
            //console output: 1010
            //მაგ2:
            //        inpt: 5
            //console output: 101
















            //დავალება 5

            //დაწერეთ რეკურსიული მეთოდი რომელიც გამოთვლის ნებისმიერი რიცხვის ხარისხს, კონსოლიდან
            //შემოიტანეთ რიცხვი და ხარისხი, გადაეცით თქვენ რეკურსიულ მეთოდს და დააბრუნეთ მისი ხარისხი.
            //მაგ:
            //inpt num: 4
            //power: 3
            //console output: 4 –ი ხარისხად 3 არის: 64






            Console.WriteLine("enter number");

            bool num = int.TryParse(Console.ReadLine(), out int number);



            int Powerer(int number, int pow) {

                if (pow == 1) {

                    return number;
                }

                return number * Powerer(number, pow - 1);
            }

            Console.WriteLine(Powerer(number,3));






            //int num = 5;
            


           

            //long Factoreal(int num)
            //{
            //    long result = 1;

            //    for (int i = 1; i <= num; i++)
            //    {
            //        result *= 1;
            //    }
            //    return result;
            //}

            //Console.WriteLine(Factoreal(num));














        }

        
    }
}
