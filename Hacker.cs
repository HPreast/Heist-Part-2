using System;

namespace Heist2
{
    public class Hacker : IRobber
    {
        public string name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {

        }
    }
}