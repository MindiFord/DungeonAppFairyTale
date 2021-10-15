using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The (Mad) Hatter will be our basic character until (if) we build more to choose from 

namespace DungeonLibrary
{
    public sealed class Player : Character
    {
        //fields

        //props
        public FairyTaleItem EquippedItem { get; set; }
        public string FairyTale { get; set; }

        //ctor
        public Player(string name, string fairyTale, int hitChance, int block, int maxLife, int life, FairyTaleItem equippedItem)
        {
            Name = name;
            FairyTale = fairyTale;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            Life = life;
            EquippedItem = equippedItem;

        }//end ctor

        //methods
        public override string ToString()
        {
            return string.Format("-=-= {0} =-=-\n" +
                "Description: {1} \n" +
                "Life: {2} of {3}\n" +
                "Hit Chance: {4}%\n" +
                "Fairy Tale Item:\n{5}\n" +
                "Block: {6}\n",
                Name,
                FairyTale,
                Life, MaxLife,
                CalcHitChance(),
                EquippedItem,
                Block);
        }//end ToString

        //Override the basic methods from Character
        public override int CalcDamage()
        {
            return new Random().Next(EquippedItem.MinDamage, EquippedItem.MaxDamage + 1);
        }//end CalcDamage()

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedItem.BonusHitChance;
        }

    }//end class
}//end namespace
