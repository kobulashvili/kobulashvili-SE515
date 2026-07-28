using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace HW15_list
{

    internal class Program
    {
        static void Main(string[] args)
        {

//    1.	წიგნების დამატება: შექმენით 3 სხვადასხვა Book ობიექტი და.Add() მეთოდის გამოყენებით დაამატეთ ისინი myLibrary სიაში.

            List<Book> myLibrary = new List<Book>();


          Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
            Book book3 = new Book("1984", "George Orwell");
            myLibrary.Add(book1);
            myLibrary.Add(book2);
            myLibrary.Add(book3);
       

//2.	პრიორიტეტული წიგნის ჩასმა: გამოიყენეთ.Insert() მეთოდი, რათა მე-4 წიგნი სიის თავშივე, პირველ ადგილზე (ინდექსი 0) ჩასვათ.

            Book book4 = new Book("Pride and Prejudice", "Jane Austen");

            myLibrary.Insert(0, book4);


//3.	რაოდენობის შემოწმება: გამოიყენეთ.Count თვისება(property), რათა კონსოლში დაბეჭდოთ, თუ რამდენი წიგნია ამჟამად თქვენს ბიბლიოთეკაში.

            myLibrary.Count();
            Console.WriteLine("Number of books in the library: " + myLibrary.Count);
            //4.	კოლექციის ბეჭდვა: მარტივი foreach ციკლის გამოყენებით დაბეჭდეთ სიის თითოეული წიგნის სათაური და ავტორი,
            //რათა დაინახოთ მათი თანმიმდევრობა.

            foreach (Book book in myLibrary)
            {
                Console.WriteLine("Title: " + book.Titles + ", Author: " + book.Authors);
            }

            //5.	წიგნის წაშლა: გამოიყენეთ.RemoveAt() მეთოდი სიიდან მესამე წიგნის წასაშლელად.

            myLibrary.RemoveAt(2);



            //6.	ბიბლიოთეკის გასუფთავება: გამოიყენეთ.Clear() მეთოდი ბიბლიოთეკის სრულად დასაცარიელებლად.
            //ამის შემდეგ კვლავ დაბეჭდეთ წიგნების რაოდენობა იმის დასამტკიცებლად, რომ სიაში 0 ელემენტია.

            myLibrary.Clear();

            Console.WriteLine("QTY of books" + " " + myLibrary.Count);

        }
    }
}
