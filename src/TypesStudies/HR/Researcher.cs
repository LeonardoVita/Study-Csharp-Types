using System;

namespace types.studies.HR
{
    public class Researcher : Employee
    {
        public Researcher(string first, string last, string email, DateTime bd, double rate) : base(first,last,email,bd,rate)
        {
            
        }

        public override void GiveBonus()
        {
            Console.WriteLine($"{firstName} {lastName} Recebeu um bonus de investigador 200!");
        }

        public void CheckIn()
        {
            Console.WriteLine($"{firstName} {lastName} fez o checkin de investigador!");
        }

    }
}
