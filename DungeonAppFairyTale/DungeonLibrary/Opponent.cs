using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Opponent : Character
    {

        //fields
        private int _minDamage;

        //props
        public int MaxDamage { get; set; }
        public string Description { get; set; }

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
        }//end MinDamage


        //ctors
        public Opponent()
        {

        }

        public Opponent(string name, string description, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage)
        {
            //set MaxLife & MaxDamage first since they have rules
            MaxLife = maxLife;
            MaxDamage = maxDamage;

            Name = name;
            Description = description;
            Life = life;
            HitChance = hitChance;
            Block = block;
            MinDamage = minDamage;
        }//end FQ CTOR

        //methods
        public override string ToString()
        {
            return $"\n****** Opponent ******\n" +
                $"{Name}\n" +
                $"Life: {Life} to {MaxLife}\n" +
                $"Damage: {MinDamage} to {MaxDamage}\n" +
                $"Block: {Block}\n" +
                $"Description:\n{Description}\n";
        }//end ToString()

        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);//upper bounds in Next() is exclusive
        }//end CalcDamage()

    }//end class
}//end namespace

