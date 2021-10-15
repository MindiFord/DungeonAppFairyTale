using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This class is a base class for all characters (players and opponents). Only items that apply to EVERY character in the game should go here. Everything else will go in individual library class.

namespace DungeonLibrary
{
    public abstract class Character//abstract means I can't create an object of type Character
    {

        //fields
        private int _life;//has rules so can't use prop shortcut

        //props
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int MaxLife { get; set; }

        public int Life
        {
            get { return _life; }
            //life should not be more than maxLife
            set
            {
                if (value <= MaxLife)
                {
                    _life = value;
                }//end if
                else
                {
                    _life = MaxLife;
                }
            }//end set
        }//end Life prop

        //ctors
            //no ctors - build those in child classes 
            //There is still a default

        //methods
            //no ToString() - build those in child classes
            //Make all universal methods to override in child classes (virtual)
        
        public virtual int CalcBlock()
        {
            return Block;
        }//end CalcBlock()

        public virtual int CalcHitChance()
        {
            return HitChance;
        }//end CalcHitChance()

        public virtual int CalcDamage()
        {
            return 0;
        }//end CalcDamage()

    }//end class
}//end namespace
