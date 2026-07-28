namespace homework_6_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            1.შექმენით jagged array სადაც: თითოეულ სტუდენტს აქვს
            //            სხვადასხვა რაოდენობის ქულა. იპოვეთ თითოეულის საშუალო ქულა.




            //int[][] studentsGrade = [
            //    [80, 90, 70],
            //    [85, 95],
            //    [78, 88, 92, 80]
            //    ];

            //for(int i = 0; i < studentsGrade.Length; i++)
            //{
            //    int sum = 0;
            //    for (int j = 0; j < studentsGrade[i].Length; j++)
            //    {
            //        sum += studentsGrade[i][j];
            //    }
            //    double average = (double)sum / studentsGrade[i].Length; // ვთვლით საშუალო ქულას, გვჭირდება double ტიპის რომ იყოს, რადგან შეიძლება არ იყოს მთელი რიცხვი
            //    Console.WriteLine($"Student {i + 1} average grade: {average}");
            //}







            //2.შექმენით რენდომული 4 ნიშნა პასკოდების არაი(10 წევრი).მომხმარებელს
            //შემოაყვანინეთ კოდი და თუ რომელიმეს დაემთხვა არაიში დაუბეჭდეთ “Correct” თუ არა და “Wrong”.



            //int[] pascodes = new int[10];

            //Random random = new Random();

            //Console.WriteLine("Enter a 4-digit passcode:");
            //bool isvalid = int.TryParse(Console.ReadLine(), out int userInput);


            //for (int i = 0; i < pascodes.Length; i++)
            //{
            //    pascodes[i] = random.Next(1000, 10000); // ვქმნით 4 ნიშნა პასკოდებს


            //    if (userInput == pascodes[i])
            //        {
            //            Console.WriteLine("Correct");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Wrong");
            //            break;
            //        }



            //}










            //3.შექმენით int-ების(მათ შორის ნეგატიური რიცხვებიც) მასივი.იპოვეთ მინიმალური
            //და მაქსიმალური რიცხვები(არ გამოიყენოთ არაის მეთოდები).


            //int[] arr = [-5, 10, 3, -2, 8, 0, -1, 7];

            //int min = arr[0];
            //int max  = arr[0];

            //for(int i = 0; i < arr.Length; i++)
            //{

            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //    if(arr[i] > max)
            //    {
            //        max = arr[i];
            //    }

            //}

            //Console.WriteLine($"Minimum number: {min}, Maximum number: {max}");



            //4.შექმენით სტრინგების მასივი და კონსოლში დაბეჭდეთ ყველა ელემენტის ყველა
            //სიმბოლო(არ გამოიყენოთ არაის მეთოდები).

            //string[] words = ["hello", "world", "example"];

            //for(int i = 0; i < words.Length; i++)
            //{
            //    for(int j = 0; j < words[i].Length; j++)
            //    {
            //        Console.Write(words[i][j] + " ");
            //    }

            //}



            //5.შექმენით იმეილების მასივი და დაადგინეთ ყველა ელემენტი თუ შეიცავს @
            //სიმბოლოს. (არ გამოიყენოთ არაის და სტრინგის ჩაშენებული მეთოდები).


            string[] emails = new string[]
            
            {    
                "goga@example.com",   
                "ninogmail.com",   
                "lukayahoo.com",  
                "mari@gmail.com",   
                "datohotmail.com",   
                "anaexample.com",   
                "sabgmail.com",   
                "takoyahoo.com",   
                "giorgi@gmail.com",  
                "ekahotmail.com"
            };


            for(int i = 0; i < emails.Length; i++)
            {
                for(int j = 0; j < emails[i].Length; j++)
                {
                    if (emails[i][j] == '@')
                    {
                        Console.WriteLine($"{emails[i]} contains '@' symbol.");
                        break; // თუ ვიპოვეთ '@', აღარ გვჭირდება ამ ელემენტის შემდგომი შემოწმება
                    }
                }
            }
























        }
    }
}
