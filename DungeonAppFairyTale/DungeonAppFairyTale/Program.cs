using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace DungeonAppFairyTale
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Dungeon Application!!");

            int score = 0;

            //TODO Create the player and fairy tale item
            //need to create custom classes first... (Player & FairyTaleItem)
            FairyTaleItem hooksHook = new FairyTaleItem("Captain Hook's Hook", "Hook had to improvise when Peter Pan cut off his hand… or was it Rumpelstiltskin?", "", 5, 8, 2);

             Player hatter = new Player("The (Mad) Hatter", "Alice in Wonderland", 70, 10, 50, 50, hooksHook);

            //TODO Create a loop for the room and opponent to be created
            bool exit = false;

            do
            {
                //TODO - Create a room - DONE
                Console.WriteLine("Current Room: " + GetRoom());//displays random room using method created outside Main()

                //TODO - Create an opponent
                GingerbreadMan g1 = new GingerbreadMan();
                GingerbreadMan g2 = new GingerbreadMan("One-Legged Gingerbread Man", "Looks like somebody got hungry!", 15, 15, 5, 30, 4, 6, false);
                WickedWitch w1 = new WickedWitch();
                WickedWitch w2 = new WickedWitch("Melting Wicked Witch?", "A snarling green-faced witch with a flock of winged monkeys.", 10, 10, 5, 0, 3, 5, true);
                Rumpelstiltskin r1 = new Rumpelstiltskin();
                BigBadWolf b1 = new BigBadWolf();

                //Opponent array and random selection
                Opponent[] opponents = { g1, g2, w1, w2, r1, b1 };
                Random rand = new Random();
                Opponent opponent = opponents[rand.Next(opponents.Length)];

                //TODO - Display to the user (player) the opponent and the room they encountered
                Console.WriteLine("\nIn this room: " + opponent);

                //TODO - Create a loop for the menu - DONE
                bool reload = false;

                do
                {
                    //TODO - Create the menu
                    Console.Write($"\nPlease choose an action:\n" +
                        $"A) Attack\n" +
                        $"R) Run Away\n" +
                        $"P) Player Info\n" +
                        $"O) Opponent Info\n" +
                        $"X) Exit\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();

                    //TODO - Build out the switch for the menu
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Console.WriteLine("Attack");
                            //TODO - Handle Attack functionality
                            Combat.DoBattle(hatter, opponent);

                            //if opponent dies
                            if (opponent.Life <=0)
                            {
                                //opponent defeated, get new room and new opponent
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"You defeated {opponent.Name}!");
                                Console.ResetColor();
                                //get a new room
                                reload = true;
                                //add to player's score
                                score++;
                            }

                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("Run Away");
                            //TODO - Handle Run Away functionality
                            Console.WriteLine($"{opponent.Name} attacks you as you flee!");
                            Console.WriteLine();
                            Combat.DoAttack(opponent, hatter);
                            Console.WriteLine();
                            reload = true;
                            break;

                        case ConsoleKey.P:
                            Console.WriteLine("Player Info");
                            //TODO - Display the player info via the ToString()
                            Console.WriteLine(hatter);
                            Console.WriteLine("Opponents defeated: " + score);
                            break;

                        case ConsoleKey.O:
                            Console.WriteLine("Opponent Info");
                            //TODO - Display the Character info via the ToString()
                            Console.WriteLine(opponent);
                            break;

                        case ConsoleKey.X:
                            Console.WriteLine("Quit Game");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Please enter a valid option!");
                            break;
                    }//end switch menu

                    //TODO - Check player's life
                } while (!reload && !exit);

            } while (!exit);

        }//end Main()

        //TODO - Create GetRoom() and plug it in to the TODO above
        private static string GetRoom()
        {
            //TODO - Add more rooms and expand descriptions
            string[] rooms =
            {
                "The enchanted forest. It can feature as a place of threatening danger, or one of refuge, or a chance at adventure.",
                "A castle. You decide. There are so many.",
                "A witch's house. It looks like it's made of gingerbread, cake, and pastries! Delicious!",
                "A giant beanstalk so tall it goes right up in to the sky and into the clouds.",
                "Over the seven jewelled hills, beyond the seventh fall... a cottage! Are those dwarves?",
                "We're on a moving train! There are bears, giraffes, zebras... Look at the ears on that elephant! I'll bet he could fly!",
                "A house? An old shoe? A house shoe?! Where do all of these kids sleep?",
                "A tower in the middle of the woods, with neither stairs nor a door, and only one room and one window.",
                "A tower room filled with straw and a spinning wheel."


            };
            //return a random room

            Random rand = new Random();//creating new random object

            int indexRoom = rand.Next(rooms.Length);//getting random number to choose room by index

            string room = rooms[indexRoom];//creating string variable to display random room

            return room;//returning random rooms string

        }//end GetRoom()

    }//end class
}//end namespace
