using System.ComponentModel;

namespace homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {




            // დავალება 1:
            //Login სისტემა: პროგრამაში გვაქვს
            //username: admin
            //password: 1234
            //მომხმარებელს შემოჰყავს ორივე მნიშვნელობა
            // თუ სწორია კონსოლში გამოიტანე:
            //Welcome!
            // თუ არა:
            //Access denied



            //string username = "admin";
            //string password = "1234";

            //string userNameInput;
            //string passwordInput;

            //Console.WriteLine("plese neter your username");
            //userNameInput = Console.ReadLine();
            //Console.WriteLine("Please enter your password");
            //passwordInput = Console.ReadLine();

            //if (userNameInput == username && passwordInput == password)
            //{
            //    Console.WriteLine("Welcome!");


            //}
            //else
            //{
            //    Console.WriteLine("Access denied");
            //}









            //________________________________________
            // დავალება 2:
            //Calculator(switch-ით)
            //მომხმარებელი შეიყვანს:
            //•	რიცხვი 1
            //•	ოპერატორი(+-* /)
            //•	რიცხვი 2
            //კონსოლში გამოიტანე არითმეტიკული ოპერაციის შედეგი. (შემოყვანილი ოპერატორის შესაბამისად)



            //Console.WriteLine("enter first number:");
            //bool number1 = int.TryParse(Console.ReadLine(), out int num1);
            //Console.WriteLine("enter secend number");
            //bool number2 = int.TryParse(Console.ReadLine(), out int num2);


            //Console.WriteLine("enter operator");
            //char operatorInput = Console.ReadLine()[0];

            //int result = 0;

            //switch (operatorInput)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        Console.WriteLine("result: " + result);
            //        break;

            //    case '-':
            //        result = num1 - num2;
            //        Console.WriteLine("result: " + result);
            //        break;

            //    case '*':
            //        result = num1 * num2;
            //        Console.WriteLine("result: " + result);
            //        break;

            //    case '/':
            //        result = num1 / num2;
            //        Console.WriteLine("result: " + result);
            //        break;
            //}













            //________________________________________
            // დავალება 3 :
            //მომხმარებელს შეაყვანინე ასაკი:
            //            დაადგინე და კონსოლში გამოიტანე:
            //•	ბავშვი(0–12)
            //•	თინეიჯერი(13–19)
            //•	ზრდასრული(20–64)
            //•	პენსიონერი(65 +)



            Console.WriteLine("enter your age:");
            bool isValidAge = byte.TryParse(Console.ReadLine(), out byte age);

            if (isValidAge)
            {
                if (age >= 0 && age <= 12)
                {
                    Console.WriteLine("you are a child");
                }
                else if (age >= 13 && age <= 19)
                {
                    Console.WriteLine("you are a teenager");
                }
                else if (age >= 20 && age <= 64)
                {
                    Console.WriteLine("you are an adult");
                }
                else if (age >= 65)
                {
                    Console.WriteLine("you are a pensioner");
                }
            }
            else
            {
                Console.WriteLine("invalid input");

            }








            }
    }
}
