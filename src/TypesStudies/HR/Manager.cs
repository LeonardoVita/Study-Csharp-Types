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
            Console.WriteLine($"O gerente {firstName} {lastName} está atendendo a uma ligação longa de negocios");
        }

        public override void GiveBonus()
        {
            Console.WriteLine($"{firstName} {lastName} Recebeu um bonus de gerente 250!");
        }

        public new void CheckIn()
        {
            Console.WriteLine($"{firstName} {lastName} fez o checkin de gerente!");
        }

        public override void AskForVacation()
        {
            Console.WriteLine($"{firstName} {lastName} pediu ferias de gerente!");
        }
    }
}
