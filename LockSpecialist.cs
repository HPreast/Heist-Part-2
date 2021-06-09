using System;

namespace Heist2
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.VaultScore -= SkillLevel;
            Console.WriteLine($"{Name} is breaking into the vault. The vault's security has been decreased by {SkillLevel} points.");
            if (bank.VaultScore == 0)
            {
                Console.WriteLine($"{Name} has cracked the safe!");
            }
        }
    }
}