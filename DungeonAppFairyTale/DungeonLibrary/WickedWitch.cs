using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class WickedWitch : Opponent
    {

        //fields

        //props
        public bool IsWet { get; set; }

        //ctors
        public WickedWitch(string name, string description, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, bool isWet) : base(name, description, life, maxLife, hitChance, block, minDamage, maxDamage)
        {
            IsWet = isWet;
        }//end FQ CTOR
        public WickedWitch()
        {
            MaxLife = 30;
            Name = "Wicked Witch of the West";
            Description = "A snarling green-faced witch with a flock of winged monkeys.";
            Life = 30;
            HitChance = 12;
            Block = 30;
            MinDamage = 7;
            MaxDamage = 11;
            IsWet = false;
        }//end default WickedWitch ctor

        //methods
        public override string ToString()
        {
            return base.ToString() + (IsWet ? "She's wet! Steaming, screaming, and defenseless! (Except for those monkeys)" : "");
        }//end ToString()

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (IsWet)
            {
                calculatedBlock = 0;
            }//end if

            return calculatedBlock;
        }//end CalcBlock;

    }//end class
}//end namespace

