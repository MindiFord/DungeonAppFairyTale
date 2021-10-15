using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class FairyTaleItem
    {

        //fields
        private int _minDamage;

        //props
        public string Name { get; set; }
        public string ItemDescription { get; set; }
        public string Effect { get; set; }
        public int BonusHitChance { get; set; }
        public int MaxDamage { get; set; }
        
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }//end if
                else
                {
                    _minDamage = 1;
                }//end else
            }//end set
        }//end MinDamage prop
        
        //ctors
        public FairyTaleItem(string name, string itemDescription, string effect, int bonusHitChance, int maxDamage, int minDamage)
        {
            Name = name;
            ItemDescription = itemDescription;
            Effect = effect;
            BonusHitChance = bonusHitChance;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
        }//end FQ CTOR

        //methods
        public override string ToString()
        {
            return $"*** FAIRY TALE ITEM ***\n" +
                $"Name: {Name}\n" +
                $"Description: {ItemDescription}\n" +
                //$"Effect: {Effect}\n" +
                $"Bonus Hit Chance: {BonusHitChance}\n" +
                $"Damage: {MinDamage} to {MaxDamage}";
        }//end ToString()

    }//end class
}//end namespace
