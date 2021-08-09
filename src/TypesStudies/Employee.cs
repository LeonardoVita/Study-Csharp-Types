using System;
using types.studies.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace types.studies
{
    class Employee
    {
        public string firstName;
        public string lastName;
        public string email;
        public int numberOfHoursWorked;
        public double wage;
        public double hourlyrate;
        public DateTime birthDay;

        public EmployeeTypeEnum employeeType;

        public Employee(string fisrt, string last, string email, DateTime bd, EmployeeTypeEnum type, double rate)
        {
            firstName = fisrt;
            lastName = last;
            this.email = email;
            birthDay = bd;
            employeeType = type;
            hourlyrate = rate;
        }

        public void PerformWork()
        {
            numberOfHoursWorked++;

            Console.WriteLine($"{firstName} {lastName} is now working!");
        }

        public void StopWork()
        {
            Console.WriteLine($"{firstName} {lastName} has stopped working!");
        }

        public double ReceiveWage()
        {
            wage = numberOfHoursWorked * hourlyrate;
            
            Console.WriteLine($"The wage for {numberOfHoursWorked} hours of work is {wage}.");
            numberOfHoursWorked = 0;

            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"First Name: {firstName}\nLast Name: {lastName}\nEmail: {email}");
        }
    }
}
