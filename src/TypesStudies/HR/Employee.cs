using System;

namespace types.studies.HR
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public string email;
        public int numberOfHoursWorked;
        public double wage;
        public double hourlyrate;
        public DateTime birthDay;

        public Employee(string first, string last, string email, DateTime bd, double rate)
        {
            firstName = first;
            lastName = last;
            this.email = email;
            birthDay = bd;
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
