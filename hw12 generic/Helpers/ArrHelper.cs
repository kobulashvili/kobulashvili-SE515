using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace hw12_generic.Helpers
{
    internal class ArrHelper
    {

        int[] collection = [1, 2, 2, 3, 4];

        //            შექმენით ArrayHelper  კლასი და დაამატეთ შემდეგი generic მეთოდები

        //• PrintReverse<T>
        //დაბეჭდოს მასივის ელემენტები უკუღმა, ბოლო ელემენტიდანპირველამდე.

        //public static void PrintReverse<T>(T[] Collection)
        //{
        //    Array.Reverse(Collection);
        //    foreach (var item in Collection)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}







        //• GetFirstElement<T>
        //დააბრუნოს მასივის პირველი ელემენტი.



        public static T GetFirstElement<T>(T[] collection)
        {
            foreach (var item in collection)
            {
                return item;

            }
            return default;
        }


        //• GetLastElement<T>
        //დააბრუნოს მასივის ბოლო ელემენტი.

        public static T GetlastElement<T>(T[] collection)
        {
            Array.Reverse(collection);
            foreach (var item in collection)
            {
                return item;
            }

            return default(T);
        }



        //• ContainsElement<T>
        //შეამოწმოს, შეიცავს თუარა მასივი გადაცემულ მნიშვნელობას და დააბრუნოს true ან false.

        public bool  ContainsElement<T>(T[] collection, T searchfor)
            {
           foreach(var item in collection)
            {
                return item.Equals(searchfor);
            }

           return false;
            }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }


        //• CountElements<T>
        //დააბრუნოს მასივში არსებული ელემენტების რაოდენობა(Length-ის გამოყენების გარეშე).

        public static int CountElements<T>(T[] collection)
        {
            int count = 0;
            foreach (var item in collection)
            {
                count++;
            }
            return count;
        }


        //• FindIndex<T>
        //მოძებნოს გადაცემული ელემენტის ინდექსი.თუ ვერიპოვა, დააბრუნოს - 1.

  
        public int CountFindIndex<T>(T[] collection, T searchfor)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i].Equals(searchfor))
                {
                    return i;
                }
            }

            return -1;
        }

        //• Swap<T>
        //შეცვალოს ორი გადაცემული ინდექსის ელემენტები ერთმანეთში.


        public static void Swap<T>(T[] collection, int index1, int index2)
        {
            T temp = collection[index1];
            collection[index1] = collection[index2];
            collection[index2] = temp;
        }




    }
}
