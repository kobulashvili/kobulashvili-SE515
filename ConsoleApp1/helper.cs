using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class helper
    {

        //            Count

        //ითვლის ელემენტების რაოდენობას(სურვილის შემთხვევაში მხოლოდ იმათს, რომლებიც პირობას აკმაყოფილებენ).


        public int[] collection = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        public static int CastumCount<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            int count = 0;
            foreach (var item in collection)
            {
                if (predicate(item))
                {
                    count++;
                }
            }
            return count;
        }





    }
}
