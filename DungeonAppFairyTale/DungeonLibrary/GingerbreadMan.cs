using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class GingerbreadMan : Opponent
    {

        //fields

        //props
        public bool IsFast { get; set; }

        //ctors
        public GingerbreadMan(string name, string description, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, bool isFast) : base(name, description, life, maxLife, hitChance, block, minDamage, maxDamage)
        {
            IsFast = isFast;
        }//end FQ CTOR
        public GingerbreadMan()
        {
            MaxLife = 15;
            Name = "Gingerbread Man";
            Description = "A delicious looking cookie shaped like a man.";
            Life = 15;
            HitChance = 5;
            Block = 30;
            MinDamage = 4;
            MaxDamage = 6;
            IsFast = true;
        }//end default GingerbreadMan ctor

        //methods
        public override string ToString()
        {
            return base.ToString() + (IsFast ? "This guy is FAST!" : "Somebody ate his leg! That outta slow him down...");
        }//end ToString()

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (!IsFast)
            {
                calculatedBlock -= calculatedBlock / 2;
            }//end if

            return calculatedBlock;
        }//end CalcBlock;

    }//end class
}//end namespace
