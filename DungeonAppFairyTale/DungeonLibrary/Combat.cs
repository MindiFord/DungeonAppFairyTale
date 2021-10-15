using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {

        public static void DoAttack(Character attacker, Character defender)
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            System.Threading.Thread.Sleep(100);

            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                //calculate the damage
                int damageDealt = attacker.CalcDamage();
                //assign the damage
                defender.Life -= damageDealt;
                //write result to console
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");
                Console.ResetColor();
            }//end if
            else
            {
                //Attacker missed
                Console.WriteLine($"{attacker.Name} missed!");
            }//end else
        }//end DoAttack()

        public static void DoBattle(Player player, Opponent opponent)
        {
            DoAttack(player, opponent);

            //if opponent has life remaining, they get an attack
            if (opponent.Life > 0)
            {
                DoAttack(opponent, player);
            }//end if
        }//end DoBattle()

    }//end class
}//end namespace
