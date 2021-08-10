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

            Console.WriteLine($"{firstName} {lastName} Está trabalhando agora!");
        }

        public void StopWork()
        {
            Console.WriteLine($"{firstName} {lastName}Parou de trabalhar!");
        }

        public double ReceiveWage()
        {
            wage = numberOfHoursWorked * hourlyrate;
            
            Console.WriteLine($"A remuneração para {numberOfHoursWorked} Horas de trabalho sera: {wage}.");
            numberOfHoursWorked = 0;

            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Nome: {firstName}\nSobrenome: {lastName}\nEmail: {email}");
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"{firstName} {lastName} Recebeu um bonus generico 100!");
        }

        public void CheckIn()
        {
            Console.WriteLine($"{firstName} {lastName} fez o checkin generico!");
        }
    }
}
