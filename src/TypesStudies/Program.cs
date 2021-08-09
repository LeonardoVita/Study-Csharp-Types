using System;
using System.Globalization;
using types.studies.Enums;

namespace types.studies
{
    class Program
    {
        static void Main(string[] args)
        {
            //WorkingWithDatetime();           
            //usingParams();
            //usingEnums();
            usingObjects();
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
        private static void usingParams()
        {
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

            int average = CalculateAverageWage(1200, 1000, 500, 2500, 333);
            Console.WriteLine($"Average: {average}");
        }
        private static void usingEnums()
        {
            EmployeeTypeEnum employeeType = EmployeeTypeEnum.Manager;
            StoreTypeEnum storeType = StoreTypeEnum.Seating;
            int baseWage = 1000;

            string teste = "Manager";

            CalculateWageWithEnum(baseWage,(EmployeeTypeEnum) 2,(StoreTypeEnum) 10);

            Console.WriteLine(employeeType.ToString() == teste);
        }
        private static void usingObjects()
        {
            Employee employee = new Employee("Leonardo", "vita", "leonardo@teste.com", new DateTime(2021,06,25), EmployeeTypeEnum.Manager, 8.6);

            employee.DisplayEmployeeDetails();
            employee.PerformWork();
            employee.PerformWork();
            employee.PerformWork();
            employee.PerformWork();
            employee.ReceiveWage();

            Console.ReadLine();  
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
        public static int CalculateAverageWage(params int[] wages)
        {
            int total = 0;
            
            foreach (var wage in wages)
            {
                total += wage;
            }

            return total / wages.Length;
        }

        private static void CalculateWageWithEnum(int baseWage, EmployeeTypeEnum employee, StoreTypeEnum store)
        {
            int calculateWage = 0;

            if (employee == EmployeeTypeEnum.Manager)
            {
                calculateWage = baseWage * 3;
            }
            else
            {
                calculateWage = baseWage * 2; 
            }

            if (store == StoreTypeEnum.FullPieRestaurant)
                calculateWage += 500;
            else
                calculateWage += baseWage;

            Console.WriteLine($"The Calculated Wage is {calculateWage}");
        }
            
    }
}
