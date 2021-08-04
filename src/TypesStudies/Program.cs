using System;
using System.Globalization;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime initialDate = new DateTime(2021, 8, 15,22,55,25);
            var cultureInfo = new CultureInfo("en-US");
            string dateString = "1995/01/21";
            DateTime cultureDateTime = DateTime.Parse(dateString);

            Console.WriteLine(initialDate);
            Console.WriteLine($"To Long Date: {initialDate.ToLongDateString()}");
            Console.WriteLine($"To Long Time: {initialDate.ToLongTimeString()}");

            Console.WriteLine($"To Short Date: {initialDate.ToShortDateString()}");
            Console.WriteLine($"To Short Time: {initialDate.ToShortTimeString()}");

            Console.WriteLine($"===============================================");

            Console.WriteLine($"Culture Date: {cultureDateTime.ToLongDateString()}");
            Console.WriteLine($"Culture Date: {cultureInfo.Name}");

            
        }
    }
}
