using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class BigBadWolf : Opponent
    {

        //fields

        //props
        public bool IsWet { get; set; }

        //ctors
        public BigBadWolf(string name, string description, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage) : base(name, description, life, maxLife, hitChance, block, minDamage, maxDamage)
        {

        }//end FQ CTOR
        public BigBadWolf()
        {
            MaxLife = 35;
            Name = "Big Bad Wolf";
            Description = "A ruthless, conniving wolf who plots to eat the Three Little Pigs.";
            Life = 35;
            HitChance = 15;
            Block = 40;
            MinDamage = 7;
            MaxDamage = 11;
        }//end default BigBadWolf ctor

        //methods
        public override string ToString()
        {
            return base.ToString() + ("He also tried to eat Little Red Riding Hood. This guy is dangerous.");
        }//end ToString()

        public override int CalcBlock()
        {
            int calculatedBlock = Block;


            return calculatedBlock;
        }//end CalcBlock;

    }//end class
}//end namespace



