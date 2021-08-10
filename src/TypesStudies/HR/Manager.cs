using System;

namespace types.studies.HR
{
    public class Manager : Employee
    {
        public Manager(string first, string last, string email, DateTime bd, double rate) : base(first,last,email,bd,rate)
        {
               
        }

        public void AttendManagementMeeting()
        {
            numberOfHoursWorked += 10;
            Console.WriteLine($"Manager {firstName} {lastName} está atendendo a uma ligação longa de negocios");
        }
    }
}
