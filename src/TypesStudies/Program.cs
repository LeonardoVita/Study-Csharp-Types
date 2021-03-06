using System;
using System.Globalization;
using types.studies.Enums;
using types.studies.HR;

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


        private static void WorkingWithDatetime()
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

            DailyWork();
            VirtualAndOverride1();
            VirtualAndOverride2();
            NewTag1();
            NewTag2();

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
        public static void CalculateWageWithEnum(int baseWage, EmployeeTypeEnum employee, StoreTypeEnum store)
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
        public static void DailyWork()
        {
            //Employee employee = new Employee("Leonardo", "vita", "leonardo@teste.com", new DateTime(2021, 06, 25), 8.6);
            Manager manager = new Manager("Thiago", "Almeida", "tiaguin@teste.com", new DateTime(2021, 06, 15), 8.6);
            Researcher researcher = new Researcher("Clarissa", "Vita", "enois@teste.com", new DateTime(2021, 08, 08), 8.6);

            //employee.PerformWork();
            //employee.PerformWork();
            //employee.PerformWork();
            //employee.PerformWork();
            //employee.ReceiveWage();
            //employee.DisplayEmployeeDetails();

            Console.WriteLine();


            manager.DisplayEmployeeDetails();
            manager.AttendManagementMeeting();

            Console.WriteLine();


            researcher.PerformWork();
            researcher.PerformWork();
            researcher.PerformWork();
            researcher.PerformWork();
            researcher.ReceiveWage();
            researcher.DisplayEmployeeDetails();

            Console.WriteLine();

        }         
        public static void VirtualAndOverride1()
        {
            Console.WriteLine("======= Virtual and Override sobrescreve o metodo =======\n");

            //Employee employee = new Employee("Leonardo", "vita", "leonardo@teste.com", new DateTime(2021, 06, 25), 8.6);
            Manager manager = new Manager("Thiago", "Almeida", "tiaguin@teste.com", new DateTime(2021, 06, 15), 8.6);
            Researcher researcher = new Researcher("Clarissa", "Vita", "enois@teste.com", new DateTime(2021, 08, 08), 8.6);

            //employee.GiveBonus();
            manager.GiveBonus();
            researcher.GiveBonus();

            Console.WriteLine();
        }
        public static void VirtualAndOverride2()
        {
            Console.WriteLine("======= Virtual and Override All Employee considera sempre o metodo mais especifico =======\n");

            //Employee employee = new Employee("Leonardo", "vita", "leonardo@teste.com", new DateTime(2021, 06, 25), 8.6);
            Employee manager = new Manager("Thiago", "Almeida", "tiaguin@teste.com", new DateTime(2021, 06, 15), 8.6);
            Employee researcher = new Researcher("Clarissa", "Vita", "enois@teste.com", new DateTime(2021, 08, 08), 8.6);

            //employee.GiveBonus();
            manager.GiveBonus();
            researcher.GiveBonus();

            Console.WriteLine();
        }
        public static void NewTag1()
        {
            Console.WriteLine("======= New Tag pode ocultar metodo da classe base =======\n");

            //Employee employee = new Employee("Leonardo", "vita", "leonardo@teste.com", new DateTime(2021, 06, 25), 8.6);
            Manager manager = new Manager("Thiago", "Almeida", "tiaguin@teste.com", new DateTime(2021, 06, 15), 8.6);
            Researcher researcher = new Researcher("Clarissa", "Vita", "enois@teste.com", new DateTime(2021, 08, 08), 8.6);

            //employee.CheckIn();
            manager.CheckIn();
            researcher.CheckIn();

            Console.WriteLine();
        }
        public static void NewTag2()
        {
            Console.WriteLine("======= New Tag All Employee considera o metodo da classe base =======\n");

            //Employee employee = new Employee("Leonardo", "vita", "leonardo@teste.com", new DateTime(2021, 06, 25), 8.6);
            Employee manager = new Manager("Thiago", "Almeida", "tiaguin@teste.com", new DateTime(2021, 06, 15), 8.6);
            Employee researcher = new Researcher("Clarissa", "Vita", "enois@teste.com", new DateTime(2021, 08, 08), 8.6);

            //employee.CheckIn();
            manager.CheckIn();
            researcher.CheckIn();

            Console.WriteLine();
        }

    }
}
