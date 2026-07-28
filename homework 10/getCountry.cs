using homework_10.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace homework_10
{
    internal class GetCountry
    {
        public static void GetCntry(Employ[] employs, Country country)
        {
            foreach (var emp in employs)
            {
                if (emp.Country == country)
                {
                    Console.WriteLine($"{emp.Name} {emp.Surname}");
                }
            }
        }
    }
}
