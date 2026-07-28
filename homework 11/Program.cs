using System.Security.Cryptography.X509Certificates;

namespace homework_11
{
    internal class Program
    {
        static void Main(string[] args)
        {



//            დავალება 1
//შექმენით IOutput2 ინტერფეისი.ის უნდა შეიცავდეს ორ მეთოდს:
//void ShowEven() -აჩვენებს ლუწ მნიშვნელობებს მონაცემთა კონტეინერიდან;
//            void ShowOdd() -აჩვენებს კენტ მნიშვნელობებს მონაცემთა კონტეინერიდან;
//            კლასმა “Array”-მ, იმპლემენტირება უნდა გაუკეთოს IOutput2 ინტერფეისს.
//ShowEven მეთოდი ნებისმიერი მასივიდან ლუწ მნიშვნელობებს აჩვენებს.
//ShowOdd მეთოდი ნებისმერი მასივიდან კენტ მნიშვნელობებს აჩვენებს.
//დაწერეთ კოდი მიღებული ფუნქციონალის ტესტირებისათვის.


            int[] arr = [ 1, 2, 3, 4, 4, 5, 5, 5 ];


            Array1 arr1 = new Array1(arr); 


            Array1 arr2 = new Array1([12, 2, 3, 56, 67, 0, 5]);


            arr1.ShowEven();
            arr2.ShowOdd();



            Console.WriteLine(arr2.EqualToValue(5));
            Console.WriteLine(arr1.CountDistinct());




//            დავალება 2
//შექმენით ICalc2 ინტერფეისი.ის უნდა შეიცავდეს ორ მეთოდს:
//int CountDistinct() -აბრუნებს კონტეინერში არსებული უნიკალური მნიშვნელობების რაოდენობას.
//int EqualToValue(int valueToCompare) -აბრუნებს მნიშვნელობების რაოდენეობას, რომელიც ტოლია
//valueToCompare - ისა.
//კლასმა “Array”-მ, იმპლემენტირება უნდა გაუკეთოს ICalc2 ინტერფეისს.
//CountDistinct მეთოდი აბრუნებს მასივში არსებული უნიკალური მნიშვნელობების რაოდენობას.
//EqualToValue მეთოდი აბრუნებს მასივში არსებული მნიშვნელობების რაოდენობებს, რომელიც ტოლია
//‘valueToCompare’-ისა.
//დაწერეთ კოდი მიღებული ფუნქციონალის ტესტირებისათვის.









        }
    }
}
