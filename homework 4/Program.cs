namespace homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            დავალება 1
            //გააკეთე კონსოლიდან შემოყვანილი რიცხვის გამრავლების ტაბულის ერთი ბლოკი. (ათის ნამრავლის
            //ჩათვლით)
            //შესაყვანი სატესტო მონაცემი: 13
            //მოსალოდნელი შედეგი:
            //13 * 1 = 13
            //13 * 2 = 26.........
            //13 * 10 = 130


            //Console.WriteLine("enter a number:");

            //bool number = int.TryParse(Console.ReadLine(), out int num1);


            //for (int i = 1; i <= num1; i++)
            //{
            //    Console.WriteLine($"{num1} * {i} = {num1 * i}");
            //}











            //დავალება 2
            //დაწერეთ პროგრამა რომელიც გამოიტანს კონსოლში ფიფქებით შედგენილ პირამიდის ფორმას.მაგალითად
            //ციფრი 4–ის შეყვანისას კონსოლში გამოვა შემდეგი სახის პირამიდა:
            //           *
            //           **
            //           ***
            //           ****



            //Console.WriteLine("enter a number:");
            //bool number = int.TryParse(Console.ReadLine(), out int num1);

            //for(int i = 0; i <= num1; i++)
            //{     

            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("*");
            //}










            //           დავალება 3
            //დაწერეთ პროგრამა რომელიც კონსოლიდან წაკითხულ რიცხვამდე
            //დააჯამებს ყველა ლუწ რიცხვს და პასუხი
            //გამოიტანეთ კონსოლში




            //Console.WriteLine("enter a number:");
            //bool number2 = int.TryParse(Console.ReadLine(), out int num2);
            //int sum = 0;

            //for (int i = 0; i <= num2;    i+=2) {
            //    sum += i;

            //}
            //        Console.WriteLine(sum);



            //Console.WriteLine("enter a number:");
            //bool number2 = int.TryParse(Console.ReadLine(), out int num2);
            //int sum = 0;

            //for (int i = 0; i <= num2;   i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        sum += i;
            //    }   

            //}
            //Console.WriteLine(sum);





            //დავალება 4
            //დაწერეთ პროგრამა რომელიც აირჩევს რენდომულ რიცხვს.
            //მომხმარებელმა შემოიყვანოს კონსოლიდან რიცხვი მანამ არ
            //გამოიცნობს არჩეულ რენდომულ რიცხვს


            int randomNumber = new Random().Next(1, 10);
            Console.WriteLine("enter number between 1 and 10:");
            bool number = int.TryParse(Console.ReadLine(), out int num1);

         while(num1 != randomNumber)
            {
                Console.WriteLine("try again");
                Console.WriteLine("enter number between 1 and 10:");
                number = int.TryParse(Console.ReadLine(), out num1);
            }
            Console.WriteLine("you guessed the number");

            //            enter number between 1 and 10:
            //4
            //you guessed the number

            //C: \Users\admin\Desktop\C#\homework 4\bin\Debug\net10.0\homework 4.exe (process 20024) exited with code 0 (0x0).
            //To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
            //Press any key to close this window. . .

















        }
    }
}
