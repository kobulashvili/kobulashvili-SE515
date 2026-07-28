using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HW_18_Delegates.helper
{
    internal static class CustomMeth
    {


        //            მეთოდი აღწერა
        //Where ფილტრავს კოლექციას და აბრუნებს მხოლოდ იმ ელემენტებს, რომლებიც მოცემულ პირობას აკმაყოფილებენ.


        public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            foreach (var item in collection)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }




        //OrderBy ალაგებს ელემენტებს ზრდადობით(Ascending).

        public static IEnumerable<T> CustomOrderBy<T>(this IEnumerable<T> collection, Func<T, IComparable> keySelector)
        {
            List<T> sortedList = new List<T>(collection);
            sortedList.Sort((x, y) => keySelector(x).CompareTo(keySelector(y)));
            return sortedList;
        }





        //First აბრუნებს პირველ ელემენტს. თუ ელემენტი არ არსებობს, აგდებს Exception - ს.



        public static T  CustomFirst <T> (this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            foreach (var item in collection)
            {
                if (predicate(item))
                {
             return item;
                }
            }
            throw new InvalidOperationException("No element satisfies the condition.");
        }







        //FirstOrDefault აბრუნებს პირველ ელემენტს, ხოლო თუ ვერ იპოვა — აბრუნებს default მნიშვნელობას(null, 0, false და ა.შ.).


        public static T CustomFirstOrDefault<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            foreach (var item in collection)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default(T);
        }

        //Single აბრუნებს ერთადერთ ელემენტს, რომელიც პირობას აკმაყოფილებს. თუ არ არსებობს ან ერთზე მეტია — აგდებს Exception-ს.

        public static T CustomSingle<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            T result = default(T);
            bool found = false;
            foreach (var item in collection)
            {
                if (predicate(item))
                {
                    if (found)
                    {
                        throw new InvalidOperationException("More than one element satisfies the condition.");
                    }
                    result = item;
                    found = true;
                }
            }
            if (!found)
            {
                throw new InvalidOperationException("No element satisfies the condition.");
            }
            return result;
        }




        //SingleOrDefault აბრუნებს ერთადერთ ელემენტს, ხოლო თუ არ არსებობს — აბრუნებს default - ს.თუ ერთზე მეტია, მაინც აგდებს Exception-ს.



        public static T CustomSingleOrDefault<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            T result = default(T);
            bool found = false;
            foreach (var item in collection)
            {
                if (predicate(item))
                {
                    if (found)
                    {
                        throw new InvalidOperationException("More than one element satisfies the condition.");
                    }
                    result = item;
                    found = true;
                }
            }
            return result;
        }


        //Any ამოწმებს არსებობს თუ არა მინიმუმ ერთი ელემენტი, რომელიც პირობას აკმაყოფილებს. აბრუნებს true ან false.

        //All ამოწმებს აკმაყოფილებს თუ არა ყველა ელემენტი მოცემულ პირობას.აბრუნებს true ან false.

        //Count ითვლის ელემენტების რაოდენობას(სურვილის შემთხვევაში მხოლოდ იმათს, რომლებიც პირობას აკმაყოფილებენ).

        //Distinct აშორებს დუბლირებულ ელემენტებს და ტოვებს მხოლოდ უნიკალურ მნიშვნელობებს.






    }
}
