using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Rumpelstiltskin : Opponent
    {

        //fields

        //props
        public bool IsWet { get; set; }

        //ctors
        public Rumpelstiltskin(string name, string description, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage) : base(name, description, life, maxLife, hitChance, block, minDamage, maxDamage)
        {
            
        }//end FQ CTOR
        public Rumpelstiltskin()
        {
            MaxLife = 35;
            Name = "Rumpelstiltskin";
            Description = "A small, imp-like creature that can't pass up a good deal.";
            Life = 35;
            HitChance = 15;
            Block = 40;
            MinDamage = 7;
            MaxDamage = 11;
        }//end default Rumpel ctor

        //methods
        public override string ToString()
        {
            return base.ToString() + ("He spins straw into gold!");
        }//end ToString()

        public override int CalcBlock()
        {
            int calculatedBlock = Block;


            return calculatedBlock;
        }//end CalcBlock;

    }//end class
}//end namespace


