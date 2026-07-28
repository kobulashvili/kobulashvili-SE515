namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //დავალება 1
            //დაწერეთ C# Sharp პროგრამა, რომლითაც მომხმარებელი შეიყვანს ამომრჩევლის ასაკს და პროგრამა
            //განსაზღვრავს, აქვს თუ არა მას არჩევნებზე ხმის მიცემის უფლება.
            //შესაყვანი სატესტო მონაცემი: 18
            // მოსალოდნელი შედეგი: გილოცავ! ხმის მიცემის უფლება გაქვთ.
            //–––––––––––––––––––––––
            //შესაყვანი სატესტო მონაცემი: 15
            //მოსალოდნელი შედეგი: სამწუხაროდ ხმის მიცემის უფლება ჯერ არ გაქვთ.



            //Console.OutputEncoding = Encoding.UTF8;


            //Console.WriteLine("enter your age:");

            //bool isValidAge = byte.TryParse(Console.ReadLine(), out byte age);

            //if (age >= 18)
            //{
            //    Console.WriteLine("თქვენ გაქვთ ხმის მიცემის უფლება");
            //}
            //else
            //{
            //    Console.WriteLine("სამწუხაროდ ხმის მიცემის უფლება ჯერ არ გაქვთ");
            //}






            //დავალება 2

            //დაწერეთ C# პროგრამა, რომელიც დაადგენს სამ რიცხვს შორის უდიდესს.
            //შესაყვანი სატესტო მონაცემი:
            //შეიყვანეთ პირველი რიცხვი: 25
            //შეიყვანეთ მე-2 რიცხვი: 63
            //შეიყვანეთ მე-3 რიცხვი: 10
            //მოსალოდნელი შედეგი: მე - 2 რიცხვი მაქსიმალურია წარმოდგენილ
            //რიცხვებს შორის


            //ცოტა გადავაკეთე დავალება,

            //Console.WriteLine("enter first number:");
            //bool num1 = int.TryParse(Console.ReadLine(), out int number1);
            //Console.WriteLine("enter second number:");
            //bool num2 = int.TryParse(Console.ReadLine(), out int number2);
            //Console.WriteLine("enter third number:");
            //bool num3 = int.TryParse(Console.ReadLine(), out int number3);

            //if (number1 > number2 && number1 > number3)
            //{
            //    Console.WriteLine("first number is highest ");
            //}
            //else if (number2 > number1 && number2 > number3)
            //{
            //    Console.WriteLine("second number is highest");
            //}
            //else if (number3 > number1 && number3 > number2)
            //{
            //    Console.WriteLine("third number is highest");
            //}





            //დავალება 3
            //დაწერეთ C# პროგრამა ორი მოცემული მთელი რიცხვის ჯამის გამოსათვლელად. თუ ეს ორი რიცხვი
            //ერთნაირია, მაშინ დააბრუნეთ გასამმაგებული მათი ჯამი.
            // შეყვანის ნიმუში:
            // 1, 2
            // 3, 2
            // 2, 2
            // მოსალოდნელი შედეგი:
            // 3
            // 5
            // 12


            //   Console.WriteLine("enter first number:");
            //bool num1 = int.TryParse(Console.ReadLine(), out int number1);
            //Console.WriteLine("enter second number:");
            //bool num2 = int.TryParse(Console.ReadLine(), out int number2);


            //if (number1 != number2)
            //{
            //    number1 += number2;
            //    Console.WriteLine("the sum of two numbers is " + number1);
            //}
            //else if (number1 == number2)
            //{
            //    number1 = (number1 + number2) * 3;
            //    Console.WriteLine("the sum of two numbers is " + number1);
            //}
            //else
            //{
            //    Console.WriteLine("invalid input");
            //}






            //in class

            //Console.WriteLine("enter day of the week:");

            //bool isValidDay = byte.TryParse(Console.ReadLine(), out byte day);

            //switch (day)
            //{

            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:

            //        Console.WriteLine("Thursday");
            //        break;

            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("invalid input");
            //        break;
            //}





            //Console.WriteLine("enter grade:");

            //bool isValidGrade = byte.TryParse(Console.ReadLine(), out byte grade);

            //if (!isValidGrade)
            //{
            //    Console.WriteLine("invalid input");
            //}
            //else if (grade >= 90 && grade <= 100)
            //{
            //    Console.WriteLine("A")„„„;
            //}
            //else if (grade >= 70 && grade <= 89)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (grade >= 50 && grade <= 69)
            //{
            //    Console.WriteLine("C");

            //}
            //else { Console.WriteLine("F"); }







            //int[][] container = [
            //    [40,50, 60],
            //    [70, 80, 90],
            //    [100, 110, 120]
            //    ];

            //for (int i = 0; i < container.Length; i++)
            //{
            //    for (int j = 0; j < container[i].Length; j++)
            //    {
            //        Console.Write(container[i][j] + " ");
            //    }
            //    Console.WriteLine();









            //string palindrome = "ai ia";


            //char[] symbols = palindrome.ToCharArray();


            //Array.Reverse(symbols);


            //char[] reversed = symbols;

            //bool isPal = true;

            //for (int i = 0; i < symbols.Length; i++)

            //{

            //    if (symbols[i] != reversed[i])

            //    {

            //        isPal = false;

            //        break;

            //    }

            //}


            //Console.WriteLine(isPal);









            //int[] numbers = [3, 5, -4, 8, 11, 1, -1, 6];

            //int[] resultArr = [];

            //bool number = int.TryParse(Console.ReadLine(), out int targetSum);
            //int index = 0;


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for(int j = i + 1; j < numbers.Length; j++)
            //    {

            //        if( targetSum == numbers[i] + numbers[j] ) {


            //            resultArr[index] = [numbers[i], numbers[j] ];
            //            index++;
            //    }
            //}






            //მაღაზიაში მოვიდა კონტეინერი მასში არის 
            //	სხვა და სხვა ფასის სხვა და სხვა ყუთები 

            //ცალკე ყუთების ჯამური ღირებულება 
            //	მთლიანი კონტეინერის ღირებულება



            int[][] boxses = [
                [20, 30, 40],
                [50, 60, 100],
                [120, 140, 200],
                [324,234, 500],
                ];


            int totalSum = 0;
      

            for (int i = 0; i < boxses.Length; i++)
            {

            int boxSum = 0;


                for (int j = 0; j < boxses[i].Length; j++)
                {
                    totalSum += boxses[i][j];

                    

                    boxSum += boxses[i][j];
                }

                Console.WriteLine($"{i+1} box sum is {boxSum}");
            }

            Console.WriteLine($"total sum is {totalSum}");










        }
    }
    }
