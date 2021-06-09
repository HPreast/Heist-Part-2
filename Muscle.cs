using System;

namespace Heist2
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore -= SkillLevel;
            Console.WriteLine($"{Name} is holding off security. Security has been decreased by {SkillLevel} points.");
            if (bank.SecurityGuardScore == 0)
            {
                Console.WriteLine($"{Name} has handled the security guards!");
            }
        }
    }
}