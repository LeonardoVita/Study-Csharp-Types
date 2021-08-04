using System;
using System.Globalization;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            //WorkingWithDatetime();

            int monthlyWage = 1234, 
                months = 12,
                bonusRef = 0;
            
            string multipleReturnsString;
            DateTime multipleReturnsDate;

            //Passagem de parametro por valor
            int yearlyWage = CalculateYearlyWage(monthlyWage, months);

            Console.WriteLine($"Yearly Wage: {yearlyWage}\n");

            //out nao precisa ser inicializado
            int yearlyWageOut = CalculateYearlyWage(monthlyWage, months, out int bonusOut, out multipleReturnsString, out multipleReturnsDate);

            Console.WriteLine($"out bonus: {bonusOut}\nyearly Wage Out: {yearlyWageOut}\n");
            Console.WriteLine($"out String: {multipleReturnsString}\nOut Date: {multipleReturnsDate}\n");

            //ref precisa ser inicializado
            int yearlyWageRef = CalculateYearlyWageRef(monthlyWage, months, ref bonusRef);

            Console.WriteLine($"ref bonus: {bonusRef}\nyearly Wage Ref: {yearlyWageRef}\n");

        }

        static void WorkingWithDatetime()
        {
            DateTime initialDate = new DateTime(2021, 8, 15, 22, 55, 25);
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
        public static int CalculateYearlyWage(int monthWage, int numberOfMonthWorked)
        {
            return monthWage * numberOfMonthWorked;
        }        
        public static int CalculateYearlyWage(int monthWage, int numberOfMonthWorked, out int bonus, out string multipleReturns, out DateTime multipleReturnsDate)
        {
            bonus = new Random().Next(1000);
            multipleReturns = "com out podemos fazer multiplos retornos até mesmo em um metodo que retorno void";
            multipleReturnsDate = DateTime.Now;
            return monthWage * numberOfMonthWorked + bonus;
        }
        public static int CalculateYearlyWageRef(int monthWage, int numberOfMonthWorked, ref int bonus)
        {
            bonus = new Random().Next(1000);
            return monthWage * numberOfMonthWorked + bonus;
        }
    }
}
